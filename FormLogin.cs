using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using System.Text.RegularExpressions; 

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
            string connStr = "Host=localhost;Username=postgres;Password=Rfqh0_;Database=CANKULLIN";
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
                                userId = reader.GetString(reader.GetOrdinal("id_admin"));
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void FromLogin_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbusername != null && tbpassword != null)
                {
                    string username = tbusername.Text;
                    string password = tbpassword.Text;
                    if (Validate(username, password, out string userId))
                    {
                        MessageBox.Show("Login berhasil. Klik OK untuk melanjutkan", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        FormHome formHome = new FormHome(userId);
                        this.Hide();
                        formHome.Show();
                    }
                    else
                    {
                        MessageBox.Show("U atau password salah", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Username & Password harus diisi!", "Perhatian!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            FormRegister formRegister = new FormRegister();
            formRegister.Show();
        }
    }
}
