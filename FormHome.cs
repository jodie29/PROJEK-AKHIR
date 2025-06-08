using System;
using System.Windows.Forms;
using Npgsql;
using PROJEK_AKHIR;
using PROJEK_AKHIR.PROJEK_AKHIR;

namespace PROJEK_AKHIR
{
    public partial class FormHome : Form
    {
        public FormHome()
        {
            InitializeComponent();
        }

        private void FormHome_Load(object sender, EventArgs e)
        {
            string loggedInAdminId = UserSession.IdAdminLogin;

            if (string.IsNullOrEmpty(loggedInAdminId))
            {
                MessageBox.Show("Tidak ada admin yang login", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string connStr = "Host=localhost;Username=postgres;Password=jodiefer;Database=CANKULLIN";
            string query = "SELECT nama_admin FROM admin WHERE id_admin = @id_admin";

            using (NpgsqlConnection conn = new NpgsqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id_admin", loggedInAdminId);
                        using (NpgsqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string namaAdmin = reader["nama_admin"].ToString();
                                label1.Text = $"Hello, welcome {namaAdmin}";
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal mengambil data admin: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e) { }

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

        private void btnLaporan_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLaporan formLaporan = new FormLaporan();
            formLaporan.Show();
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            FromLogin formLogin = new FromLogin();
            formLogin.Show();
        }
    }
}