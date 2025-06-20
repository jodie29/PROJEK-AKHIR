using Npgsql;
using PROJEK_AKHIR.PROJEK_AKHIR;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace PROJEK_AKHIR
{
    public partial class FormPeminjamanKT : Form
    {
        string connectionString = "Host=localhost;Username=postgres;Password=jodiefer;Database=CANKULLIN";
        private BindingList<Alat> alatList = new BindingList<Alat>();

        public FormPeminjamanKT()
        {
            InitializeComponent();
            flowLayoutPanelAlat.AutoScroll = true;

            this.Load += new EventHandler(FormPeminjamanKT_Load);
        }

        private void FormPeminjamanKT_Load(object sender, EventArgs e)
        {
            dtGKlompokTani.CellClick += dtGKlompokTani_CellClick;

            LoadDataFromDatabase();

            TampilkanKelompokTani();
        }
        private void TampilkanKelompokTani()
        {
            try
            {
                string query = "SELECT k.id_kelompoktani, k.nama_kelompoktani, k.nik, k.jumlah_kelompoktani, k.no_hp_kelompoktani, k.deskripsi_jalan, a.desa || ',' || a.kecamatan || ',' || a.kabupaten AS alamat " +
                               "FROM kelompok_tani k " +
                               "JOIN alamat a ON k.id_alamat = a.id_alamat " +
                               "WHERE k.is_active = TRUE " +
                               "ORDER BY k.id_kelompoktani ASC";

                using (var conn = new NpgsqlConnection(connectionString))
                {
                    conn.Open();
                    NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(query, conn);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    dtGKlompokTani.DataSource = dataTable;

                    dtGKlompokTani.Columns["id_kelompoktani"].HeaderText = "Kode";
                    dtGKlompokTani.Columns["nama_kelompoktani"].HeaderText = "Nama Kelompok Tani";
                    dtGKlompokTani.Columns["nik"].HeaderText = "NIK";
                    dtGKlompokTani.Columns["jumlah_kelompoktani"].HeaderText = "Jumlah Anggota";
                    dtGKlompokTani.Columns["no_hp_kelompoktani"].HeaderText = "Nomor HP";
                    dtGKlompokTani.Columns["deskripsi_jalan"].HeaderText = "Deskripsi Jalan";
                    dtGKlompokTani.Columns["alamat"].HeaderText = "Alamat";

                    dtGKlompokTani.Columns["id_kelompoktani"].Width = 100;
                    dtGKlompokTani.Columns["nama_kelompoktani"].Width = 200;
                    dtGKlompokTani.Columns["nik"].Width = 130;
                    dtGKlompokTani.Columns["jumlah_kelompoktani"].Width = 120;
                    dtGKlompokTani.Columns["no_hp_kelompoktani"].Width = 130;
                    dtGKlompokTani.Columns["deskripsi_jalan"].Width = 130;
                    dtGKlompokTani.Columns["alamat"].Width = 250;

                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan saat mengambil data kelompok tani: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadDataFromDatabase()
        {
            if (alatList.Count > 0)
            {
                return;
            }

            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();

                string query = "SELECT nama_alat, jumlah, gambar_alat FROM alat WHERE is_active = TRUE";
                using (var cmd = new NpgsqlCommand(query, conn))
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

        private void UpdateFlowLayoutPanel()
        {
            flowLayoutPanelAlat.Controls.Clear();

            foreach (var alat in alatList)
            {
                Panel panelAlat = new Panel
                {
                    Width = 120,
                    Height = 180,
                    BorderStyle = BorderStyle.FixedSingle,
                    BackColor = Color.White
                };

                TableLayoutPanel layout = new TableLayoutPanel
                {
                    RowCount = 5,
                    ColumnCount = 1,
                    Dock = DockStyle.Fill
                };

                layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 80));
                layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20));
                layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20));
                layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 30));
                layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 30));

                PictureBox pictureBox = new PictureBox();
                if (File.Exists(alat.GambarPath))
                {
                    pictureBox.Image = Image.FromFile(alat.GambarPath);
                }
                else
                {
                    pictureBox.BackColor = Color.Gray;
                    pictureBox.Image = null;
                }
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox.Dock = DockStyle.Fill;
                layout.Controls.Add(pictureBox, 0, 0);

                Label labelNama = new Label
                {
                    Text = alat.Nama,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Dock = DockStyle.Fill
                };
                layout.Controls.Add(labelNama, 0, 1);

                Label labelJumlah = new Label
                {
                    Text = "Jumlah: " + alat.Jumlah.ToString(),
                    TextAlign = ContentAlignment.MiddleCenter,
                    Dock = DockStyle.Fill
                };
                layout.Controls.Add(labelJumlah, 0, 2);

                Button btnTambah = new Button
                {
                    Text = "Tambah",
                    Dock = DockStyle.Fill
                };
                btnTambah.Click += (s, e) =>
                {
                    txtNamaAlat.Text = alat.Nama;
                    txtJumlahAlat.Focus();
                    txtTanggalPinjam.Text = DateTime.Now.ToString("yyyy-MM-dd");
                };

                layout.Controls.Add(btnTambah, 0, 3);

                panelAlat.Controls.Add(layout);
                flowLayoutPanelAlat.Controls.Add(panelAlat);
            }
        }

        private void dtGKlompokTani_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string namaKelompokTani = dtGKlompokTani.Rows[e.RowIndex].Cells["nama_kelompoktani"].Value.ToString();
                txtKelompokTani.Text = namaKelompokTani;
            }
        }

        private void AddPeminjamanToDatabase(string namaKelompokTani, string namaAlat, int jumlah, string tanggalPinjam, string tenggatPinjam, string idAdmin)
        {
            DateTime tanggalPinjamDate;
            if (!DateTime.TryParse(tanggalPinjam, out tanggalPinjamDate))
            {
                MessageBox.Show("Format tanggal pinjam tidak valid.");
                return;
            }

            DateTime tenggatPinjamDate;
            if (!DateTime.TryParse(tenggatPinjam, out tenggatPinjamDate))
            {
                MessageBox.Show("Format tenggat pinjam tidak valid.");
                return;
            }

            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                string queryPinjam = @"
            INSERT INTO pinjam (id_kelompoktani, tanggal_pinjam, tenggat_pinjam, id_status, id_admin)
            VALUES (
                (SELECT id_kelompoktani
                 FROM kelompok_tani
                 WHERE nama_kelompoktani = @namaKelompokTani
                 LIMIT 1),
                @tanggalPinjam,
                @tenggatPinjam,
                (SELECT id_status FROM status WHERE deskripsi = 'Dipinjam'),
                @idAdmin)
            RETURNING id_pinjam";

                using (var cmdPinjam = new NpgsqlCommand(queryPinjam, conn))
                {
                    cmdPinjam.Parameters.AddWithValue("namaKelompokTani", namaKelompokTani);
                    cmdPinjam.Parameters.AddWithValue("tanggalPinjam", tanggalPinjamDate);
                    cmdPinjam.Parameters.AddWithValue("tenggatPinjam", tenggatPinjamDate);
                    cmdPinjam.Parameters.AddWithValue("idAdmin", idAdmin);

                    int idPinjam = (int)cmdPinjam.ExecuteScalar();

                    string queryDetailPinjam = "INSERT INTO detail_pnjm (id_pinjam, id_alat, jumlah) " +
                                               "VALUES (@idPinjam, (SELECT id_alat FROM alat WHERE nama_alat = @namaAlat), @jumlah)";

                    using (var cmdDetailPinjam = new NpgsqlCommand(queryDetailPinjam, conn))
                    {
                        cmdDetailPinjam.Parameters.AddWithValue("idPinjam", idPinjam);
                        cmdDetailPinjam.Parameters.AddWithValue("namaAlat", namaAlat);
                        cmdDetailPinjam.Parameters.AddWithValue("jumlah", jumlah);

                        cmdDetailPinjam.ExecuteNonQuery();
                    }

                    string queryUpdateAlat = "UPDATE alat SET jumlah = jumlah - @jumlah WHERE nama_alat = @namaAlat";
                    using (var cmdUpdateAlat = new NpgsqlCommand(queryUpdateAlat, conn))
                    {
                        cmdUpdateAlat.Parameters.AddWithValue("jumlah", jumlah);
                        cmdUpdateAlat.Parameters.AddWithValue("namaAlat", namaAlat);

                        cmdUpdateAlat.ExecuteNonQuery();
                    }

                    var alatYangDipinjam = alatList.FirstOrDefault(a => a.Nama == namaAlat);
                    if (alatYangDipinjam != null)
                    {
                        alatYangDipinjam.Jumlah -= jumlah;
                    }
                }
            }

            UpdateFlowLayoutPanel();
            MessageBox.Show("Peminjaman berhasil ditambahkan dan jumlah alat telah diperbarui!");
        }



        public class Alat
        {
            public string Nama { get; set; }
            public int Jumlah { get; set; }
            public string GambarPath { get; set; }
        }

        private void btnTambahPinjam_Click(object sender, EventArgs e)
        {
            string namaAlat = txtNamaAlat.Text;
            int jumlah = 0;

            if (!int.TryParse(txtJumlahAlat.Text, out jumlah) || jumlah <= 0)
            {
                MessageBox.Show("Jumlah alat harus berupa angka positif.");
                return;
            }

            var selectedAlat = alatList.FirstOrDefault(a => a.Nama == namaAlat);
            if (selectedAlat != null && jumlah > selectedAlat.Jumlah)
            {
                MessageBox.Show($"Jumlah pinjam ({jumlah}) melebihi jumlah alat yang tersedia ({selectedAlat.Jumlah}).", "Kesalahan Jumlah Pinjam", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string tanggalPinjam = txtTanggalPinjam.Text;
            string tenggatPinjam = txtTenggatPinjam.Text;
            string namaKelompokTani = txtKelompokTani.Text;

            if (string.IsNullOrEmpty(namaKelompokTani) || string.IsNullOrEmpty(namaAlat) || string.IsNullOrEmpty(tanggalPinjam) || string.IsNullOrEmpty(tenggatPinjam))
            {
                MessageBox.Show("Semua kolom harus diisi!");
                return;
            }

            DateTime tanggalPinjamDate;
            if (!DateTime.TryParse(tanggalPinjam, out tanggalPinjamDate))
            {
                MessageBox.Show("Format tanggal pinjam tidak valid. Gunakan format YYYY-MM-DD.");
                return;
            }

            DateTime tenggatPinjamDate;
            if (!DateTime.TryParse(tenggatPinjam, out tenggatPinjamDate))
            {
                MessageBox.Show("Format tenggat pinjam tidak valid. Gunakan format YYYY-MM-DD.");
                return;
            }

            if (tenggatPinjamDate < tanggalPinjamDate)
            {
                MessageBox.Show("Tenggat pinjam tidak boleh kurang dari tanggal pinjam.", "Kesalahan Input Tanggal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string loggedInAdminId = UserSession.IdAdminLogin.Trim();
            if (string.IsNullOrEmpty(loggedInAdminId))
            {
                MessageBox.Show("ID Admin tidak valid.");
                return;
            }

            AddPeminjamanToDatabase(namaKelompokTani, namaAlat, jumlah, tanggalPinjam, tenggatPinjam, loggedInAdminId);

            txtKelompokTani.Clear();
            txtNamaAlat.Clear();
            txtJumlahAlat.Clear();
            txtTanggalPinjam.Clear();
            txtTenggatPinjam.Clear();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormHome formHome = new FormHome();
            formHome.Show();
        }

        private void btnInformasiAlat_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormInformasiAlat formInformasiAlat = new FormInformasiAlat();
            formInformasiAlat.Show();
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
            FormLaporan formLaporan = new FormLaporan();
            formLaporan.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormHome formHome = new FormHome();
            formHome.Show();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAdmin formAdminn = new FormAdmin();
            formAdminn.Show();
        }

        private void btnKelompokTani_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            FormKelompokTani formKelomppokTani = new FormKelompokTani();
            formKelomppokTani.Show();
        }
    }
}