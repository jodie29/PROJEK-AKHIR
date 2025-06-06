namespace PROJEK_AKHIR
{
    partial class FormPenggembalian
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
            this.dtGridPengembalian = new System.Windows.Forms.DataGridView();
            this.txtNamaKelompokTani = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTanggalKembali = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnKembalikan = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridPengembalian)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtGridPengembalian
            // 
            this.dtGridPengembalian.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtGridPengembalian.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtGridPengembalian.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridPengembalian.Location = new System.Drawing.Point(291, 188);
            this.dtGridPengembalian.Name = "dtGridPengembalian";
            this.dtGridPengembalian.RowHeadersWidth = 62;
            this.dtGridPengembalian.RowTemplate.Height = 28;
            this.dtGridPengembalian.Size = new System.Drawing.Size(761, 301);
            this.dtGridPengembalian.TabIndex = 0;
            // 
            // txtNamaKelompokTani
            // 
            this.txtNamaKelompokTani.BackColor = System.Drawing.SystemColors.Window;
            this.txtNamaKelompokTani.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNamaKelompokTani.Location = new System.Drawing.Point(524, 518);
            this.txtNamaKelompokTani.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNamaKelompokTani.Name = "txtNamaKelompokTani";
            this.txtNamaKelompokTani.Size = new System.Drawing.Size(240, 26);
            this.txtNamaKelompokTani.TabIndex = 59;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Window;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.label4.Location = new System.Drawing.Point(309, 521);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(202, 20);
            this.label4.TabIndex = 58;
            this.label4.Text = "Nama Peminjam             :";
            // 
            // txtTanggalKembali
            // 
            this.txtTanggalKembali.BackColor = System.Drawing.SystemColors.Window;
            this.txtTanggalKembali.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTanggalKembali.Location = new System.Drawing.Point(524, 563);
            this.txtTanggalKembali.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTanggalKembali.Name = "txtTanggalKembali";
            this.txtTanggalKembali.Size = new System.Drawing.Size(240, 26);
            this.txtTanggalKembali.TabIndex = 61;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.label1.Location = new System.Drawing.Point(309, 566);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 20);
            this.label1.TabIndex = 60;
            this.label1.Text = "NIK Peminjam                 :";
            // 
            // txtStatus
            // 
            this.txtStatus.BackColor = System.Drawing.SystemColors.Window;
            this.txtStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStatus.Location = new System.Drawing.Point(524, 611);
            this.txtStatus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(240, 26);
            this.txtStatus.TabIndex = 63;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Window;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.label2.Location = new System.Drawing.Point(309, 614);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 20);
            this.label2.TabIndex = 62;
            this.label2.Text = "NIK Peminjam                 :";
            // 
            // btnKembalikan
            // 
            this.btnKembalikan.Location = new System.Drawing.Point(883, 628);
            this.btnKembalikan.Name = "btnKembalikan";
            this.btnKembalikan.Size = new System.Drawing.Size(141, 35);
            this.btnKembalikan.TabIndex = 64;
            this.btnKembalikan.Text = "Kembalikan";
            this.btnKembalikan.UseVisualStyleBackColor = true;
            this.btnKembalikan.Click += new System.EventHandler(this.btnKembalikan_Click_1);
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.SystemColors.Window;
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(291, 135);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(259, 32);
            this.txtSearch.TabIndex = 66;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Window;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.label3.Location = new System.Drawing.Point(309, 142);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 20);
            this.label3.TabIndex = 65;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.BackgroundImage = global::PROJEK_AKHIR.Properties.Resources.Vector;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(518, 138);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.TabIndex = 67;
            this.pictureBox1.TabStop = false;
            // 
            // FormPenggembalian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PROJEK_AKHIR.Properties.Resources.Pengembalian;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1077, 786);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnKembalikan);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTanggalKembali);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNamaKelompokTani);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtGridPengembalian);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPenggembalian";
            this.Text = "FormPenggembalian";
            ((System.ComponentModel.ISupportInitialize)(this.dtGridPengembalian)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtGridPengembalian;
        private System.Windows.Forms.TextBox txtNamaKelompokTani;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTanggalKembali;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnKembalikan;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}