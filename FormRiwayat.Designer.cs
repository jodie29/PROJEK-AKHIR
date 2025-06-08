namespace PROJEK_AKHIR
{
    partial class FormRiwayat
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
            this.dtGridRiwayat = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnKelompokTani = new System.Windows.Forms.Button();
            this.btnRiwayat = new System.Windows.Forms.Button();
            this.btnPengembalian = new System.Windows.Forms.Button();
            this.btnInformasiAlat = new System.Windows.Forms.Button();
            this.btnPeminjaman = new System.Windows.Forms.Button();
            this.btnLaporan = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.Admin = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridRiwayat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtGridRiwayat
            // 
            this.dtGridRiwayat.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dtGridRiwayat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtGridRiwayat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridRiwayat.Location = new System.Drawing.Point(288, 179);
            this.dtGridRiwayat.Name = "dtGridRiwayat";
            this.dtGridRiwayat.RowHeadersVisible = false;
            this.dtGridRiwayat.RowHeadersWidth = 62;
            this.dtGridRiwayat.RowTemplate.Height = 28;
            this.dtGridRiwayat.Size = new System.Drawing.Size(763, 434);
            this.dtGridRiwayat.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.BackgroundImage = global::PROJEK_AKHIR.Properties.Resources.Vector;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(515, 142);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.TabIndex = 70;
            this.pictureBox1.TabStop = false;
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.SystemColors.Window;
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(288, 139);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(259, 32);
            this.txtSearch.TabIndex = 69;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Window;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.label3.Location = new System.Drawing.Point(306, 146);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 20);
            this.label3.TabIndex = 68;
            // 
            // cmbStatus
            // 
            this.cmbStatus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(901, 138);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(150, 28);
            this.cmbStatus.TabIndex = 71;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.DimGray;
            this.btnExit.Location = new System.Drawing.Point(25, 437);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(178, 36);
            this.btnExit.TabIndex = 95;
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
            this.btnKelompokTani.Location = new System.Drawing.Point(25, 214);
            this.btnKelompokTani.Name = "btnKelompokTani";
            this.btnKelompokTani.Size = new System.Drawing.Size(178, 36);
            this.btnKelompokTani.TabIndex = 94;
            this.btnKelompokTani.Text = "Kelompok Tani";
            this.btnKelompokTani.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnKelompokTani.UseVisualStyleBackColor = false;
            this.btnKelompokTani.Click += new System.EventHandler(this.btnKelompokTani_Click_1);
            // 
            // btnRiwayat
            // 
            this.btnRiwayat.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnRiwayat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRiwayat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRiwayat.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRiwayat.Location = new System.Drawing.Point(25, 363);
            this.btnRiwayat.Name = "btnRiwayat";
            this.btnRiwayat.Size = new System.Drawing.Size(178, 36);
            this.btnRiwayat.TabIndex = 93;
            this.btnRiwayat.Text = "Riwayat";
            this.btnRiwayat.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRiwayat.UseVisualStyleBackColor = false;
            // 
            // btnPengembalian
            // 
            this.btnPengembalian.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnPengembalian.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPengembalian.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPengembalian.ForeColor = System.Drawing.Color.DimGray;
            this.btnPengembalian.Location = new System.Drawing.Point(25, 326);
            this.btnPengembalian.Name = "btnPengembalian";
            this.btnPengembalian.Size = new System.Drawing.Size(178, 36);
            this.btnPengembalian.TabIndex = 92;
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
            this.btnInformasiAlat.TabIndex = 91;
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
            this.btnPeminjaman.TabIndex = 90;
            this.btnPeminjaman.Text = "Peminjaman";
            this.btnPeminjaman.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnPeminjaman.UseVisualStyleBackColor = false;
            this.btnPeminjaman.Click += new System.EventHandler(this.btnPeminjaman_Click);
            // 
            // btnLaporan
            // 
            this.btnLaporan.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnLaporan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLaporan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLaporan.ForeColor = System.Drawing.Color.DimGray;
            this.btnLaporan.Location = new System.Drawing.Point(25, 400);
            this.btnLaporan.Name = "btnLaporan";
            this.btnLaporan.Size = new System.Drawing.Size(178, 36);
            this.btnLaporan.TabIndex = 89;
            this.btnLaporan.Text = "Laporan";
            this.btnLaporan.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnLaporan.UseVisualStyleBackColor = false;
            this.btnLaporan.Click += new System.EventHandler(this.btnLaporan_Click);
            // 
            // btnAdmin
            // 
            this.btnAdmin.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmin.ForeColor = System.Drawing.Color.DimGray;
            this.btnAdmin.Location = new System.Drawing.Point(25, 177);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(178, 36);
            this.btnAdmin.TabIndex = 88;
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
            this.btnHome.Location = new System.Drawing.Point(25, 139);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(178, 36);
            this.btnHome.TabIndex = 87;
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
            this.Admin.Location = new System.Drawing.Point(45, 185);
            this.Admin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Admin.Name = "Admin";
            this.Admin.Size = new System.Drawing.Size(0, 22);
            this.Admin.TabIndex = 86;
            // 
            // FormRiwayat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PROJEK_AKHIR.Properties.Resources.FiturRiwayat;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1077, 786);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnKelompokTani);
            this.Controls.Add(this.btnRiwayat);
            this.Controls.Add(this.btnPengembalian);
            this.Controls.Add(this.btnInformasiAlat);
            this.Controls.Add(this.btnPeminjaman);
            this.Controls.Add(this.btnLaporan);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.Admin);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtGridRiwayat);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormRiwayat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormRiwayat";
            ((System.ComponentModel.ISupportInitialize)(this.dtGridRiwayat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtGridRiwayat;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnKelompokTani;
        private System.Windows.Forms.Button btnRiwayat;
        private System.Windows.Forms.Button btnPengembalian;
        private System.Windows.Forms.Button btnInformasiAlat;
        private System.Windows.Forms.Button btnPeminjaman;
        private System.Windows.Forms.Button btnLaporan;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Label Admin;
    }
}