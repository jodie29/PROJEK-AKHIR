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
using System.IO;

namespace PROJEK_AKHIR
{
    public partial class FormEditAlat : Form
    {
        private Alat alat;
        private string originalGambarPath;
        private string originalNamaAlatForUpdate;

        public FormEditAlat(Alat alat)
        {
            InitializeComponent();
            this.alat = alat;

            txtNamaAlat.Text = alat.Nama;
            txtJumlahAlat.Text = alat.Jumlah.ToString();
            pictureBoxAlat.ImageLocation = alat.GambarPath;

            originalGambarPath = alat.GambarPath;
            originalNamaAlatForUpdate = alat.Nama;

            this.btnSimpan.Click += new EventHandler(this.btnSimpan_Click);
            this.btnPilihGambar.Click += new EventHandler(this.btnPilihGambar_Click_1);
            this.btnClose.Click += new EventHandler(this.btnClose_Click);
        }

        private void UpdateAlatInDatabase(Alat alatToUpdate)
        {
            string connectionString = "Host=localhost;Username=postgres;Password=jodiefer;Database=CANKULLIN";
            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                string query = "UPDATE alat SET nama_alat = @nama, jumlah = @jumlah, gambar_alat = @gambar WHERE nama_alat = @originalNamaAlat";
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("nama", alatToUpdate.Nama);
                    cmd.Parameters.AddWithValue("jumlah", alatToUpdate.Jumlah);
                    cmd.Parameters.AddWithValue("gambar", alatToUpdate.GambarPath);
                    cmd.Parameters.AddWithValue("originalNamaAlat", originalNamaAlatForUpdate);

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

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNamaAlat.Text))
            {
                MessageBox.Show("Nama alat tidak boleh kosong.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtJumlahAlat.Text))
            {
                MessageBox.Show("Jumlah alat tidak boleh kosong.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int newJumlah;
            if (!int.TryParse(txtJumlahAlat.Text, out newJumlah) || newJumlah <= 0)
            {
                MessageBox.Show("Jumlah alat harus berupa angka bulat positif.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool hasChanges =
                txtNamaAlat.Text != originalNamaAlatForUpdate ||
                newJumlah != this.alat.Jumlah ||
                (pictureBoxAlat.ImageLocation ?? "") != (originalGambarPath ?? "");

            if (!hasChanges)
            {
                MessageBox.Show("Tidak ada perubahan terdeteksi pada data alat.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.Cancel;
                this.Close();
                return;
            }

            if (txtNamaAlat.Text != originalNamaAlatForUpdate)
            {
                string connectionString = "Host=localhost;Username=postgres;Password=jodiefer;Database=CANKULLIN";
                using (var conn = new NpgsqlConnection(connectionString))
                {
                    conn.Open();
                    string checkDuplicateQuery = "SELECT COUNT(*) FROM alat WHERE nama_alat = @namaAlatBaru AND is_active = TRUE";
                    using (var checkCmd = new NpgsqlCommand(checkDuplicateQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("namaAlatBaru", txtNamaAlat.Text);
                        int count = Convert.ToInt32(checkCmd.ExecuteScalar());
                        if (count > 0)
                        {
                            MessageBox.Show("Nama alat ini sudah ada dan aktif. Mohon gunakan nama lain.", "Duplikasi Nama Alat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }
                }
            }

            this.alat.Nama = txtNamaAlat.Text;
            this.alat.Jumlah = newJumlah;

            if (!string.IsNullOrEmpty(pictureBoxAlat.ImageLocation))
            {
                this.alat.GambarPath = pictureBoxAlat.ImageLocation;
            }
            else
            {
                this.alat.GambarPath = "";
            }

            try
            {
                UpdateAlatInDatabase(this.alat);
                MessageBox.Show("Data alat berhasil diperbarui!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan saat memperbarui data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}