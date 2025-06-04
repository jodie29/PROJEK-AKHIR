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
    public partial class FormEditAlat: Form
    {
        private Alat alat;

        public FormEditAlat(Alat alat)
        {
            InitializeComponent();
            this.alat = alat;

            txtNamaAlat.Text = alat.Nama;
            txtJumlahAlat.Text = alat.Jumlah.ToString();
            pictureBoxAlat.ImageLocation = alat.GambarPath;
        }           

        private void UpdateAlatInDatabase(Alat alat)
        {
            string connectionString = "Host=localhost;Username=postgres;Password=Rfqh0_;Database=CANKULLIN";
            using (var conn = new Npgsql.NpgsqlConnection(connectionString))
            {
                conn.Open();
                string query = "UPDATE alat SET nama_alat = @nama, jumlah = @jumlah, gambar_alat = @gambar WHERE nama_alat = @namaAlat";
                using (var cmd = new Npgsql.NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("nama", alat.Nama);
                    cmd.Parameters.AddWithValue("jumlah", alat.Jumlah);
                    cmd.Parameters.AddWithValue("gambar", alat.GambarPath);
                    cmd.Parameters.AddWithValue("namaAlat", alat.Nama);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void btnPilihGambar_Click_1(object sender, EventArgs e)
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
            alat.Nama = txtNamaAlat.Text;
            alat.Jumlah = int.Parse(txtJumlahAlat.Text);
            alat.GambarPath = pictureBoxAlat.ImageLocation;

            UpdateAlatInDatabase(alat);

            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtNamaAlat.Text = "";
            txtJumlahAlat.Text = "";
            pictureBoxAlat.Image = null;
        }
    }
}
