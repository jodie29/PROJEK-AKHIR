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
    public partial class FormRegister : Form
    {
        public FormRegister()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbnama == null || tbemail == null || tbnohp == null || tbusername == null || tbpw == null)
                {
                    MessageBox.Show("Terjadi masalah dengan kontrol input. Mohon coba lagi.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string nama = tbnama.Text.Trim();
                string email = tbemail.Text.Trim();
                string nohp = tbnohp.Text.Trim();
                string username = tbusername.Text.Trim();
                string password = tbpw.Text;

                if (string.IsNullOrEmpty(nohp) || !Regex.IsMatch(nohp, @"^\d+$"))
                {
                    MessageBox.Show("Nomor HP harus berupa angka yang valid!", "Kesalahan Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (string.IsNullOrEmpty(password) || password.Length <= 7 || !Regex.IsMatch(password, @"^\d+$"))
                {
                    MessageBox.Show("Kata sandi harus lebih dari 8 angka).", "Kesalahan Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string newAdminId = GenerateNewAdminId();
                if (string.IsNullOrEmpty(newAdminId))
                {
                    MessageBox.Show("Gagal membuat ID admin baru.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                bool isRegistered = Register(newAdminId, nama, email, nohp, username, password);

                if (isRegistered)
                {
                    MessageBox.Show("Registrasi Berhasil!", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    FromLogin formLogin = new FromLogin();
                    formLogin.Show();
                }
                else
                {
                    MessageBox.Show("Registrasi Gagal. Silahkan coba lagi!", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan tak terduga: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string GetLastAdminId()
        {
            string connStr = "Host=localhost;Username=postgres;Password=jodiefer;Database=CANKULLIN";
            string lastId = null;

            string query = "SELECT id_admin FROM admin WHERE id_admin LIKE 'adm%' ORDER BY CAST(SUBSTRING(id_admin FROM 4) AS INT) DESC LIMIT 1";

            try
            {
                using (NpgsqlConnection conn = new NpgsqlConnection(connStr))
                {
                    conn.Open();
                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                    {
                        using (NpgsqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                lastId = reader.GetString(0);
                            }
                        }
                    }
                }
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show("Error saat mengambil ID admin terakhir: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error sistem saat mengambil ID admin terakhir: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return lastId;
        }

        private string GenerateNewAdminId()
        {
            string lastId = GetLastAdminId();
            int newNumber = 1;

            if (!string.IsNullOrEmpty(lastId))
            {
                Match match = Regex.Match(lastId, @"^adm(\d+)$");
                if (match.Success)
                {
                    if (int.TryParse(match.Groups[1].Value, out int existingNumber))
                    {
                        newNumber = existingNumber + 1;
                    }
                }
            }
            return "adm" + newNumber.ToString();
        }

        private bool Register(string idAdmin, string nama, string email, string nohp, string username, string password)
        {
            string connStr = "Host=localhost;Username=postgres;Password=jodiefer;Database=CANKULLIN";

            string query = "INSERT INTO admin (id_admin, nama_admin, email, no_hp_admin, username, password) VALUES (@id_admin, @nama_admin, @email, @no_hp_admin, @username, @password)";

            try
            {
                using (NpgsqlConnection conn = new NpgsqlConnection(connStr))
                {
                    conn.Open();

                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id_admin", idAdmin);
                        cmd.Parameters.AddWithValue("@nama_admin", nama);
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@no_hp_admin", nohp);
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        return rowsAffected > 0;
                    }
                }
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show("Registrasi Gagal (Database Error): " + ex.Message, "Error Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Registrasi Gagal (Sistem Error): " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void FormRegister_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FromLogin formLogin = new FromLogin();
            formLogin.Show();
        }

        private void tbpw_TextChanged(object sender, EventArgs e)
        {

        }
    }
}