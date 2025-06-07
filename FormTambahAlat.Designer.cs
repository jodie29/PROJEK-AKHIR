namespace PROJEK_AKHIR
{
    partial class FormTambahAlat
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtNamaAlat = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtJumlahAlat = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPilihGambar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnTambah = new System.Windows.Forms.Button();
            this.pictureBoxAlat = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnKelompokTani = new System.Windows.Forms.Button();
            this.btnRiwayat = new System.Windows.Forms.Button();
            this.btnLaporan = new System.Windows.Forms.Button();
            this.btnInformasiAlat = new System.Windows.Forms.Button();
            this.btnPeminjaman = new System.Windows.Forms.Button();
            this.btnPengembalian = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.Admin = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAlat)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNamaAlat
            // 
            this.txtNamaAlat.Location = new System.Drawing.Point(413, 469);
            this.txtNamaAlat.Name = "txtNamaAlat";
            this.txtNamaAlat.Size = new System.Drawing.Size(472, 26);
            this.txtNamaAlat.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtJumlahAlat
            // 
            this.txtJumlahAlat.Location = new System.Drawing.Point(413, 526);
            this.txtJumlahAlat.Name = "txtJumlahAlat";
            this.txtJumlahAlat.Size = new System.Drawing.Size(472, 26);
            this.txtJumlahAlat.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(409, 442);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nama Alat";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(409, 500);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Jumlah";
            // 
            // btnPilihGambar
            // 
            this.btnPilihGambar.BackColor = System.Drawing.Color.ForestGreen;
            this.btnPilihGambar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPilihGambar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPilihGambar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPilihGambar.Location = new System.Drawing.Point(587, 401);
            this.btnPilihGambar.Name = "btnPilihGambar";
            this.btnPilihGambar.Size = new System.Drawing.Size(139, 33);
            this.btnPilihGambar.TabIndex = 5;
            this.btnPilihGambar.Text = "Pilih Gambar";
            this.btnPilihGambar.UseVisualStyleBackColor = false;
            this.btnPilihGambar.Click += new System.EventHandler(this.btnPilihGambar_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(781, 622);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 37);
            this.button2.TabIndex = 6;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnTambah
            // 
            this.btnTambah.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnTambah.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnTambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTambah.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTambah.Location = new System.Drawing.Point(891, 622);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(124, 37);
            this.btnTambah.TabIndex = 7;
            this.btnTambah.Text = "Tambah";
            this.btnTambah.UseVisualStyleBackColor = false;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // pictureBoxAlat
            // 
            this.pictureBoxAlat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxAlat.Location = new System.Drawing.Point(587, 289);
            this.pictureBoxAlat.Name = "pictureBoxAlat";
            this.pictureBoxAlat.Size = new System.Drawing.Size(139, 106);
            this.pictureBoxAlat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxAlat.TabIndex = 8;
            this.pictureBoxAlat.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.DimGray;
            this.btnExit.Location = new System.Drawing.Point(24, 439);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(178, 36);
            this.btnExit.TabIndex = 105;
            this.btnExit.Text = "Exit";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnKelompokTani
            // 
            this.btnKelompokTani.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnKelompokTani.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKelompokTani.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKelompokTani.ForeColor = System.Drawing.Color.DimGray;
            this.btnKelompokTani.Location = new System.Drawing.Point(24, 216);
            this.btnKelompokTani.Name = "btnKelompokTani";
            this.btnKelompokTani.Size = new System.Drawing.Size(178, 36);
            this.btnKelompokTani.TabIndex = 104;
            this.btnKelompokTani.Text = "Kelompok Tani";
            this.btnKelompokTani.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnKelompokTani.UseVisualStyleBackColor = false;
            this.btnKelompokTani.Click += new System.EventHandler(this.btnKelompokTani_Click);
            // 
            // btnRiwayat
            // 
            this.btnRiwayat.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnRiwayat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRiwayat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRiwayat.ForeColor = System.Drawing.Color.DimGray;
            this.btnRiwayat.Location = new System.Drawing.Point(24, 365);
            this.btnRiwayat.Name = "btnRiwayat";
            this.btnRiwayat.Size = new System.Drawing.Size(178, 36);
            this.btnRiwayat.TabIndex = 103;
            this.btnRiwayat.Text = "Riwayat";
            this.btnRiwayat.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnRiwayat.UseVisualStyleBackColor = false;
            this.btnRiwayat.Click += new System.EventHandler(this.btnRiwayat_Click);
            // 
            // btnLaporan
            // 
            this.btnLaporan.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnLaporan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLaporan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLaporan.ForeColor = System.Drawing.Color.DimGray;
            this.btnLaporan.Location = new System.Drawing.Point(24, 402);
            this.btnLaporan.Name = "btnLaporan";
            this.btnLaporan.Size = new System.Drawing.Size(178, 36);
            this.btnLaporan.TabIndex = 102;
            this.btnLaporan.Text = "Laporan";
            this.btnLaporan.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnLaporan.UseVisualStyleBackColor = false;
            this.btnLaporan.Click += new System.EventHandler(this.btnLaporan_Click);
            // 
            // btnInformasiAlat
            // 
            this.btnInformasiAlat.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnInformasiAlat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInformasiAlat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInformasiAlat.ForeColor = System.Drawing.Color.DimGray;
            this.btnInformasiAlat.Location = new System.Drawing.Point(24, 254);
            this.btnInformasiAlat.Name = "btnInformasiAlat";
            this.btnInformasiAlat.Size = new System.Drawing.Size(178, 36);
            this.btnInformasiAlat.TabIndex = 101;
            this.btnInformasiAlat.Text = "Informasi Alat";
            this.btnInformasiAlat.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnInformasiAlat.UseVisualStyleBackColor = false;
            // 
            // btnPeminjaman
            // 
            this.btnPeminjaman.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnPeminjaman.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPeminjaman.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPeminjaman.ForeColor = System.Drawing.Color.DimGray;
            this.btnPeminjaman.Location = new System.Drawing.Point(24, 291);
            this.btnPeminjaman.Name = "btnPeminjaman";
            this.btnPeminjaman.Size = new System.Drawing.Size(178, 36);
            this.btnPeminjaman.TabIndex = 100;
            this.btnPeminjaman.Text = "Peminjaman";
            this.btnPeminjaman.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnPeminjaman.UseVisualStyleBackColor = false;
            this.btnPeminjaman.Click += new System.EventHandler(this.btnPeminjaman_Click);
            // 
            // btnPengembalian
            // 
            this.btnPengembalian.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnPengembalian.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPengembalian.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPengembalian.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPengembalian.Location = new System.Drawing.Point(24, 328);
            this.btnPengembalian.Name = "btnPengembalian";
            this.btnPengembalian.Size = new System.Drawing.Size(178, 36);
            this.btnPengembalian.TabIndex = 99;
            this.btnPengembalian.Text = "Pengembalian";
            this.btnPengembalian.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPengembalian.UseVisualStyleBackColor = false;
            this.btnPengembalian.Click += new System.EventHandler(this.btnPengembalian_Click);
            // 
            // btnAdmin
            // 
            this.btnAdmin.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmin.ForeColor = System.Drawing.Color.DimGray;
            this.btnAdmin.Location = new System.Drawing.Point(24, 179);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(178, 36);
            this.btnAdmin.TabIndex = 98;
            this.btnAdmin.Text = "Admin";
            this.btnAdmin.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnAdmin.UseVisualStyleBackColor = false;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.DimGray;
            this.btnHome.Location = new System.Drawing.Point(24, 141);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(178, 36);
            this.btnHome.TabIndex = 97;
            this.btnHome.Text = "Home";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // Admin
            // 
            this.Admin.AutoSize = true;
            this.Admin.BackColor = System.Drawing.SystemColors.Control;
            this.Admin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Admin.Location = new System.Drawing.Point(44, 187);
            this.Admin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Admin.Name = "Admin";
            this.Admin.Size = new System.Drawing.Size(0, 22);
            this.Admin.TabIndex = 96;
            // 
            // FormTambahAlat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PROJEK_AKHIR.Properties.Resources.Tambah_Alat1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1077, 786);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnKelompokTani);
            this.Controls.Add(this.btnRiwayat);
            this.Controls.Add(this.btnLaporan);
            this.Controls.Add(this.btnInformasiAlat);
            this.Controls.Add(this.btnPeminjaman);
            this.Controls.Add(this.btnPengembalian);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.Admin);
            this.Controls.Add(this.pictureBoxAlat);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnPilihGambar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtJumlahAlat);
            this.Controls.Add(this.txtNamaAlat);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormTambahAlat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormTambahAlat";
            this.Load += new System.EventHandler(this.FormTambahAlat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAlat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNamaAlat;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txtJumlahAlat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPilihGambar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.PictureBox pictureBoxAlat;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnKelompokTani;
        private System.Windows.Forms.Button btnRiwayat;
        private System.Windows.Forms.Button btnLaporan;
        private System.Windows.Forms.Button btnInformasiAlat;
        private System.Windows.Forms.Button btnPeminjaman;
        private System.Windows.Forms.Button btnPengembalian;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Label Admin;
    }
}