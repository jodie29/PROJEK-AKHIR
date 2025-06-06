using System;
using System.Data;
using System.Windows.Forms;
using Npgsql;

namespace PROJEK_AKHIR
{
    public partial class FormRiwayat : Form
    {
        private string connectionString = "Host=localhost;Port=5432;Username=postgres;Password=Rfqh0_;Database=CANKULLIN";
        private int idPinjamDipilih = -1;

        public FormRiwayat()
        {
            InitializeComponent();
            cmbStatus.Items.Add("All");
            cmbStatus.Items.Add("Dipinjam");
            cmbStatus.Items.Add("Perlu Pengingat");
            cmbStatus.Items.Add("Dikembalikan");
            cmbStatus.SelectedIndex = 0;

            LoadDataRiwayat();

            txtSearch.TextChanged += txtSearch_TextChanged;

            cmbStatus.SelectedIndexChanged += cmbStatus_SelectedIndexChanged;
        }


        private void LoadDataRiwayat()
        {
            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                string query = @"SELECT p.id_pinjam, k.nama_kelompoktani, p.tanggal_pinjam, p.tenggat_pinjam, p.tanggal_kembali, s.deskripsi AS status, k.deskripsi_jalan || ',' || a.desa || ',' || a.kecamatan || ',' || a.kabupaten AS alamat, k.nik, k.no_hp_kelompoktani, ad.nama_admin, al.nama_alat, dp.jumlah, k.jumlah_kelompoktani
                FROM pinjam p
                JOIN kelompok_tani k ON p.id_kelompoktani = k.id_kelompoktani
                JOIN status s ON p.id_status = s.id_status
                JOIN alamat a ON k.id_alamat = a.id_alamat
                JOIN admin ad ON p.id_admin = ad.id_admin
                JOIN detail_pnjm dp ON p.id_pinjam = dp.id_pinjam
                JOIN alat al ON dp.id_alat = al.id_alat
                ORDER BY p.tanggal_pinjam DESC"; 

                NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dtGridRiwayat.DataSource = dt;

                dtGridRiwayat.Columns["id_pinjam"].Visible = false;

                dtGridRiwayat.Columns["nama_kelompoktani"].HeaderText = "Kelompok Tani";
                dtGridRiwayat.Columns["alamat"].HeaderText = "Alamat (Desa, Kecamatan, Kabupaten, Jalan)";
                dtGridRiwayat.Columns["nik"].HeaderText = "NIK";
                dtGridRiwayat.Columns["no_hp_kelompoktani"].HeaderText = "No HP";
                dtGridRiwayat.Columns["nama_admin"].HeaderText = "Admin Yang Menangani";
                dtGridRiwayat.Columns["nama_alat"].HeaderText = "Alat";
                dtGridRiwayat.Columns["jumlah"].HeaderText = "Jumlah Pinjam";
                dtGridRiwayat.Columns["tanggal_pinjam"].HeaderText = "Tanggal Pinjam";
                dtGridRiwayat.Columns["tenggat_pinjam"].HeaderText = "Tenggat Pinjam";
                dtGridRiwayat.Columns["tanggal_kembali"].HeaderText = "Tanggal Kembali";
                dtGridRiwayat.Columns["status"].HeaderText = "Status";
                dtGridRiwayat.Columns["jumlah_kelompoktani"].HeaderText = "Jumlah Anggota Kelompok Tani";

                dtGridRiwayat.Columns["nama_kelompoktani"].Width = 180;
                dtGridRiwayat.Columns["alamat"].Width = 250; 
                dtGridRiwayat.Columns["nik"].Width = 120;
                dtGridRiwayat.Columns["no_hp_kelompoktani"].Width = 120;
                dtGridRiwayat.Columns["nama_admin"].Width = 165;
                dtGridRiwayat.Columns["nama_alat"].Width = 100;
                dtGridRiwayat.Columns["jumlah"].Width = 100;
                dtGridRiwayat.Columns["tanggal_pinjam"].Width = 120;
                dtGridRiwayat.Columns["tenggat_pinjam"].Width = 120;
                dtGridRiwayat.Columns["tanggal_kembali"].Width = 120;
                dtGridRiwayat.Columns["status"].Width = 100;
                dtGridRiwayat.Columns["jumlah_kelompoktani"].Width = 120;
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = (DataTable)dtGridRiwayat.DataSource;

            string filterExpression = string.Format("nama_kelompoktani LIKE '{0}%'",
                txtSearch.Text);

            dt.DefaultView.RowFilter = filterExpression;
        }

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = (DataTable)dtGridRiwayat.DataSource;
            string statusFilter = cmbStatus.SelectedItem.ToString();

            if (statusFilter == "All")
            {
                dt.DefaultView.RowFilter = string.Empty; 
            }
            else
            {
                string filterExpression = string.Format("status = '{0}'", statusFilter);
                dt.DefaultView.RowFilter = filterExpression; 
            }
        }
    }
}
