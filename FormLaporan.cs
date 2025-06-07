using System;
using System.Data;
using System.Windows.Forms;
using Npgsql;

namespace PROJEK_AKHIR
{
    public partial class FormLaporan : Form
    {
        private string connectionString = "Host=localhost;Port=5432;Username=postgres;Password=Rfqh0_;Database=CANKULLIN";

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
                    txtJumlahAdmin.Text = result.ToString();
                }

                string queryJenisAlat = "Select Count(DISTINCT nama_alat) From alat Where is_active = TRUE";
                using (var cmd = new NpgsqlCommand(queryJenisAlat, conn))
                {
                    var result = cmd.ExecuteScalar();
                    txtJenisAlat.Text = result.ToString();
                }

                string queryAlatTersedia = "Select Sum(jumlah) From alat Where is_active = TRUE ";
                using (var cmd = new NpgsqlCommand(queryAlatTersedia, conn))
                {
                    var result = cmd.ExecuteScalar();
                    txtAlatTersedia.Text = result.ToString();
                }

                string queryAlatDipinjam = "Select Count(*) From detail_pnjm WHERE id_pinjam IN (SELECT id_pinjam FROM pinjam WHERE id_status != 3)";
                using (var cmd = new NpgsqlCommand(queryAlatDipinjam, conn))
                {
                    var result = cmd.ExecuteScalar();
                    txtAlatDipinjam.Text = result.ToString();
                }

                string queryRiwayat30Hari = "Select Count(*) From pinjam Where tanggal_kembali >= CURRENT_DATE - INTERVAL '30 days' AND id_status = 3";
                using (var cmd = new NpgsqlCommand(queryRiwayat30Hari, conn))
                {
                    var result = cmd.ExecuteScalar();
                    txtPengembalian30.Text = result.ToString();
                }

                string queryRiwayat7Hari = "Select Count(*) From pinjam Where tanggal_kembali >= CURRENT_DATE - INTERVAL '7 days' AND id_status = 3";
                using (var cmd = new NpgsqlCommand(queryRiwayat7Hari, conn))
                {
                    var result = cmd.ExecuteScalar();
                    txtPengembalian7.Text = result.ToString();
                }

                string queryPeminjaman30Hari = "Select Count(*) From pinjam Where tanggal_pinjam >= CURRENT_DATE - INTERVAL '30 days'";
                using (var cmd = new NpgsqlCommand(queryPeminjaman30Hari, conn))
                {
                    var result = cmd.ExecuteScalar();
                    txtPeminjaman30.Text = result.ToString();
                }

                string queryPeminjaman7Hari = "Select Count(*) From pinjam Where tanggal_pinjam >= CURRENT_DATE - INTERVAL '7 days'";
                using (var cmd = new NpgsqlCommand(queryPeminjaman7Hari, conn))
                {
                    var result = cmd.ExecuteScalar();
                    txtPeminjaman7.Text = result.ToString(); 
                }
            }
        }

    }
}
