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
    public partial class FormKelomppokTani: Form
    {
        string connectionString = "Host=localhost;Username=postgres;Password=Rfqh0_;Database=CANKULLIN";
        public FormKelomppokTani()
        {
            InitializeComponent();
        }
               
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                using (var conn = new NpgsqlConnection(connectionString))
                {
                    conn.Open();
                    if (dataGridView1.SelectedRows.Count > 0)
                    {
                        var selectedRow = dataGridView1.SelectedRows[0];
                        var idKelompokTaniValue = selectedRow.Cells["id_kelompoktani"].Value.ToString();
                        var namaKelompokTani = selectedRow.Cells["nama_kelompoktani"].Value.ToString();
                        var nik = selectedRow.Cells["nik"].Value.ToString();
                        var jumlahKelompokTani = selectedRow.Cells["jumlah_kelompoktani"].Value.ToString();
                        var noHpKelompokTani = selectedRow.Cells["no_hp_kelompoktani"].Value.ToString();
                        var deskripsiJalan = selectedRow.Cells["deskripsi_jalan"].Value.ToString();
                        var alamat = selectedRow.Cells["alamat"].Value.ToString();

                        DialogResult dialogResult = MessageBox.Show(
                            $"Anda yakin ingin menghapus data Kelompok Tani dengan ID '{idKelompokTaniValue}'?",
                            "Konfirmasi Hapus Data",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question);

                        if (dialogResult == DialogResult.Yes)
                        {                            
                            string insertRiwayatQuery = "INSERT INTO riwayat_kelompok_tani (id_kelompoktani, nama_kelompoktani, nik, jumlah_kelompoktani, no_hp_kelompoktani, deskripsi_jalan, alamat, tanggal_hapus) " +
                            "SELECT k.id_kelompoktani, k.nama_kelompoktani, k.nik, k.jumlah_kelompoktani, k.no_hp_kelompoktani, k.deskripsi_jalan, " +
                            "a.desa || ',' || a.kecamatan || ',' || a.kabupaten AS alamat, CURRENT_TIMESTAMP " +
                            "FROM kelompok_tani k " +
                            "JOIN alamat a ON k.id_alamat = a.id_alamat " + 
                            "WHERE k.id_kelompoktani = @id_kelompoktani";

                            using (var cmdRiwayat = new NpgsqlCommand(insertRiwayatQuery, conn))
                            {
                                cmdRiwayat.Parameters.AddWithValue("@id_kelompoktani", idKelompokTaniValue);
                                cmdRiwayat.ExecuteNonQuery();
                            }

                            string deleteKelompokQuery = "DELETE FROM kelompok_tani WHERE id_kelompoktani = @id_kelompoktani";
                            using (var cmdKelompok = new NpgsqlCommand(deleteKelompokQuery, conn))
                            {
                                cmdKelompok.Parameters.AddWithValue("@id_kelompoktani", idKelompokTaniValue);
                                cmdKelompok.ExecuteNonQuery();
                            }

                            TampilkanKelompokTani();
                            MessageBox.Show("Data Kelompok Tani berhasil dihapus.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            KondisiAwal();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Silakan pilih baris data Kelompok Tani yang ingin dihapus.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan saat menghapus data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void KondisiAwal()
        {
            LblTanggal.Text = DateTime.Now.ToString("dd-MM-yyyy");
            TampilkanKelompokTani();
        }

        private void TampilkanKelompokTani()
        {
            try
            {
                string query = "SELECT k.id_kelompoktani, k.nama_kelompoktani, k.nik, k.jumlah_kelompoktani, k.no_hp_kelompoktani, k.deskripsi_jalan, a.desa || ',' || a.kecamatan || ',' || a.kabupaten AS alamat " +
               "FROM kelompok_tani k " +
               "JOIN alamat a ON k.id_alamat = a.id_alamat " + "Order By k.id_kelompoktani Asc";

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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormKelompokTaniEdit formKelompokTaniEdit = new FormKelompokTaniEdit();
            formKelompokTaniEdit.Show();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            LblJam.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }
                
        private void FormKelomppokTani_Load(object sender, EventArgs e)
        {
            KondisiAwal();
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
    }
}
