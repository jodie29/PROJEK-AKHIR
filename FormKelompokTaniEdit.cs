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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PROJEK_AKHIR
{
    public partial class FormKelompokTaniEdit : Form
    {
        string connectionString = "Host=localhost;Username=postgres;Password=jodiefer;Database=CANKULLIN";

        private string originalNama = "";
        private string originalNik = "";
        private string originalJumlah = "";
        private string originalNoHp = "";
        private string originalDeskripsiJalan = "";
        private string originalDesa = "";
        private string originalKecamatan = "";
        private string originalKabupaten = "";
        private string originalIdKelompokTani = "";


        public FormKelompokTaniEdit()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        void munculLevel1()
        {
            comboBox1.Items.Clear();
            comboBox1.Items.Add("Jember");
            comboBox1.Items.Add("Banyuwangi");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
            {
                comboBox2.Enabled = false;
                comboBox3.Enabled = false;
                comboBox2.Items.Clear();
                comboBox3.Items.Clear();
                return;
            }

            string kabupaten = comboBox1.SelectedItem.ToString();
            LoadKecamatan(kabupaten);

            comboBox2.Enabled = true;
            comboBox3.Enabled = false;
            comboBox2.Text = "";
            comboBox3.Text = "";
        }

        private void LoadKecamatan(string kabupaten)
        {
            comboBox2.Items.Clear();
            comboBox3.Items.Clear();

            string queryKecamatan = "SELECT DISTINCT kecamatan FROM alamat WHERE kabupaten = @kabupaten";

            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand(queryKecamatan, conn))
                {
                    cmd.Parameters.AddWithValue("@kabupaten", kabupaten);
                    var reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        comboBox2.Items.Add(reader.GetString(0));
                    }
                }
            }
        }

        private void LoadDesa(string kabupaten, string kecamatan)
        {
            comboBox3.Items.Clear();

            string queryDesa = "SELECT desa FROM alamat WHERE kabupaten = @kabupaten AND kecamatan = @kecamatan";

            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand(queryDesa, conn))
                {
                    cmd.Parameters.AddWithValue("@kabupaten", kabupaten);
                    cmd.Parameters.AddWithValue("@kecamatan", kecamatan);
                    var reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        comboBox3.Items.Add(reader.GetString(0));
                    }
                }
            }
        }

        void KondisiAwal()
        {
            LblTanggal.Text = DateTime.Now.ToString("dd-MM-yyyy");
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            comboBox1.Text = "";
            comboBox2.Text = "";
            comboBox3.Text = "";
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            comboBox3.SelectedIndex = -1;

            comboBox2.Enabled = false;
            comboBox3.Enabled = false;
            munculLevel1();

            dataGridView1.ClearSelection();

            originalNama = "";
            originalNik = "";
            originalJumlah = "";
            originalNoHp = "";
            originalDeskripsiJalan = "";
            originalDesa = "";
            originalKecamatan = "";
            originalKabupaten = "";
            originalIdKelompokTani = "";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LblJam.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        private void FormKelompokTaniEdit_Load(object sender, EventArgs e)
        {
            KondisiAwal();
            TampilkanKelompokTani();

            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;

            munculLevel1();
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null && dataGridView1.CurrentRow.Cells["id_kelompoktani"].Value != null)
            {
                originalIdKelompokTani = dataGridView1.CurrentRow.Cells["id_kelompoktani"].Value?.ToString();
                originalNama = dataGridView1.CurrentRow.Cells["nama_kelompoktani"].Value?.ToString();
                originalNik = dataGridView1.CurrentRow.Cells["nik"].Value?.ToString();
                originalJumlah = dataGridView1.CurrentRow.Cells["jumlah_kelompoktani"].Value?.ToString();
                originalNoHp = dataGridView1.CurrentRow.Cells["no_hp_kelompoktani"].Value?.ToString();
                originalDeskripsiJalan = dataGridView1.CurrentRow.Cells["deskripsi_jalan"].Value?.ToString();

                string alamatGabungan = dataGridView1.CurrentRow.Cells["alamat"].Value?.ToString();
                if (!string.IsNullOrEmpty(alamatGabungan))
                {
                    string[] alamatParts = alamatGabungan.Split(',');
                    if (alamatParts.Length >= 3)
                    {
                        originalDesa = alamatParts[0].Trim();
                        originalKecamatan = alamatParts[1].Trim();
                        originalKabupaten = alamatParts[2].Trim();
                    }
                }
                else
                {
                    originalDesa = "";
                    originalKecamatan = "";
                    originalKabupaten = "";
                }

                textBox1.Text = originalNama;
                textBox2.Text = originalNik;
                textBox3.Text = originalJumlah;
                textBox4.Text = originalNoHp;
                textBox5.Text = originalDeskripsiJalan;

                if (!string.IsNullOrEmpty(alamatGabungan))
                {
                    string[] alamatParts = alamatGabungan.Split(',');

                    if (alamatParts.Length >= 3)
                    {
                        string desa = alamatParts[0].Trim();
                        string kecamatan = alamatParts[1].Trim();
                        string kabupaten = alamatParts[2].Trim();

                        comboBox1.SelectedItem = kabupaten;
                        LoadKecamatan(kabupaten);
                        comboBox2.SelectedItem = kecamatan;
                        LoadDesa(kabupaten, kecamatan);
                        comboBox3.SelectedItem = desa;

                        comboBox2.Enabled = true;
                        comboBox3.Enabled = true;
                    }
                }
            }
            else
            {
                KondisiAwal();
            }
        }

        private string GenerateNewKelompokTaniId()
        {
            string newId = "TN001";

            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();

                string query = "SELECT id_kelompoktani FROM kelompok_tani WHERE id_kelompoktani LIKE 'TN%' ORDER BY CAST(SUBSTRING(id_kelompoktani FROM 3) AS INTEGER) DESC LIMIT 1";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        string lastId = result.ToString();
                        string numberPart = lastId.Substring(2);
                        if (int.TryParse(numberPart, out int lastNumber))
                        {
                            int newNumber = lastNumber + 1;
                            newId = "TN" + newNumber.ToString("D3");
                        }
                    }
                }
            }
            return newId;
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

                    dataGridView1.DataSource = dataTable;

                    dataGridView1.Columns["id_kelompoktani"].HeaderText = "Kode";
                    dataGridView1.Columns["nama_kelompoktani"].HeaderText = "Nama Kelompok Tani";
                    dataGridView1.Columns["nik"].HeaderText = "NIK";
                    dataGridView1.Columns["jumlah_kelompoktani"].HeaderText = "Jumlah Anggota";
                    dataGridView1.Columns["no_hp_kelompoktani"].HeaderText = "Nomor HP";
                    dataGridView1.Columns["deskripsi_jalan"].HeaderText = "Deskripsi Jalan";
                    dataGridView1.Columns["alamat"].HeaderText = "Alamat";

                    dataGridView1.Columns["id_kelompoktani"].Width = 100;
                    dataGridView1.Columns["nama_kelompoktani"].Width = 200;
                    dataGridView1.Columns["nik"].Width = 130;
                    dataGridView1.Columns["jumlah_kelompoktani"].Width = 120;
                    dataGridView1.Columns["no_hp_kelompoktani"].Width = 130;
                    dataGridView1.Columns["deskripsi_jalan"].Width = 130;
                    dataGridView1.Columns["alamat"].Width = 250;

                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan saat mengambil data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BttnEdit_Click(object sender, EventArgs e)
        {
            string idKelompokTaniToEdit = null;

            if (dataGridView1.CurrentRow != null && dataGridView1.CurrentRow.Cells["id_kelompoktani"].Value != null)
            {
                idKelompokTaniToEdit = dataGridView1.CurrentRow.Cells["id_kelompoktani"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Pilih data yang ingin diubah terlebih dahulu dari tabel.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text) ||
                string.IsNullOrWhiteSpace(textBox3.Text) || string.IsNullOrWhiteSpace(textBox4.Text) ||
                string.IsNullOrWhiteSpace(textBox5.Text) || comboBox1.SelectedItem == null ||
                comboBox2.SelectedItem == null || comboBox3.SelectedItem == null)
            {
                MessageBox.Show("Pastikan Semua Form Terisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!long.TryParse(textBox2.Text, out _) || textBox2.Text.Length != 16)
            {
                MessageBox.Show("NIK harus 16 digit dan berupa angka.", "Kesalahan Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!long.TryParse(textBox4.Text, out _) || textBox4.Text.Length < 10 || textBox4.Text.Length > 12)
            {
                MessageBox.Show("Nomor HP harus berupa angka antara 10 12 digit.", "Kesalahan Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(textBox3.Text, out int jumlahKelompokTani))
            {
                MessageBox.Show("Jumlah Anggota harus berupa angka bulat.", "Kesalahan Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool hasChanged =
                textBox1.Text != originalNama ||
                textBox2.Text != originalNik ||
                textBox3.Text != originalJumlah ||
                textBox4.Text != originalNoHp ||
                textBox5.Text != originalDeskripsiJalan ||
                (comboBox1.SelectedItem?.ToString() ?? "") != originalKabupaten ||
                (comboBox2.SelectedItem?.ToString() ?? "") != originalKecamatan ||
                (comboBox3.SelectedItem?.ToString() ?? "") != originalDesa;

            if (!hasChanged)
            {
                MessageBox.Show("Tidak ada perubahan terdeteksi. Silakan ubah data sebelum menyimpan.", "Tidak Ada Perubahan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                int selectedRowIndex = dataGridView1.CurrentRow.Index;

                using (var conn = new NpgsqlConnection(connectionString))
                {
                    conn.Open();

                    string cekDuplikasiQuery = "SELECT COUNT(*) FROM kelompok_tani k " +
                                               "JOIN alamat a ON k.id_alamat = a.id_alamat " +
                                               "WHERE k.nama_kelompoktani = @nama " +
                                               "AND k.nik = @nik " +
                                               "AND a.desa = @desa AND a.kecamatan = @kecamatan AND a.kabupaten = @kabupaten " +
                                               "AND k.id_kelompoktani <> @currentIdKelompokTani AND k.is_active = TRUE";

                    using (var cekCmd = new NpgsqlCommand(cekDuplikasiQuery, conn))
                    {
                        cekCmd.Parameters.AddWithValue("@nama", textBox1.Text);
                        cekCmd.Parameters.AddWithValue("@nik", textBox2.Text);
                        cekCmd.Parameters.AddWithValue("@desa", comboBox3.SelectedItem.ToString());
                        cekCmd.Parameters.AddWithValue("@kecamatan", comboBox2.SelectedItem.ToString());
                        cekCmd.Parameters.AddWithValue("@kabupaten", comboBox1.SelectedItem.ToString());
                        cekCmd.Parameters.AddWithValue("@currentIdKelompokTani", idKelompokTaniToEdit);

                        int count = Convert.ToInt32(cekCmd.ExecuteScalar());
                        if (count > 0)
                        {
                            MessageBox.Show("Perubahan yang Anda lakukan akan menghasilkan duplikasi dengan data kelompok tani lain yang sudah ada.", "Duplikasi Terdeteksi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    string query = "UPDATE kelompok_tani SET " +
                                   "nama_kelompoktani = @nama, " +
                                   "nik = @nik, " +
                                   "jumlah_kelompoktani = @jumlah, " +
                                   "no_hp_kelompoktani = @no_hp, " +
                                   "deskripsi_jalan = @deskripsi_jalan, " +
                                   "id_alamat = (SELECT id_alamat FROM alamat WHERE desa = @desa AND kecamatan = @kecamatan AND kabupaten = @kabupaten) " +
                                   "WHERE id_kelompoktani = @id_kelompoktani";

                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@nama", textBox1.Text);
                        cmd.Parameters.AddWithValue("@nik", textBox2.Text);
                        cmd.Parameters.AddWithValue("@jumlah", jumlahKelompokTani);
                        cmd.Parameters.AddWithValue("@no_hp", textBox4.Text);
                        cmd.Parameters.AddWithValue("@deskripsi_jalan", textBox5.Text);
                        cmd.Parameters.AddWithValue("@kabupaten", comboBox1.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@kecamatan", comboBox2.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@desa", comboBox3.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@id_kelompoktani", idKelompokTaniToEdit);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Data berhasil diubah!");
                TampilkanKelompokTani();

                if (dataGridView1.Rows.Count > selectedRowIndex)
                {
                    dataGridView1.CurrentCell = dataGridView1.Rows[selectedRowIndex].Cells[0];
                    dataGridView1.Rows[selectedRowIndex].Selected = true;
                }

                KondisiAwal();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan saat mengubah data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null || comboBox2.SelectedItem == null)
                return;

            string kabupaten = comboBox1.SelectedItem.ToString();
            string kecamatan = comboBox2.SelectedItem.ToString();

            LoadDesa(kabupaten, kecamatan);
            comboBox3.Enabled = true;
            comboBox3.Text = "";
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

        private void btnInformasiAlat_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormInformasiAlat formInformasiAlat = new FormInformasiAlat();
            formInformasiAlat.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormHome formHome = new FormHome();
            formHome.Show();
        }

        private void btnLaporan_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLaporan formLaporan = new FormLaporan();
            formLaporan.Show();
        }

        private void btnRiwayat_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormRiwayat formRiwayat = new FormRiwayat();
            formRiwayat.Show();
        }

        private void btnPengembalian_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormPenggembalian formPenggembalian = new FormPenggembalian();
            formPenggembalian.Show();
        }

        private void btnPeminjaman_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormPeminjaman formPeminjaman = new FormPeminjaman();
            formPeminjaman.Show();
        }

        private void Admin_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAdmin formAdmin = new FormAdmin();
            formAdmin.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BttnTambah_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null && dataGridView1.CurrentRow.Selected)
            {
                MessageBox.Show("Anda sedang dalam mode edit. Untuk menambahkan data baru, silakan bersihkan form terlebih dahulu atau pastikan tidak ada data yang terpilih di tabel.", "Mode Edit Aktif", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text) ||
                string.IsNullOrWhiteSpace(textBox3.Text) || string.IsNullOrWhiteSpace(textBox4.Text) ||
                string.IsNullOrWhiteSpace(textBox5.Text) || comboBox1.SelectedItem == null ||
                comboBox2.SelectedItem == null || comboBox3.SelectedItem == null)
            {
                MessageBox.Show("⚠️ Pastikan semua form telah diisi!", "Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!long.TryParse(textBox2.Text, out _) || textBox2.Text.Length != 16)
            {
                MessageBox.Show("NIK harus berupa 16 digit angka.", "Kesalahan Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!long.TryParse(textBox4.Text, out _) || textBox4.Text.Length < 10 || textBox4.Text.Length > 12)
            {
                MessageBox.Show("Nomor HP harus berupa angka antara 10 sampai 12 digit.", "Kesalahan Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(textBox3.Text, out int jumlahKelompokTani))
            {
                MessageBox.Show("Jumlah Anggota harus berupa angka bulat.", "Kesalahan Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var conn = new NpgsqlConnection(connectionString))
                {
                    conn.Open();

                    string cekQuery = "SELECT COUNT(*) FROM kelompok_tani k " +
                                      "JOIN alamat a ON k.id_alamat = a.id_alamat " +
                                      "WHERE k.nama_kelompoktani = @nama AND k.nik = @nik " +
                                      "AND a.desa = @desa AND a.kecamatan = @kecamatan AND a.kabupaten = @kabupaten AND k.is_active = TRUE";

                    using (var cekCmd = new NpgsqlCommand(cekQuery, conn))
                    {
                        cekCmd.Parameters.AddWithValue("@nama", textBox1.Text);
                        cekCmd.Parameters.AddWithValue("@nik", textBox2.Text);
                        cekCmd.Parameters.AddWithValue("@desa", comboBox3.SelectedItem.ToString());
                        cekCmd.Parameters.AddWithValue("@kecamatan", comboBox2.SelectedItem.ToString());
                        cekCmd.Parameters.AddWithValue("@kabupaten", comboBox1.SelectedItem.ToString());

                        int count = Convert.ToInt32(cekCmd.ExecuteScalar());
                        if (count > 0)
                        {
                            MessageBox.Show("Data kelompok tani dengan Nama, NIK, dan Alamat yang sama sudah terdaftar.", "Duplikasi Terdeteksi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    string idBaru = GenerateNewKelompokTaniId();
                    string insertQuery = "INSERT INTO kelompok_tani (id_kelompoktani, nama_kelompoktani, nik, jumlah_kelompoktani, no_hp_kelompoktani, deskripsi_jalan, id_alamat, is_active) " +
                                         "VALUES (@id, @nama, @nik, @jumlah, @hp, @jalan, " +
                                         "(SELECT id_alamat FROM alamat WHERE desa = @desa AND kecamatan = @kecamatan AND kabupaten = @kabupaten), TRUE)";

                    using (var insertCmd = new NpgsqlCommand(insertQuery, conn))
                    {
                        insertCmd.Parameters.AddWithValue("@id", idBaru);
                        insertCmd.Parameters.AddWithValue("@nama", textBox1.Text);
                        insertCmd.Parameters.AddWithValue("@nik", textBox2.Text);
                        insertCmd.Parameters.AddWithValue("@jumlah", jumlahKelompokTani);
                        insertCmd.Parameters.AddWithValue("@hp", textBox4.Text);
                        insertCmd.Parameters.AddWithValue("@jalan", textBox5.Text);
                        insertCmd.Parameters.AddWithValue("@desa", comboBox3.SelectedItem.ToString());
                        insertCmd.Parameters.AddWithValue("@kecamatan", comboBox2.SelectedItem.ToString());
                        insertCmd.Parameters.AddWithValue("@kabupaten", comboBox1.SelectedItem.ToString());

                        insertCmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("✅ Data berhasil ditambahkan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TampilkanKelompokTani();
                    KondisiAwal();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Terjadi kesalahan saat menambahkan data:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}