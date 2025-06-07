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
    public partial class FormKelompokTaniEdit: Form
    {
        string connectionString = "Host=localhost;Username=postgres;Password=Rfqh0_;Database=CANKULLIN";
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
            string kabupaten = comboBox1.SelectedItem.ToString();
            LoadKecamatan(kabupaten);

            comboBox2.Enabled = true;
            comboBox3.Enabled = false;
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

            comboBox2.Enabled = false; 
            comboBox3.Enabled = false;
            munculLevel1();

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
            if (dataGridView1.CurrentRow != null)
            {
                textBox1.Text = dataGridView1.CurrentRow.Cells["nama_kelompoktani"].Value?.ToString();
                textBox2.Text = dataGridView1.CurrentRow.Cells["nik"].Value?.ToString();
                textBox3.Text = dataGridView1.CurrentRow.Cells["jumlah_kelompoktani"].Value?.ToString();
                textBox4.Text = dataGridView1.CurrentRow.Cells["no_hp_kelompoktani"].Value?.ToString();
                textBox5.Text = dataGridView1.CurrentRow.Cells["deskripsi_jalan"].Value?.ToString();
                string alamatGabungan = dataGridView1.CurrentRow.Cells["alamat"].Value?.ToString();

                if (!string.IsNullOrEmpty(alamatGabungan))
                {
                    string[] alamatParts = alamatGabungan.Split(',');

                    if (alamatParts.Length == 3)
                    {
                        string desa = alamatParts[0].Trim();
                        string kecamatan = alamatParts[1].Trim();
                        string kabupaten = alamatParts[2].Trim();

                        comboBox1.SelectedIndex = comboBox1.FindStringExact(kabupaten);
                        comboBox2.SelectedIndex = comboBox2.FindStringExact(kecamatan);
                        comboBox3.SelectedIndex = comboBox3.FindStringExact(desa);
                    }
                }
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
                        int lastNumber = int.Parse(numberPart); 

                        int newNumber = lastNumber + 1;
                        newId = "TN" + newNumber.ToString("D3"); 
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
            if (textBox1.Text.Trim() == "" || textBox2.Text.Trim() == "" || textBox3.Text.Trim() == "" || textBox4.Text.Trim() == "" || textBox5.Text.Trim() == "" || comboBox1.Text.Trim() == "" || comboBox2.Text.Trim() == "" || comboBox3.Text.Trim() == "")
            {
                MessageBox.Show("Pastikan Semua Form Terisi!");
            }
            else
            {
                try
                {
                    string idKelompokTani = null;
                    if (dataGridView1.CurrentRow != null)
                        idKelompokTani = dataGridView1.CurrentRow.Cells["id_kelompoktani"].Value.ToString();

                    int selectedRowIndex = dataGridView1.CurrentRow.Index;

                    string query = "UPDATE kelompok_tani SET " + "nama_kelompoktani = @nama, " + "nik = @nik, " + "jumlah_kelompoktani = @jumlah, " + "no_hp_kelompoktani = @no_hp, " + "deskripsi_jalan = @deskripsi_jalan, " + "id_alamat = (SELECT id_alamat FROM alamat WHERE desa = @desa AND kecamatan = @kecamatan AND kabupaten = @kabupaten) " + 
                        "WHERE id_kelompoktani = @id_kelompoktani";

                    using (var conn = new NpgsqlConnection(connectionString))
                    {
                        conn.Open();
                        using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@nama", textBox1.Text);
                            cmd.Parameters.AddWithValue("@nik", textBox2.Text);

                            int jumlahKelompokTani;
                            if (int.TryParse(textBox3.Text, out jumlahKelompokTani))
                            {
                                cmd.Parameters.AddWithValue("@jumlah", jumlahKelompokTani);
                            }
                            else
                            {                                
                                MessageBox.Show("Jumlah Kelompok Tani harus berupa angka bulat.", "Kesalahan Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return; 
                            }
                            cmd.Parameters.AddWithValue("@no_hp", textBox4.Text);
                            cmd.Parameters.AddWithValue("@deskripsi_jalan", textBox5.Text);
                            cmd.Parameters.AddWithValue("@kabupaten", comboBox1.Text);
                            cmd.Parameters.AddWithValue("@kecamatan", comboBox2.Text);
                            cmd.Parameters.AddWithValue("@desa", comboBox3.Text);
                            cmd.Parameters.AddWithValue("@id_kelompoktani", idKelompokTani);

                            cmd.ExecuteNonQuery();

                        }
                    }

                    MessageBox.Show("Data berhasil diubah!");
                    TampilkanKelompokTani();

                    if (dataGridView1.Rows.Count > selectedRowIndex)
                    {
                        dataGridView1.CurrentCell = dataGridView1.Rows[selectedRowIndex].Cells[0];
                    }

                    KondisiAwal();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Terjadi kesalahan saat mengubah data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BttnTambah_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == "" || textBox2.Text.Trim() == "" || textBox3.Text.Trim() == "" || textBox4.Text.Trim() == "" || textBox5.Text.Trim() == "" || comboBox1.Text.Trim() == "" || comboBox2.Text.Trim() == "" || comboBox3.Text.Trim() == "")
            {
                MessageBox.Show("Pastikan Semua Form Terisi!");
            }
            else
            {
                try
                {
                    string newKelompokTaniId = GenerateNewKelompokTaniId();
                    string query = "INSERT INTO kelompok_tani (id_kelompoktani, nama_kelompoktani, nik, jumlah_kelompoktani, no_hp_kelompoktani, id_alamat, deskripsi_jalan) " + 
                        "VALUES (@idKelompokTani, @nama, @nik, @jumlah, @no_hp, " + 
                        "(SELECT id_alamat FROM alamat WHERE desa = @desa AND kecamatan = @kecamatan AND kabupaten = @kabupaten), @deskripsi_jalan)";

                    using (var conn = new NpgsqlConnection(connectionString))
                    {
                        conn.Open();
                        using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@idKelompokTani", newKelompokTaniId);
                            cmd.Parameters.AddWithValue("@nama", textBox1.Text);
                            cmd.Parameters.AddWithValue("@nik", textBox2.Text);

                            int jumlahKelompokTani;
                            if (int.TryParse(textBox3.Text, out jumlahKelompokTani))
                            {
                                cmd.Parameters.AddWithValue("@jumlah", jumlahKelompokTani);
                            }
                            else
                            {
                                MessageBox.Show("Jumlah Kelompok Tani harus berupa angka bulat.", "Kesalahan Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return; 
                            }

                            cmd.Parameters.AddWithValue("@no_hp", textBox4.Text);
                            cmd.Parameters.AddWithValue("@deskripsi_jalan", textBox5.Text);
                            cmd.Parameters.AddWithValue("@kabupaten", comboBox1.Text); 
                            cmd.Parameters.AddWithValue("@kecamatan", comboBox2.Text); 
                            cmd.Parameters.AddWithValue("@desa", comboBox3.Text);

                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Data berhasil ditambahkan!");
                            TampilkanKelompokTani();  
                            KondisiAwal();  
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Terjadi kesalahan saat menambah data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
    }
}
