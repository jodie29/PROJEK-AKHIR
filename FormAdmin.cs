using Npgsql;
using PROJEK_AKHIR.PROJEK_AKHIR;
using System;
using System.Data;
using System.Windows.Forms;

namespace PROJEK_AKHIR
{
    public partial class FormAdmin : Form
    {
        string connectionString = "Host=localhost;Username=postgres;Password=jodiefer;Database=CANKULLIN";

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
                string query = "SELECT id_admin, nama_admin, email, no_hp_admin FROM admin";

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

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormHome formHome = new FormHome();
            formHome.Show();
        }


        private void btnKelompoktani_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormKelompokTani formKelomppokTani = new FormKelompokTani();
            formKelomppokTani.Show();
        }

        private void btnInformasiAlat_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormInformasiAlat formInformasiAlat = new FormInformasiAlat();
            formInformasiAlat.Show();
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
            FormLaporan formLaporan = new FormLaporan ();
            formLaporan.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormHome formHome = new FormHome();
            formHome.Show();
        }
    }
}
