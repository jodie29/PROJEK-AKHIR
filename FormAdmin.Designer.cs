namespace PROJEK_AKHIR
{
    partial class FormAdmin
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.LblTanggal = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LblJam = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnExit = new System.Windows.Forms.Button();
            this.btnLaporan = new System.Windows.Forms.Button();
            this.btnRiwayat = new System.Windows.Forms.Button();
            this.btnPengembalian = new System.Windows.Forms.Button();
            this.btnInformasiAlat = new System.Windows.Forms.Button();
            this.btnPeminjaman = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.btnKelompoktani = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.Admin = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(191, 111);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(513, 330);
            this.dataGridView1.TabIndex = 0;
            // 
            // LblTanggal
            // 
            this.LblTanggal.AutoSize = true;
            this.LblTanggal.Location = new System.Drawing.Point(250, 88);
            this.LblTanggal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblTanggal.Name = "LblTanggal";
            this.LblTanggal.Size = new System.Drawing.Size(46, 13);
            this.LblTanggal.TabIndex = 1;
            this.LblTanggal.Text = "Tanggal";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(195, 88);
            this.Label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(52, 13);
            this.Label1.TabIndex = 2;
            this.Label1.Text = "Tanggal :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(314, 88);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Jam :";
            // 
            // LblJam
            // 
            this.LblJam.AutoSize = true;
            this.LblJam.Location = new System.Drawing.Point(351, 88);
            this.LblJam.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblJam.Name = "LblJam";
            this.LblJam.Size = new System.Drawing.Size(26, 13);
            this.LblJam.TabIndex = 4;
            this.LblJam.Text = "Jam";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.DimGray;
            this.btnExit.Location = new System.Drawing.Point(17, 283);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(119, 23);
            this.btnExit.TabIndex = 85;
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
            this.btnLaporan.Location = new System.Drawing.Point(17, 259);
            this.btnLaporan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLaporan.Name = "btnLaporan";
            this.btnLaporan.Size = new System.Drawing.Size(119, 23);
            this.btnLaporan.TabIndex = 84;
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
            this.btnRiwayat.Location = new System.Drawing.Point(17, 235);
            this.btnRiwayat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRiwayat.Name = "btnRiwayat";
            this.btnRiwayat.Size = new System.Drawing.Size(119, 23);
            this.btnRiwayat.TabIndex = 83;
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
            this.btnPengembalian.Location = new System.Drawing.Point(17, 211);
            this.btnPengembalian.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPengembalian.Name = "btnPengembalian";
            this.btnPengembalian.Size = new System.Drawing.Size(119, 23);
            this.btnPengembalian.TabIndex = 82;
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
            this.btnInformasiAlat.Location = new System.Drawing.Point(17, 163);
            this.btnInformasiAlat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnInformasiAlat.Name = "btnInformasiAlat";
            this.btnInformasiAlat.Size = new System.Drawing.Size(119, 23);
            this.btnInformasiAlat.TabIndex = 81;
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
            this.btnPeminjaman.Location = new System.Drawing.Point(17, 187);
            this.btnPeminjaman.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPeminjaman.Name = "btnPeminjaman";
            this.btnPeminjaman.Size = new System.Drawing.Size(119, 23);
            this.btnPeminjaman.TabIndex = 80;
            this.btnPeminjaman.Text = "Peminjaman";
            this.btnPeminjaman.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnPeminjaman.UseVisualStyleBackColor = false;
            this.btnPeminjaman.Click += new System.EventHandler(this.btnPeminjaman_Click);
            // 
            // btnAdmin
            // 
            this.btnAdmin.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAdmin.Location = new System.Drawing.Point(17, 114);
            this.btnAdmin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(119, 23);
            this.btnAdmin.TabIndex = 79;
            this.btnAdmin.Text = "Admin";
            this.btnAdmin.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAdmin.UseVisualStyleBackColor = false;
            // 
            // btnKelompoktani
            // 
            this.btnKelompoktani.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnKelompoktani.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKelompoktani.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKelompoktani.ForeColor = System.Drawing.Color.DimGray;
            this.btnKelompoktani.Location = new System.Drawing.Point(17, 138);
            this.btnKelompoktani.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnKelompoktani.Name = "btnKelompoktani";
            this.btnKelompoktani.Size = new System.Drawing.Size(119, 23);
            this.btnKelompoktani.TabIndex = 78;
            this.btnKelompoktani.Text = "Kelompok Tani";
            this.btnKelompoktani.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnKelompoktani.UseVisualStyleBackColor = false;
            this.btnKelompoktani.Click += new System.EventHandler(this.btnKelompoktani_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.DimGray;
            this.btnHome.Location = new System.Drawing.Point(17, 90);
            this.btnHome.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(119, 23);
            this.btnHome.TabIndex = 77;
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
            this.Admin.Location = new System.Drawing.Point(30, 120);
            this.Admin.Name = "Admin";
            this.Admin.Size = new System.Drawing.Size(0, 15);
            this.Admin.TabIndex = 76;
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PROJEK_AKHIR.Properties.Resources.Fitur_Admin__1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(718, 511);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnLaporan);
            this.Controls.Add(this.btnRiwayat);
            this.Controls.Add(this.btnPengembalian);
            this.Controls.Add(this.btnInformasiAlat);
            this.Controls.Add(this.btnPeminjaman);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.btnKelompoktani);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.Admin);
            this.Controls.Add(this.LblJam);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.LblTanggal);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAdmin";
            this.Load += new System.EventHandler(this.FormAdmin_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label LblTanggal;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblJam;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnLaporan;
        private System.Windows.Forms.Button btnRiwayat;
        private System.Windows.Forms.Button btnPengembalian;
        private System.Windows.Forms.Button btnInformasiAlat;
        private System.Windows.Forms.Button btnPeminjaman;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Button btnKelompoktani;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Label Admin;
    }
}