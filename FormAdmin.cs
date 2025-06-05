using Npgsql;
using PROJEK_AKHIR.PROJEK_AKHIR;
using System;
using System.Data;
using System.Windows.Forms;

namespace PROJEK_AKHIR
{
    public partial class FormAdmin : Form
    {
        string connectionString = "Host=localhost;Username=postgres;Password=Rfqh0_;Database=CANKULLIN";

        public FormAdmin()
        {
            InitializeComponent();
        }
        void KondisiAwal()
        {
            LblTanggal.Text = DateTime.Now.ToString("dd-MM-yyyy");
        }
        private void TampilkanAdmin()
        {
            try
            {
                string query = "SELECT id_admin, nama_admin, email, no_hp_admin, username, password FROM admin";

                using (var conn = new NpgsqlConnection(connectionString))
                {
                    conn.Open();
                    NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(query, conn);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    dataGridView1.DataSource = dataTable;

                    dataGridView1.Columns["id_admin"].HeaderText = "Kode";
                    dataGridView1.Columns["nama_admin"].HeaderText = "Nama";
                    dataGridView1.Columns["email"].HeaderText = "Email";
                    dataGridView1.Columns["no_hp_admin"].HeaderText = "Nomor Hp";
                    dataGridView1.Columns["username"].HeaderText = "Username";
                    dataGridView1.Columns["password"].HeaderText = "Password";
                    dataGridView1.Columns[1].Width = 200;

                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan saat mengambil data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormAdmin_Load_1(object sender, EventArgs e)
        {
            KondisiAwal();
            TampilkanAdmin();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LblJam.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    var selectedRow = dataGridView1.SelectedRows[0];
                    var idAdminValue = selectedRow.Cells["id_admin"].Value.ToString();

                    if (!string.IsNullOrEmpty(idAdminValue))
                    {
                        if (idAdminValue == UserSession.IdAdminLogin)
                        {
                            MessageBox.Show("Anda tidak dapat menghapus admin yang sedang login.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        string deleteQuery = "DELETE FROM admin WHERE id_admin = @id_admin";

                        using (var conn = new NpgsqlConnection(connectionString))
                        {
                            conn.Open();
                            using (var cmd = new NpgsqlCommand(deleteQuery, conn))
                            {
                                cmd.Parameters.AddWithValue("@id_admin", idAdminValue);
                                cmd.ExecuteNonQuery();
                            }
                            conn.Close();
                        }

                        TampilkanAdmin();  
                        MessageBox.Show("Data berhasil dihapus", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("ID Admin tidak valid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Silakan pilih baris yang ingin dihapus.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan saat menghapus data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void KelompokTani_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormKelomppokTani formKelomppokTani = new FormKelomppokTani();
            formKelomppokTani.Show();
        }

        private void Home_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormHome formHome = new FormHome();
            formHome.Show();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormHome formHome = new FormHome();
            formHome.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
