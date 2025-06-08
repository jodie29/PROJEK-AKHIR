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
    public partial class FormTambahAlat: Form
    {
        public FormTambahAlat()
        {
            InitializeComponent();
        }

        private void btnPilihGambar_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"; 
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBoxAlat.ImageLocation = openFileDialog.FileName;
            }
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            string namaAlat = txtNamaAlat.Text;
            string jumlahText = txtJumlahAlat.Text;
            string imagePath = pictureBoxAlat.ImageLocation;

            if (string.IsNullOrEmpty(namaAlat) || string.IsNullOrEmpty(jumlahText) || string.IsNullOrEmpty(imagePath))
            {
                MessageBox.Show("Semua data harus diisi dengan benar!");
                return;
            }

            if (!int.TryParse(jumlahText, out int jumlah))
            {
                MessageBox.Show("Jumlah alat harus berupa angka!");
                return;
            }

            if (AlatSudahAda(namaAlat))
            {
                MessageBox.Show("Alat dengan nama tersebut sudah ada di database!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            FormInformasiAlat formInformasiAlat = (FormInformasiAlat)Application.OpenForms["FormInformasiAlat"];
            if (formInformasiAlat == null)
            {
                MessageBox.Show("FormInformasiAlat tidak terbuka.");
                return;
            }
            formInformasiAlat.TambahAlat(namaAlat, jumlah, imagePath);

            SimpanKeDatabase(namaAlat, jumlah, imagePath);

            this.Close();
        }

        private bool AlatSudahAda(string namaAlat)
        {
            string connectionString = "Host=localhost;Username=postgres;Password=jodiefer;Database=CANKULLIN";

            using (var conn = new Npgsql.NpgsqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM alat WHERE nama_alat = @namaAlat";
                using (var cmd = new Npgsql.NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("namaAlat", namaAlat);
                    var result = cmd.ExecuteScalar();
                    return Convert.ToInt32(result) > 0; 
                }
            }
        }

        private void SimpanKeDatabase(string namaAlat, int jumlah, string imagePath)
        {
            string connectionString = "Host=localhost;Username=postgres;Password=jodiefer;Database=CANKULLIN";

            using (var conn = new Npgsql.NpgsqlConnection(connectionString))
            {
                conn.Open();

                string query = "INSERT INTO alat (nama_alat, jumlah, gambar_alat) VALUES (@nama, @jumlah, @gambar)";
                using (var cmd = new Npgsql.NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("nama", namaAlat);
                    cmd.Parameters.AddWithValue("jumlah", jumlah);
                    cmd.Parameters.AddWithValue("gambar", imagePath); 

                    cmd.ExecuteNonQuery(); 
                }
            }
        }

        private void FormTambahAlat_Load(object sender, EventArgs e)
        {
            txtNamaAlat.Text = "";
            txtJumlahAlat.Text = "";
            pictureBoxAlat.Image = null;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
