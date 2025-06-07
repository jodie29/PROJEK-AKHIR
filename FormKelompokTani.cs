using Npgsql;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace PROJEK_AKHIR
{
    public partial class FormKelompokTani : Form
    {
        string connectionString = "Host=localhost;Username=postgres;Password=Rfqh0_;Database=CANKULLIN";

        public FormKelompokTani()
        {
            InitializeComponent();
        }

        private void SoftDeleteKelompokTaniFromDatabase(string idKelompokTani)
        {
            using (var conn = new Npgsql.NpgsqlConnection(connectionString))
            {
                conn.Open();

                string query = "UPDATE kelompok_tani SET is_active = FALSE WHERE id_kelompoktani = @id_kelompoktani";
                using (var cmd = new Npgsql.NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("id_kelompoktani", idKelompokTani);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void TampilkanKelompokTani()
        {
            try
            {
                string query = "SELECT k.id_kelompoktani, k.nama_kelompoktani, k.nik, k.jumlah_kelompoktani, k.no_hp_kelompoktani, k.deskripsi_jalan, " +
               "COALESCE(a.desa, '') || ',' || COALESCE(a.kecamatan, '') || ',' || COALESCE(a.kabupaten, '') AS alamat " +
               "FROM kelompok_tani k " +
               "LEFT JOIN alamat a ON k.id_alamat = a.id_alamat " +
               "WHERE k.is_active = TRUE " +
               "ORDER BY k.id_kelompoktani ASC";


                using (var conn = new Npgsql.NpgsqlConnection(connectionString))
                {
                    conn.Open();
                    NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(query, conn);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    dataGridView1.DataSource = dataTable;

                    dataGridView1.Columns["id_kelompoktani"].HeaderText = "Kode";
                    dataGridView1.Columns["nama_kelompoktani"].HeaderText = "Nama Kelompok Tani";
                    dataGridView1.Columns["nik"].HeaderText = "NIK";
                    dataGridView1.Columns["jumlah_kelompoktani"].HeaderText = "Jumlah Anggota";
                    dataGridView1.Columns["no_hp_kelompoktani"].HeaderText = "Nomor HP";
                    dataGridView1.Columns["deskripsi_jalan"].HeaderText = "Deskripsi Jalan";
                    dataGridView1.Columns["alamat"].HeaderText = "Alamat";

                    dataGridView1.Columns["id_kelompoktani"].Width = 100;
                    dataGridView1.Columns["nama_kelompoktani"].Width = 200;
                    dataGridView1.Columns["nik"].Width = 130;
                    dataGridView1.Columns["jumlah_kelompoktani"].Width = 120;
                    dataGridView1.Columns["no_hp_kelompoktani"].Width = 130;
                    dataGridView1.Columns["deskripsi_jalan"].Width = 130;
                    dataGridView1.Columns["alamat"].Width = 250;

                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan saat mengambil data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    var selectedRow = dataGridView1.SelectedRows[0];
                    var idKelompokTaniValue = selectedRow.Cells["id_kelompoktani"].Value.ToString();

                    DialogResult dialogResult = MessageBox.Show(
                        $"Anda yakin ingin menonaktifkan data Kelompok Tani dengan ID '{idKelompokTaniValue}'?",
                        "Konfirmasi Nonaktifkan Data",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                    if (dialogResult == DialogResult.Yes)
                    {
                        SoftDeleteKelompokTaniFromDatabase(idKelompokTaniValue);

                        TampilkanKelompokTani();
                        MessageBox.Show("Data Kelompok Tani berhasil dinonaktifkan.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Silakan pilih baris data Kelompok Tani yang ingin dinonaktifkan.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan saat menonaktifkan data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void KondisiAwal()
        {
            LblJam.Text = DateTime.Now.ToString("hh:mm:ss tt");
            LblTanggal.Text = DateTime.Now.ToString("dd-MM-yyyy");
            TampilkanKelompokTani();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            LblJam.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        
        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormHome formHome = new FormHome();
            formHome.Show();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAdmin formAdmin = new FormAdmin();
            formAdmin.Show();
        }

        private void btnInformasiAlat_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormInformasiAlat formInformasiAlat = new FormInformasiAlat();
            formInformasiAlat.Show();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            LblJam.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        private void FormKelompokTani_Load_1(object sender, EventArgs e)
        {
            KondisiAwal();
        }

        private void btnPeminjaman_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormPeminjaman formPeminjaman = new FormPeminjaman();
            formPeminjaman.Show();
        }

        private void btnPengembalian_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormPenggembalian formPenggembalian = new FormPenggembalian();
            formPenggembalian.Show();
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormKelompokTaniEdit formKelompokTaniEdit = new FormKelompokTaniEdit();
            formKelompokTaniEdit.Show();
        }
    }
}
