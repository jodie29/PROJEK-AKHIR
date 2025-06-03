namespace PROJEK_AKHIR
{
    partial class FormEditAlat
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
            this.pictureBoxAlat = new System.Windows.Forms.PictureBox();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnPilihGambar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtJumlahAlat = new System.Windows.Forms.TextBox();
            this.txtNamaAlat = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAlat)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxAlat
            // 
            this.pictureBoxAlat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxAlat.Location = new System.Drawing.Point(589, 288);
            this.pictureBoxAlat.Name = "pictureBoxAlat";
            this.pictureBoxAlat.Size = new System.Drawing.Size(136, 106);
            this.pictureBoxAlat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxAlat.TabIndex = 16;
            this.pictureBoxAlat.TabStop = false;
            // 
            // btnSimpan
            // 
            this.btnSimpan.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnSimpan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSimpan.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSimpan.Location = new System.Drawing.Point(893, 621);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(124, 37);
            this.btnSimpan.TabIndex = 15;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = false;
            this.btnSimpan.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(783, 621);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 37);
            this.button2.TabIndex = 14;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnPilihGambar
            // 
            this.btnPilihGambar.BackColor = System.Drawing.Color.ForestGreen;
            this.btnPilihGambar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPilihGambar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPilihGambar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPilihGambar.Location = new System.Drawing.Point(589, 400);
            this.btnPilihGambar.Name = "btnPilihGambar";
            this.btnPilihGambar.Size = new System.Drawing.Size(136, 33);
            this.btnPilihGambar.TabIndex = 13;
            this.btnPilihGambar.Text = "Pilih Gambar";
            this.btnPilihGambar.UseVisualStyleBackColor = false;
            this.btnPilihGambar.Click += new System.EventHandler(this.btnPilihGambar_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(411, 499);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Jumlah";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(411, 441);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Nama Alat";
            // 
            // txtJumlahAlat
            // 
            this.txtJumlahAlat.Location = new System.Drawing.Point(415, 525);
            this.txtJumlahAlat.Name = "txtJumlahAlat";
            this.txtJumlahAlat.Size = new System.Drawing.Size(472, 26);
            this.txtJumlahAlat.TabIndex = 10;
            // 
            // txtNamaAlat
            // 
            this.txtNamaAlat.Location = new System.Drawing.Point(415, 468);
            this.txtNamaAlat.Name = "txtNamaAlat";
            this.txtNamaAlat.Size = new System.Drawing.Size(472, 26);
            this.txtNamaAlat.TabIndex = 9;
            // 
            // FormEditAlat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PROJEK_AKHIR.Properties.Resources.Tambah_Informasi_Alat;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1077, 786);
            this.Controls.Add(this.pictureBoxAlat);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnPilihGambar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtJumlahAlat);
            this.Controls.Add(this.txtNamaAlat);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormEditAlat";
            this.Text = "FormEditAlat";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAlat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxAlat;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnPilihGambar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtJumlahAlat;
        private System.Windows.Forms.TextBox txtNamaAlat;
    }
}