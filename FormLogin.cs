using System;
using System.Windows.Forms;
using Npgsql;
using PROJEK_AKHIR;
using PROJEK_AKHIR.PROJEK_AKHIR;

namespace PROJEK_AKHIR
{
    public partial class FromLogin : Form
    {
        public FromLogin()
        {
            InitializeComponent();
            tbpassword.UseSystemPasswordChar = true;
        }

        public bool Validate(string username, string password, out string userId)
        {
            userId = null;
            string connStr = "Host=localhost;Username=postgres;Password=jodiefer;Database=CANKULLIN";
            string query = "SELECT id_admin FROM admin WHERE username = @username AND password = @password";
            using (NpgsqlConnection conn = new NpgsqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password);
                        using (NpgsqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                userId = reader.GetString(reader.GetOrdinal("id_admin")).Trim(); 
                                return true;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Terjadi kesalahan saat memvalidasi login: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(tbusername.Text) || string.IsNullOrEmpty(tbpassword.Text))
                {
                    MessageBox.Show("Username & Password harus diisi!", "Perhatian!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string username = tbusername.Text;
                string password = tbpassword.Text;

                if (Validate(username, password, out string userId))
                {
                    UserSession.IdAdminLogin = userId; 

                    MessageBox.Show("Login berhasil. Klik OK untuk melanjutkan", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    FormHome formHome = new FormHome(); 
                    this.Hide();
                    formHome.Show();
                }
                else
                {
                    MessageBox.Show("Username atau password salah", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show("Terjadi kesalahan saat menghubungi database: " + ex.Message, "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan tak terduga: " + ex.Message, "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            FormRegister formRegister = new FormRegister();
            formRegister.Show();
        }
    }
}
