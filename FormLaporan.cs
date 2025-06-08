using System;
using System.Data;
using System.Windows.Forms;
using Npgsql;

namespace PROJEK_AKHIR
{
    public partial class FormLaporan : Form
    {
        private string connectionString = "Host=localhost;Port=5432;Username=postgres;Password=jodiefer;Database=CANKULLIN";

        public FormLaporan()
        {
            InitializeComponent();
            LoadStatistics();
        }

        private void LoadStatistics()
        {
            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();

                string queryAdmin = "Select Count(*) From admin";
                using (var cmd = new NpgsqlCommand(queryAdmin, conn))
                {
                    var result = cmd.ExecuteScalar();
                    lblJumlahAdmin.Text = result.ToString();
                }

                string queryJenisAlat = "Select Count(DISTINCT nama_alat) From alat Where is_active = TRUE";
                using (var cmd = new NpgsqlCommand(queryJenisAlat, conn))
                {
                    var result = cmd.ExecuteScalar();
                    lblJenisAlat.Text = result.ToString();
                }

                string queryAlatTersedia = "Select Sum(jumlah) From alat Where is_active = TRUE ";
                using (var cmd = new NpgsqlCommand(queryAlatTersedia, conn))
                {
                    var result = cmd.ExecuteScalar();
                    lblAlatTersedia.Text = result.ToString();
                }

                string queryAlatDipinjam = "Select Count(*) From detail_pnjm WHERE id_pinjam IN (SELECT id_pinjam FROM pinjam WHERE id_status != 3)";
                using (var cmd = new NpgsqlCommand(queryAlatDipinjam, conn))
                {
                    var result = cmd.ExecuteScalar();
                    lblAlatDipinjam.Text = result.ToString();
                }

                string queryRiwayat30Hari = "Select Count(*) From pinjam Where tanggal_kembali >= CURRENT_DATE - INTERVAL '30 days' AND id_status = 3";
                using (var cmd = new NpgsqlCommand(queryRiwayat30Hari, conn))
                {
                    var result = cmd.ExecuteScalar();
                    lblPengembalian30.Text = result.ToString();
                }

                string queryRiwayat7Hari = "Select Count(*) From pinjam Where tanggal_kembali >= CURRENT_DATE - INTERVAL '7 days' AND id_status = 3";
                using (var cmd = new NpgsqlCommand(queryRiwayat7Hari, conn))
                {
                    var result = cmd.ExecuteScalar();
                    lblPengembalian7.Text = result.ToString();
                }

                string queryPeminjaman30Hari = "Select Count(*) From pinjam Where tanggal_pinjam >= CURRENT_DATE - INTERVAL '30 days'";
                using (var cmd = new NpgsqlCommand(queryPeminjaman30Hari, conn))
                {
                    var result = cmd.ExecuteScalar();
                    lblPeminjaman30.Text = result.ToString();
                }

                string queryPeminjaman7Hari = "Select Count(*) From pinjam Where tanggal_pinjam >= CURRENT_DATE - INTERVAL '7 days'";
                using (var cmd = new NpgsqlCommand(queryPeminjaman7Hari, conn))
                {
                    var result = cmd.ExecuteScalar();
                    lblPeminjaman7.Text = result.ToString();
                }
            }
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

        private void btnKelompokTani_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormKelompokTani formKelomppokTani = new FormKelompokTani();
            formKelomppokTani.Show();
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


        private void btnInformasiAlat_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormInformasiAlat formInformasiAlat = new FormInformasiAlat();
            formInformasiAlat.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormHome formHome = new FormHome();
            formHome.Show();
        }

        private void FormLaporan_Load(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click_2(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click_3(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}