namespace PROJEK_AKHIR
{
    partial class FormKelompokTani
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
            this.btnDelete = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LblJam = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.LblTanggal = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnExit = new System.Windows.Forms.Button();
            this.btnLaporan = new System.Windows.Forms.Button();
            this.btnRiwayat = new System.Windows.Forms.Button();
            this.btnPengembalian = new System.Windows.Forms.Button();
            this.btnInformasiAlat = new System.Windows.Forms.Button();
            this.btnPeminjaman = new System.Windows.Forms.Button();
            this.btnKelompokTani = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.Admin = new System.Windows.Forms.Label();
            this.Home = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.BackgroundImage = global::PROJEK_AKHIR.Properties.Resources.Bttn_Hapus;
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDelete.Location = new System.Drawing.Point(992, 132);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(38, 31);
            this.btnDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnDelete.TabIndex = 30;
            this.btnDelete.TabStop = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::PROJEK_AKHIR.Properties.Resources.Bttn_Edit;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(945, 132);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(38, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // LblJam
            // 
            this.LblJam.AutoSize = true;
            this.LblJam.Location = new System.Drawing.Point(526, 135);
            this.LblJam.Name = "LblJam";
            this.LblJam.Size = new System.Drawing.Size(39, 20);
            this.LblJam.TabIndex = 36;
            this.LblJam.Text = "Jam";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(471, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 35;
            this.label2.Text = "Jam :";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(292, 135);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(74, 20);
            this.Label1.TabIndex = 34;
            this.Label1.Text = "Tanggal :";
            // 
            // LblTanggal
            // 
            this.LblTanggal.AutoSize = true;
            this.LblTanggal.Location = new System.Drawing.Point(375, 135);
            this.LblTanggal.Name = "LblTanggal";
            this.LblTanggal.Size = new System.Drawing.Size(66, 20);
            this.LblTanggal.TabIndex = 33;
            this.LblTanggal.Text = "Tanggal";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(289, 175);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(768, 506);
            this.dataGridView1.TabIndex = 32;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.DimGray;
            this.btnExit.Location = new System.Drawing.Point(25, 441);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(178, 36);
            this.btnExit.TabIndex = 86;
            this.btnExit.Text = "Exit";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnLaporan
            // 
            this.btnLaporan.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnLaporan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLaporan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLaporan.ForeColor = System.Drawing.Color.DimGray;
            this.btnLaporan.Location = new System.Drawing.Point(25, 403);
            this.btnLaporan.Name = "btnLaporan";
            this.btnLaporan.Size = new System.Drawing.Size(178, 36);
            this.btnLaporan.TabIndex = 85;
            this.btnLaporan.Text = "Laporan";
            this.btnLaporan.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnLaporan.UseVisualStyleBackColor = false;
            this.btnLaporan.Click += new System.EventHandler(this.btnLaporan_Click);
            // 
            // btnRiwayat
            // 
            this.btnRiwayat.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnRiwayat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRiwayat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRiwayat.ForeColor = System.Drawing.Color.DimGray;
            this.btnRiwayat.Location = new System.Drawing.Point(25, 365);
            this.btnRiwayat.Name = "btnRiwayat";
            this.btnRiwayat.Size = new System.Drawing.Size(178, 36);
            this.btnRiwayat.TabIndex = 84;
            this.btnRiwayat.Text = "Riwayat";
            this.btnRiwayat.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnRiwayat.UseVisualStyleBackColor = false;
            this.btnRiwayat.Click += new System.EventHandler(this.btnRiwayat_Click);
            // 
            // btnPengembalian
            // 
            this.btnPengembalian.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnPengembalian.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPengembalian.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPengembalian.ForeColor = System.Drawing.Color.DimGray;
            this.btnPengembalian.Location = new System.Drawing.Point(25, 327);
            this.btnPengembalian.Name = "btnPengembalian";
            this.btnPengembalian.Size = new System.Drawing.Size(178, 36);
            this.btnPengembalian.TabIndex = 83;
            this.btnPengembalian.Text = "Pengembalian";
            this.btnPengembalian.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnPengembalian.UseVisualStyleBackColor = false;
            this.btnPengembalian.Click += new System.EventHandler(this.btnPengembalian_Click);
            // 
            // btnInformasiAlat
            // 
            this.btnInformasiAlat.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnInformasiAlat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInformasiAlat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInformasiAlat.ForeColor = System.Drawing.Color.DimGray;
            this.btnInformasiAlat.Location = new System.Drawing.Point(25, 252);
            this.btnInformasiAlat.Name = "btnInformasiAlat";
            this.btnInformasiAlat.Size = new System.Drawing.Size(178, 36);
            this.btnInformasiAlat.TabIndex = 82;
            this.btnInformasiAlat.Text = "Informasi Alat";
            this.btnInformasiAlat.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnInformasiAlat.UseVisualStyleBackColor = false;
            this.btnInformasiAlat.Click += new System.EventHandler(this.btnInformasiAlat_Click);
            // 
            // btnPeminjaman
            // 
            this.btnPeminjaman.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnPeminjaman.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPeminjaman.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPeminjaman.ForeColor = System.Drawing.Color.DimGray;
            this.btnPeminjaman.Location = new System.Drawing.Point(25, 289);
            this.btnPeminjaman.Name = "btnPeminjaman";
            this.btnPeminjaman.Size = new System.Drawing.Size(178, 36);
            this.btnPeminjaman.TabIndex = 81;
            this.btnPeminjaman.Text = "Peminjaman";
            this.btnPeminjaman.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnPeminjaman.UseVisualStyleBackColor = false;
            this.btnPeminjaman.Click += new System.EventHandler(this.btnPeminjaman_Click);
            // 
            // btnKelompokTani
            // 
            this.btnKelompokTani.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnKelompokTani.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKelompokTani.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKelompokTani.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnKelompokTani.Location = new System.Drawing.Point(25, 214);
            this.btnKelompokTani.Name = "btnKelompokTani";
            this.btnKelompokTani.Size = new System.Drawing.Size(178, 36);
            this.btnKelompokTani.TabIndex = 80;
            this.btnKelompokTani.Text = "Kelompok Tani";
            this.btnKelompokTani.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnKelompokTani.UseVisualStyleBackColor = false;
            // 
            // btnAdmin
            // 
            this.btnAdmin.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmin.ForeColor = System.Drawing.Color.DimGray;
            this.btnAdmin.Location = new System.Drawing.Point(25, 176);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(178, 36);
            this.btnAdmin.TabIndex = 79;
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
            this.btnHome.Location = new System.Drawing.Point(25, 138);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(178, 36);
            this.btnHome.TabIndex = 78;
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
            this.Admin.Location = new System.Drawing.Point(45, 191);
            this.Admin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Admin.Name = "Admin";
            this.Admin.Size = new System.Drawing.Size(0, 22);
            this.Admin.TabIndex = 77;
            // 
            // Home
            // 
            this.Home.AutoSize = true;
            this.Home.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Home.Location = new System.Drawing.Point(45, 143);
            this.Home.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(57, 22);
            this.Home.TabIndex = 76;
            this.Home.Text = "Home";
            // 
            // FormKelompokTani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PROJEK_AKHIR.Properties.Resources.Kelompok_Tani2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1077, 786);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnLaporan);
            this.Controls.Add(this.btnRiwayat);
            this.Controls.Add(this.btnPengembalian);
            this.Controls.Add(this.btnInformasiAlat);
            this.Controls.Add(this.btnPeminjaman);
            this.Controls.Add(this.btnKelompokTani);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.Admin);
            this.Controls.Add(this.Home);
            this.Controls.Add(this.LblJam);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.LblTanggal);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnDelete);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormKelompokTani";
            this.Text = "FormKelomppokTani";
            this.Load += new System.EventHandler(this.FormKelompokTani_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox btnDelete;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LblJam;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Label LblTanggal;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnLaporan;
        private System.Windows.Forms.Button btnRiwayat;
        private System.Windows.Forms.Button btnPengembalian;
        private System.Windows.Forms.Button btnInformasiAlat;
        private System.Windows.Forms.Button btnPeminjaman;
        private System.Windows.Forms.Button btnKelompokTani;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Label Admin;
        private System.Windows.Forms.Label Home;
    }
}