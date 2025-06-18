using System;
using System.Data;
using System.Windows.Forms;
using Npgsql;

namespace PROJEK_AKHIR
{
    public partial class FormPenggembalian : Form
    {
        private string connectionString = "Host=localhost;Port=5432;Username=postgres;Password=jodiefer;Database=CANKULLIN";
        private int idPinjamDipilih = -1;

        public FormPenggembalian()
        {
            InitializeComponent();
            LoadDataPengembalian();
            dtGridPengembalian.CellClick += dtGridPengembalian_CellClick;

            txtSearch.TextChanged += txtSearch_TextChanged;
        }

        private void LoadDataPengembalian()
        {
            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                string query = @"
                    SELECT p.id_pinjam, k.nama_kelompoktani, p.tanggal_pinjam, p.tenggat_pinjam, p.tanggal_kembali, s.deskripsi AS status, a.desa || ', ' || a.kecamatan || ', ' || a.kabupaten AS alamat, ad.nama_admin, al.nama_alat, dp.jumlah, k.jumlah_kelompoktani
                    FROM pinjam p
                    JOIN kelompok_tani k ON p.id_kelompoktani = k.id_kelompoktani
                    JOIN status s ON p.id_status = s.id_status
                    JOIN alamat a ON k.id_alamat = a.id_alamat
                    JOIN admin ad ON p.id_admin = ad.id_admin
                    JOIN detail_pnjm dp ON p.id_pinjam = dp.id_pinjam
                    JOIN alat al ON dp.id_alat = al.id_alat
                    ORDER BY k.nama_kelompoktani ASC"; 

                NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dtGridPengembalian.DataSource = dt;

                dtGridPengembalian.Columns["id_pinjam"].Visible = false;

                dtGridPengembalian.Columns["nama_kelompoktani"].HeaderText = "Kelompok Tani";
                dtGridPengembalian.Columns["alamat"].HeaderText = "Alamat";
                dtGridPengembalian.Columns["nama_admin"].HeaderText = "Admin Yang Menangani";
                dtGridPengembalian.Columns["nama_alat"].HeaderText = "Alat";
                dtGridPengembalian.Columns["jumlah"].HeaderText = "Jumlah Pinjam";
                dtGridPengembalian.Columns["tanggal_pinjam"].HeaderText = "Tanggal Pinjam";
                dtGridPengembalian.Columns["tenggat_pinjam"].HeaderText = "Tenggat Pinjam";
                dtGridPengembalian.Columns["tanggal_kembali"].HeaderText = "Tanggal Kembali";
                dtGridPengembalian.Columns["status"].HeaderText = "Status";
                dtGridPengembalian.Columns["jumlah_kelompoktani"].HeaderText = "Jumlah Anggota Kelompok Tani";

                dtGridPengembalian.Columns["nama_kelompoktani"].Width = 180;
                dtGridPengembalian.Columns["alamat"].Width = 190;
                dtGridPengembalian.Columns["nama_admin"].Width = 165;
                dtGridPengembalian.Columns["nama_alat"].Width = 100;
                dtGridPengembalian.Columns["jumlah"].Width = 100;
                dtGridPengembalian.Columns["tanggal_pinjam"].Width = 120;
                dtGridPengembalian.Columns["tenggat_pinjam"].Width = 120;
                dtGridPengembalian.Columns["tanggal_kembali"].Width = 120;
                dtGridPengembalian.Columns["status"].Width = 100;
                dtGridPengembalian.Columns["jumlah_kelompoktani"].Width = 120;
            }
        }

        private void dtGridPengembalian_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtGridPengembalian.Rows[e.RowIndex];

                if (row.Cells["id_pinjam"] != null)
                {
                    idPinjamDipilih = Convert.ToInt32(row.Cells["id_pinjam"].Value);
                }
                else
                {
                    MessageBox.Show("Column 'id_pinjam' not found.");
                    return;
                }

                string namaKelompokTani = row.Cells["nama_kelompoktani"].Value.ToString();
                string status = row.Cells["status"].Value.ToString();
                string tanggalKembali = row.Cells["tanggal_kembali"].Value.ToString();

                txtNamaKelompokTani.Text = namaKelompokTani;
                txtTanggalKembali.Text = DateTime.Now.ToString("yyyy-MM-dd");
                txtStatus.Text = status;

                if (status != "Dikembalikan" && string.IsNullOrEmpty(tanggalKembali))
                {
                    btnKembalikan.Enabled = true;
                }
                else
                {
                    btnKembalikan.Enabled = false;
                }
            }
        }


        private void KosongkanForm()
        {
            txtNamaKelompokTani.Clear();
            txtTanggalKembali.Clear();
            txtStatus.Clear();
        }

        private void btnKembalikan_Click_1(object sender, EventArgs e)
        {
            if (idPinjamDipilih != -1)
            {
                using (var conn = new NpgsqlConnection(connectionString))
                {
                    conn.Open();

                    string updateQuery = "UPDATE pinjam SET tanggal_kembali = @tglKembali, id_status = 3 WHERE id_pinjam = @id";

                    using (var cmd = new NpgsqlCommand(updateQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@tglKembali", DateTime.Now); 
                        cmd.Parameters.AddWithValue("@id", idPinjamDipilih);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Pengembalian berhasil disimpan dan status diperbarui.");

                LoadDataPengembalian();
                KosongkanForm();
                idPinjamDipilih = -1;
            }
            else
            {
                MessageBox.Show("Pilih data yang ingin dikembalikan terlebih dahulu.");
            }
        }


        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = (DataTable)dtGridPengembalian.DataSource;

            string filterExpression = string.Format("nama_kelompoktani LIKE '{0}%'",
                txtSearch.Text);

            dt.DefaultView.RowFilter = filterExpression;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormHome formHome = new FormHome();
            formHome.Show();
        }

        private void btnPeminjaman_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAdmin formAdminn = new FormAdmin();
            formAdminn.Show();
        }

        private void btnInformasiAlat_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormInformasiAlat formInformasiAlat = new FormInformasiAlat();
            formInformasiAlat.Show();
        }

        private void btnRiwayat_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormRiwayat formRiwayat = new FormRiwayat();
            formRiwayat.Show();
        }

        private void btnLaporan_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLaporan formLaporan = new FormLaporan();
            formLaporan.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormHome formHome = new FormHome();
            formHome.Show();
        }

        private void btnPeminjaman_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            FormPeminjaman formPeminjaman = new FormPeminjaman();
            formPeminjaman.Show();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAdmin formAdmin = new FormAdmin();
            formAdmin.Show();
        }

        private void btnKelompokTani_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            FormKelompokTani formKelomppokTani = new FormKelompokTani();
            formKelomppokTani.Show();
        }
    }
}
