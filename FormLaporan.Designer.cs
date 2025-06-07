namespace PROJEK_AKHIR
{
    partial class FormLaporan
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtJumlahAdmin = new System.Windows.Forms.TextBox();
            this.txtJenisAlat = new System.Windows.Forms.TextBox();
            this.txtAlatTersedia = new System.Windows.Forms.TextBox();
            this.txtAlatDipinjam = new System.Windows.Forms.TextBox();
            this.txtPengembalian30 = new System.Windows.Forms.TextBox();
            this.txtPengembalian7 = new System.Windows.Forms.TextBox();
            this.txtPeminjaman30 = new System.Windows.Forms.TextBox();
            this.txtPeminjaman7 = new System.Windows.Forms.TextBox();
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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(355, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Jumlan Admin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(356, 518);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Jumlah Jenis Alat";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(695, 294);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(265, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Jumlah Pengembalian 7 Hari";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(356, 294);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(207, 22);
            this.label4.TabIndex = 2;
            this.label4.Text = "Jumlan Alat Yang Ada";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(695, 406);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(258, 22);
            this.label5.TabIndex = 5;
            this.label5.Text = "Jumlah Peminjaman 30 Hari";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(356, 406);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(197, 22);
            this.label6.TabIndex = 4;
            this.label6.Text = "Jumlan Alat Dipinjam";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(695, 518);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(247, 22);
            this.label7.TabIndex = 7;
            this.label7.Text = "Jumlah Peminjaman 7 Hari";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(694, 182);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(276, 22);
            this.label8.TabIndex = 6;
            this.label8.Text = "Jumlah Pengembalian 30 Hari";
            // 
            // txtJumlahAdmin
            // 
            this.txtJumlahAdmin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtJumlahAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJumlahAdmin.Location = new System.Drawing.Point(430, 233);
            this.txtJumlahAdmin.Name = "txtJumlahAdmin";
            this.txtJumlahAdmin.Size = new System.Drawing.Size(59, 28);
            this.txtJumlahAdmin.TabIndex = 8;
            // 
            // txtJenisAlat
            // 
            this.txtJenisAlat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtJenisAlat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJenisAlat.Location = new System.Drawing.Point(430, 565);
            this.txtJenisAlat.Name = "txtJenisAlat";
            this.txtJenisAlat.Size = new System.Drawing.Size(59, 28);
            this.txtJenisAlat.TabIndex = 9;
            // 
            // txtAlatTersedia
            // 
            this.txtAlatTersedia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAlatTersedia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAlatTersedia.Location = new System.Drawing.Point(430, 338);
            this.txtAlatTersedia.Name = "txtAlatTersedia";
            this.txtAlatTersedia.Size = new System.Drawing.Size(59, 28);
            this.txtAlatTersedia.TabIndex = 10;
            // 
            // txtAlatDipinjam
            // 
            this.txtAlatDipinjam.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAlatDipinjam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAlatDipinjam.Location = new System.Drawing.Point(430, 449);
            this.txtAlatDipinjam.Name = "txtAlatDipinjam";
            this.txtAlatDipinjam.Size = new System.Drawing.Size(59, 28);
            this.txtAlatDipinjam.TabIndex = 11;
            // 
            // txtPengembalian30
            // 
            this.txtPengembalian30.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPengembalian30.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPengembalian30.Location = new System.Drawing.Point(764, 233);
            this.txtPengembalian30.Name = "txtPengembalian30";
            this.txtPengembalian30.Size = new System.Drawing.Size(59, 28);
            this.txtPengembalian30.TabIndex = 12;
            // 
            // txtPengembalian7
            // 
            this.txtPengembalian7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPengembalian7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPengembalian7.Location = new System.Drawing.Point(764, 338);
            this.txtPengembalian7.Name = "txtPengembalian7";
            this.txtPengembalian7.Size = new System.Drawing.Size(59, 28);
            this.txtPengembalian7.TabIndex = 13;
            // 
            // txtPeminjaman30
            // 
            this.txtPeminjaman30.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPeminjaman30.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPeminjaman30.Location = new System.Drawing.Point(764, 449);
            this.txtPeminjaman30.Name = "txtPeminjaman30";
            this.txtPeminjaman30.Size = new System.Drawing.Size(59, 28);
            this.txtPeminjaman30.TabIndex = 14;
            // 
            // txtPeminjaman7
            // 
            this.txtPeminjaman7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPeminjaman7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPeminjaman7.Location = new System.Drawing.Point(764, 565);
            this.txtPeminjaman7.Name = "txtPeminjaman7";
            this.txtPeminjaman7.Size = new System.Drawing.Size(59, 28);
            this.txtPeminjaman7.TabIndex = 15;
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
            this.btnExit.TabIndex = 85;
            this.btnExit.Text = "Exit";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnExit.UseVisualStyleBackColor = false;
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
            this.btnKelompokTani.TabIndex = 84;
            this.btnKelompokTani.Text = "Kelompok Tani";
            this.btnKelompokTani.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnKelompokTani.UseVisualStyleBackColor = false;
            // 
            // btnRiwayat
            // 
            this.btnRiwayat.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnRiwayat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRiwayat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRiwayat.ForeColor = System.Drawing.Color.DimGray;
            this.btnRiwayat.Location = new System.Drawing.Point(25, 363);
            this.btnRiwayat.Name = "btnRiwayat";
            this.btnRiwayat.Size = new System.Drawing.Size(178, 36);
            this.btnRiwayat.TabIndex = 83;
            this.btnRiwayat.Text = "Riwayat";
            this.btnRiwayat.TextAlign = System.Drawing.ContentAlignment.TopLeft;
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
            this.btnPengembalian.TabIndex = 82;
            this.btnPengembalian.Text = "Pengembalian";
            this.btnPengembalian.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnPengembalian.UseVisualStyleBackColor = false;
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
            this.btnInformasiAlat.TabIndex = 81;
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
            this.btnPeminjaman.Location = new System.Drawing.Point(25, 289);
            this.btnPeminjaman.Name = "btnPeminjaman";
            this.btnPeminjaman.Size = new System.Drawing.Size(178, 36);
            this.btnPeminjaman.TabIndex = 80;
            this.btnPeminjaman.Text = "Peminjaman";
            this.btnPeminjaman.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnPeminjaman.UseVisualStyleBackColor = false;
            // 
            // btnLaporan
            // 
            this.btnLaporan.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnLaporan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLaporan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLaporan.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLaporan.Location = new System.Drawing.Point(25, 400);
            this.btnLaporan.Name = "btnLaporan";
            this.btnLaporan.Size = new System.Drawing.Size(178, 36);
            this.btnLaporan.TabIndex = 79;
            this.btnLaporan.Text = "Laporan";
            this.btnLaporan.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLaporan.UseVisualStyleBackColor = false;
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
            this.btnAdmin.TabIndex = 78;
            this.btnAdmin.Text = "Admin";
            this.btnAdmin.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnAdmin.UseVisualStyleBackColor = false;
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
            this.btnHome.TabIndex = 77;
            this.btnHome.Text = "Home";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnHome.UseVisualStyleBackColor = false;
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
            this.Admin.TabIndex = 76;
            // 
            // FormLaporan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PROJEK_AKHIR.Properties.Resources.FiturLaporan;
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
            this.Controls.Add(this.txtPeminjaman7);
            this.Controls.Add(this.txtPeminjaman30);
            this.Controls.Add(this.txtPengembalian7);
            this.Controls.Add(this.txtPengembalian30);
            this.Controls.Add(this.txtAlatDipinjam);
            this.Controls.Add(this.txtAlatTersedia);
            this.Controls.Add(this.txtJenisAlat);
            this.Controls.Add(this.txtJumlahAdmin);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormLaporan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormLaporan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtJumlahAdmin;
        private System.Windows.Forms.TextBox txtJenisAlat;
        private System.Windows.Forms.TextBox txtAlatTersedia;
        private System.Windows.Forms.TextBox txtAlatDipinjam;
        private System.Windows.Forms.TextBox txtPengembalian30;
        private System.Windows.Forms.TextBox txtPengembalian7;
        private System.Windows.Forms.TextBox txtPeminjaman30;
        private System.Windows.Forms.TextBox txtPeminjaman7;
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