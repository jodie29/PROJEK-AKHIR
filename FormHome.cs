using System;
using System.Windows.Forms;
using Npgsql;


namespace PROJEK_AKHIR
{
    public partial class FormHome : Form
    {
        private string _loggedInAdminId;

        public FormHome(string adminId)
        {
            InitializeComponent();
            _loggedInAdminId = adminId;
        }

        public FormHome()
        {
            InitializeComponent();
            _loggedInAdminId = string.Empty;
        }

        
        private void FormHome_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_loggedInAdminId))
                return;

            string connStr = "Host=localhost;Username=postgres;Password=Rfqh0_;Database=CANKULLIN";
            string query = "SELECT nama_admin FROM admin WHERE id_admin = @id_admin";

            using (NpgsqlConnection conn = new NpgsqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id_admin", _loggedInAdminId);
                        using (NpgsqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string namaAdmin = reader["nama_admin"].ToString();
                                label1.Text = namaAdmin ;
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAdmin formAdmin = new FormAdmin();
            formAdmin.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormKelomppokTani formKelomppokTani = new FormKelomppokTani();
            formKelomppokTani.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormInformasiAlat formInformasiAlat = new FormInformasiAlat();
            formInformasiAlat.Show();
        }
    }
}