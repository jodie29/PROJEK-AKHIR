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
            this.btnDelete = new System.Windows.Forms.PictureBox();
            this.Peminjaman = new System.Windows.Forms.Label();
            this.Pengembalian = new System.Windows.Forms.Label();
            this.Riwayat = new System.Windows.Forms.Label();
            this.Laporan = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Label();
            this.InformasiAlat = new System.Windows.Forms.Label();
            this.Home = new System.Windows.Forms.Label();
            this.Admin = new System.Windows.Forms.Label();
            this.KelompokTani = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(286, 171);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(770, 507);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // LblTanggal
            // 
            this.LblTanggal.AutoSize = true;
            this.LblTanggal.Location = new System.Drawing.Point(375, 135);
            this.LblTanggal.Name = "LblTanggal";
            this.LblTanggal.Size = new System.Drawing.Size(66, 20);
            this.LblTanggal.TabIndex = 1;
            this.LblTanggal.Text = "Tanggal";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(292, 135);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(74, 20);
            this.Label1.TabIndex = 2;
            this.Label1.Text = "Tanggal :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(471, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Jam :";
            // 
            // LblJam
            // 
            this.LblJam.AutoSize = true;
            this.LblJam.Location = new System.Drawing.Point(526, 135);
            this.LblJam.Name = "LblJam";
            this.LblJam.Size = new System.Drawing.Size(39, 20);
            this.LblJam.TabIndex = 4;
            this.LblJam.Text = "Jam";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnDelete
            // 
            this.btnDelete.BackgroundImage = global::PROJEK_AKHIR.Properties.Resources.Bttn_Hapus;
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDelete.Location = new System.Drawing.Point(1002, 132);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(38, 31);
            this.btnDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnDelete.TabIndex = 11;
            this.btnDelete.TabStop = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // Peminjaman
            // 
            this.Peminjaman.AutoSize = true;
            this.Peminjaman.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Peminjaman.Location = new System.Drawing.Point(44, 277);
            this.Peminjaman.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Peminjaman.Name = "Peminjaman";
            this.Peminjaman.Size = new System.Drawing.Size(108, 22);
            this.Peminjaman.TabIndex = 12;
            this.Peminjaman.Text = "Peminjaman";
            // 
            // Pengembalian
            // 
            this.Pengembalian.AutoSize = true;
            this.Pengembalian.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pengembalian.Location = new System.Drawing.Point(44, 312);
            this.Pengembalian.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Pengembalian.Name = "Pengembalian";
            this.Pengembalian.Size = new System.Drawing.Size(124, 22);
            this.Pengembalian.TabIndex = 13;
            this.Pengembalian.Text = "Pengembalian";
            // 
            // Riwayat
            // 
            this.Riwayat.AutoSize = true;
            this.Riwayat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Riwayat.Location = new System.Drawing.Point(44, 348);
            this.Riwayat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Riwayat.Name = "Riwayat";
            this.Riwayat.Size = new System.Drawing.Size(74, 22);
            this.Riwayat.TabIndex = 14;
            this.Riwayat.Text = "Riwayat";
            // 
            // Laporan
            // 
            this.Laporan.AutoSize = true;
            this.Laporan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Laporan.Location = new System.Drawing.Point(44, 385);
            this.Laporan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Laporan.Name = "Laporan";
            this.Laporan.Size = new System.Drawing.Size(76, 22);
            this.Laporan.TabIndex = 15;
            this.Laporan.Text = "Laporan";
            // 
            // Exit
            // 
            this.Exit.AutoSize = true;
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.Exit.Location = new System.Drawing.Point(44, 418);
            this.Exit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(40, 22);
            this.Exit.TabIndex = 16;
            this.Exit.Text = "Exit";
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // InformasiAlat
            // 
            this.InformasiAlat.AutoSize = true;
            this.InformasiAlat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InformasiAlat.Location = new System.Drawing.Point(44, 242);
            this.InformasiAlat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.InformasiAlat.Name = "InformasiAlat";
            this.InformasiAlat.Size = new System.Drawing.Size(118, 22);
            this.InformasiAlat.TabIndex = 17;
            this.InformasiAlat.Text = "Informasi Alat";
            // 
            // Home
            // 
            this.Home.AutoSize = true;
            this.Home.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Home.Location = new System.Drawing.Point(44, 137);
            this.Home.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(57, 22);
            this.Home.TabIndex = 18;
            this.Home.Text = "Home";
            this.Home.Click += new System.EventHandler(this.Home_Click);
            // 
            // Admin
            // 
            this.Admin.AutoSize = true;
            this.Admin.BackColor = System.Drawing.Color.Transparent;
            this.Admin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Admin.Location = new System.Drawing.Point(44, 171);
            this.Admin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Admin.Name = "Admin";
            this.Admin.Size = new System.Drawing.Size(65, 22);
            this.Admin.TabIndex = 19;
            this.Admin.Text = "Admin";
            // 
            // KelompokTani
            // 
            this.KelompokTani.AutoSize = true;
            this.KelompokTani.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KelompokTani.Location = new System.Drawing.Point(44, 208);
            this.KelompokTani.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.KelompokTani.Name = "KelompokTani";
            this.KelompokTani.Size = new System.Drawing.Size(130, 22);
            this.KelompokTani.TabIndex = 20;
            this.KelompokTani.Text = "Kelompok Tani";
            this.KelompokTani.Click += new System.EventHandler(this.KelompokTani_Click);
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PROJEK_AKHIR.Properties.Resources.Fitur_Admin;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1077, 786);
            this.Controls.Add(this.KelompokTani);
            this.Controls.Add(this.Admin);
            this.Controls.Add(this.Home);
            this.Controls.Add(this.InformasiAlat);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Laporan);
            this.Controls.Add(this.Riwayat);
            this.Controls.Add(this.Pengembalian);
            this.Controls.Add(this.Peminjaman);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.LblJam);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.LblTanggal);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAdmin";
            this.Load += new System.EventHandler(this.FormAdmin_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).EndInit();
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
        private System.Windows.Forms.PictureBox btnDelete;
        private System.Windows.Forms.Label Peminjaman;
        private System.Windows.Forms.Label Pengembalian;
        private System.Windows.Forms.Label Riwayat;
        private System.Windows.Forms.Label Laporan;
        private System.Windows.Forms.Label Exit;
        private System.Windows.Forms.Label InformasiAlat;
        private System.Windows.Forms.Label Home;
        private System.Windows.Forms.Label Admin;
        private System.Windows.Forms.Label KelompokTani;
    }
}