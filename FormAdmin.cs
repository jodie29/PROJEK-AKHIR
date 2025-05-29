using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJEK_AKHIR
{

    public partial class FormAdmin : Form
    {
        public FormAdmin()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private static NpgsqlConnection GetConnection()
        {
            string connStr = "Host=localhost;Username=postgres;Password=Rfqh0_;Database=CANKULLIN"; // Pastikan koneksi string ini 100% akurat.
            return new NpgsqlConnection(connStr);
        }

        private void LoadData()
        {
            try
            {
                string query = "SELECT id_admin, nama_admin, email, no_hp_admin, username, password FROM admin"; // Pastikan nama kolom dan tabel cocok dengan database.

                using (var conn = GetConnection())
                {
                    conn.Open();
                    NpgsqlCommand cmd = new NpgsqlCommand(query, conn);
                    NpgsqlDataReader reader = cmd.ExecuteReader();

                    DataTable dataTable = new DataTable();
                    dataTable.Load(reader); // Letakkan breakpoint di sini untuk memeriksa dataTable.Rows.Count.

                    dataGridView1.DataSource = dataTable;
                    if (dataGridView1.Columns.Contains("id_admin"))
                        dataGridView1.Columns["id_admin"].Visible = false;

                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saat memuat data dari database: " + ex.Message, "Kesalahan Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddDeleteButtonColumn()
        {
            if (!dataGridView1.Columns.Contains("Actions"))
            {
                DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
                buttonColumn.HeaderText = "Actions";
                buttonColumn.Name = "Actions";
                buttonColumn.Text = "Delete";
                buttonColumn.UseColumnTextForButtonValue = true;
                dataGridView1.Columns.Add(buttonColumn);
            }
        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {
            AddDeleteButtonColumn();
            LoadData();
        }

        private void DeleteAdmin(object id)
        {
            string query = "DELETE FROM admin WHERE id_admin = @id";

            try
            {
                using (var conn = GetConnection())
                {
                    conn.Open();
                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Admin berhasil dihapus.");
                        }
                        else
                        {
                            MessageBox.Show("Gagal menghapus admin. Mungkin ID tidak ditemukan di database.");
                        }
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saat menghapus admin: " + ex.Message, "Kesalahan Penghapusan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 &&
                dataGridView1.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                dataGridView1.Columns[e.ColumnIndex].Name == "Actions")
            {
                var id = dataGridView1.Rows[e.RowIndex].Cells["id_admin"].Value; // Pastikan kolom "id_admin" ada dan benar di DataGridView.

                if (id != null)
                {
                    DeleteAdmin(id);
                    LoadData();
                }
            }
        }
    }
}