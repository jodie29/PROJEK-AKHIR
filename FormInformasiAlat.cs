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
    public partial class FormInformasiAlat: Form
    {
        private BindingList<Alat> alatList = new BindingList<Alat>();

        public FormInformasiAlat()
        {
            InitializeComponent();
            flowLayoutPanelAlat.AutoScroll = true;
            LoadDataFromDatabase();
            UpdateFlowLayoutPanel();
        }

        private void LoadDataFromDatabase()
        {
            string connectionString = "Host=localhost;Username=postgres;Password=Rfqh0_;Database=CANKULLIN";
            using (var conn = new Npgsql.NpgsqlConnection(connectionString))
            {
                conn.Open();

                string query = "SELECT nama_alat, jumlah, gambar_alat FROM alat";
                using (var cmd = new Npgsql.NpgsqlCommand(query, conn))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string namaAlat = reader.GetString(0);
                            int jumlah = reader.GetInt32(1);
                            string imagePath = reader.GetString(2);

                            

                            Alat alatBaru = new Alat
                            {
                                Nama = namaAlat,
                                Jumlah = jumlah,
                                GambarPath = imagePath
                            };
                            alatList.Add(alatBaru);
                        }

                    }
                }
            }
            UpdateFlowLayoutPanel();
        }

        private void DeleteAlatFromDatabase(Alat alat)
        {
            string connectionString = "Host=localhost;Username=postgres;Password=Rfqh0_;Database=CANKULLIN";
            using (var conn = new Npgsql.NpgsqlConnection(connectionString))
            {
                conn.Open();

                string query = "DELETE FROM alat WHERE nama_alat = @namaAlat";
                using (var cmd = new Npgsql.NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("namaAlat", alat.Nama);
                    cmd.ExecuteNonQuery();
                }
            }
        }


        private void UpdateFlowLayoutPanel()
        {
            flowLayoutPanelAlat.Controls.Clear(); 
            foreach (var alat in alatList)
            {
                Panel panelAlat = new Panel();
                panelAlat.Width = 120;
                panelAlat.Height = 180;
                panelAlat.BorderStyle = BorderStyle.FixedSingle;
                panelAlat.BackColor = Color.White;

                TableLayoutPanel layout = new TableLayoutPanel();
                layout.RowCount = 5;
                layout.ColumnCount = 1;
                layout.Dock = DockStyle.Fill;
                layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 80));
                layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20));
                layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20));
                layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 30));
                layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 30));

                PictureBox pictureBox = new PictureBox();
                pictureBox.Image = Image.FromFile(alat.GambarPath);
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox.Dock = DockStyle.Fill;
                layout.Controls.Add(pictureBox, 0, 0);

                Label labelNama = new Label();
                labelNama.Text = alat.Nama;
                labelNama.TextAlign = ContentAlignment.MiddleCenter;
                labelNama.Dock = DockStyle.Fill;
                layout.Controls.Add(labelNama, 0, 1);

                Label labelJumlah = new Label();
                labelJumlah.Text = "Jumlah: " + alat.Jumlah.ToString();
                labelJumlah.TextAlign = ContentAlignment.MiddleCenter;
                labelJumlah.Dock = DockStyle.Fill;
                layout.Controls.Add(labelJumlah, 0, 2);

                Button btnEdit = new Button();
                btnEdit.Text = "Edit";
                btnEdit.Dock = DockStyle.Fill;
                btnEdit.Click += (s, e) =>
                {
                    FormEditAlat formEditAlat = new FormEditAlat(alat);
                    formEditAlat.ShowDialog();

                    UpdateFlowLayoutPanel();
                };
                layout.Controls.Add(btnEdit, 0, 3);

                Button btnDelete = new Button();
                btnDelete.Text = "Delete";
                btnDelete.Dock = DockStyle.Fill;
                btnDelete.Click += (s, e) =>
                {
                    alatList.Remove(alat);

                    DeleteAlatFromDatabase(alat);

                    UpdateFlowLayoutPanel();
                };
                layout.Controls.Add(btnDelete, 0, 4);

                panelAlat.Controls.Add(layout);

                flowLayoutPanelAlat.Controls.Add(panelAlat);
            }
        }
        public void TambahAlat(string namaAlat, int jumlah, string imagePath)
        {
            Alat alatBaru = new Alat
            {
                Nama = namaAlat,
                Jumlah = jumlah,
                GambarPath = imagePath
            };

            alatList.Add(alatBaru);

            UpdateFlowLayoutPanel();
        }


        private void btnTambah_Click_1(object sender, EventArgs e)
        {
            FormTambahAlat formTambahAlat = new FormTambahAlat();
            formTambahAlat.ShowDialog();
            UpdateFlowLayoutPanel();
        }

        private void FormInformasiAlat_Load(object sender, EventArgs e)
        {
            LoadDataFromDatabase();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormHome formHome = new FormHome();
            formHome.Show();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAdmin formAdmin = new FormAdmin();
            formAdmin.Show();
        }

        private void btnKelompokTani_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormKelomppokTani formKelomppokTani = new FormKelomppokTani();
            formKelomppokTani.Show();
        }

        private void btnPeminjaman_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormPeminjaman formPeminjaman = new FormPeminjaman();
            formPeminjaman.Show();
        }
    }

    public class Alat
    {
        public string Nama { get; set; }
        public int Jumlah { get; set; }
        public string GambarPath { get; set; }
    }
}
