using Npgsql;
using System;
using System.Data;
using System.Windows.Forms;

namespace PROJEK_AKHIR
{
    public partial class FormPeminjaman : Form
    {
        string connectionString = "Host=localhost;Username=postgres;Password=Rfqh0_;Database=CANKULLIN";

        public FormPeminjaman()
        {
            InitializeComponent();
        }

        private void TampilkanPeminjaman()
        {
            try
            {
                string query = @"
            Select k.nama_kelompoktani, k.jumlah_kelompoktani, a.desa || ',' || a.kecamatan || ',' || a.kabupaten AS alamat, ad.nama_admin, al.nama_alat, dp.jumlah, p.tanggal_pinjam, p.tenggat_pinjam, s.deskripsi AS status 
            From pinjam p
            Join detail_pnjm dp On p.id_pinjam = dp.id_pinjam
            Join alat al On dp.id_alat = al.id_alat
            Join kelompok_tani k On p.id_kelompoktani = k.id_kelompoktani
            Join admin ad On p.id_admin = ad.id_admin
            Join status s On p.id_status = s.id_status
            Join alamat a On k.id_alamat = a.id_alamat
            Order By p.tanggal_pinjam Desc;
        ";

                using (var conn = new NpgsqlConnection(connectionString))
                {
                    conn.Open();
                    NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(query, conn);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    dataGridViewPeminjaman.DataSource = dataTable;

                    dataGridViewPeminjaman.Columns["nama_kelompoktani"].HeaderText = "Nama Kelompok Tani";
                    dataGridViewPeminjaman.Columns["alamat"].HeaderText = "Alamat Kelompok Tani";
                    dataGridViewPeminjaman.Columns["nama_admin"].HeaderText = "Admin yang Melayani";
                    dataGridViewPeminjaman.Columns["nama_alat"].HeaderText = "Alat yang Dipinjam";
                    dataGridViewPeminjaman.Columns["jumlah"].HeaderText = "Jumlah Pinjam";
                    dataGridViewPeminjaman.Columns["tanggal_pinjam"].HeaderText = "Tanggal Pinjam";
                    dataGridViewPeminjaman.Columns["tenggat_pinjam"].HeaderText = "Tenggat Pinjam";
                    dataGridViewPeminjaman.Columns["status"].HeaderText = "Status";
                    dataGridViewPeminjaman.Columns["jumlah_kelompoktani"].HeaderText = "Jumlah Anggota Kelompok Tani";

                    dataGridViewPeminjaman.Columns["nama_kelompoktani"].Width = 200;
                    dataGridViewPeminjaman.Columns["alamat"].Width = 250;
                    dataGridViewPeminjaman.Columns["nama_admin"].Width = 150;
                    dataGridViewPeminjaman.Columns["nama_alat"].Width = 150;
                    dataGridViewPeminjaman.Columns["jumlah"].Width = 100;
                    dataGridViewPeminjaman.Columns["tanggal_pinjam"].Width = 120;
                    dataGridViewPeminjaman.Columns["tenggat_pinjam"].Width = 120;
                    dataGridViewPeminjaman.Columns["status"].Width = 120;
                    dataGridViewPeminjaman.Columns["jumlah_kelompoktani"].Width = 150;

                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan saat mengambil data peminjaman: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void FormPeminjaman_Load(object sender, EventArgs e)
        {
            TampilkanPeminjaman(); 
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormPeminjamanKT formPeminjamanKT = new FormPeminjamanKT();
            formPeminjamanKT.Show();
        }
    }
}
