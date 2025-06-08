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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAlat)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNamaAlat
            // 
            this.txtNamaAlat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNamaAlat.Location = new System.Drawing.Point(560, 294);
            this.txtNamaAlat.Name = "txtNamaAlat";
            this.txtNamaAlat.Size = new System.Drawing.Size(310, 33);
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
            this.txtJumlahAlat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJumlahAlat.Location = new System.Drawing.Point(560, 403);
            this.txtJumlahAlat.Name = "txtJumlahAlat";
            this.txtJumlahAlat.Size = new System.Drawing.Size(310, 33);
            this.txtJumlahAlat.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(558, 258);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 30);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nama Alat";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(561, 369);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 30);
            this.label2.TabIndex = 4;
            this.label2.Text = "Jumlah";
            // 
            // btnPilihGambar
            // 
            this.btnPilihGambar.BackColor = System.Drawing.Color.ForestGreen;
            this.btnPilihGambar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPilihGambar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPilihGambar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPilihGambar.Location = new System.Drawing.Point(118, 478);
            this.btnPilihGambar.Name = "btnPilihGambar";
            this.btnPilihGambar.Size = new System.Drawing.Size(298, 69);
            this.btnPilihGambar.TabIndex = 5;
            this.btnPilihGambar.Text = "Pilih Gambar";
            this.btnPilihGambar.UseVisualStyleBackColor = false;
            this.btnPilihGambar.Click += new System.EventHandler(this.btnPilihGambar_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(567, 486);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 45);
            this.button2.TabIndex = 6;
            this.button2.Text = "Batal";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnTambah
            // 
            this.btnTambah.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnTambah.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnTambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTambah.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTambah.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTambah.Location = new System.Drawing.Point(724, 486);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(130, 45);
            this.btnTambah.TabIndex = 7;
            this.btnTambah.Text = "Tambah";
            this.btnTambah.UseVisualStyleBackColor = false;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // pictureBoxAlat
            // 
            this.pictureBoxAlat.BackColor = System.Drawing.Color.White;
            this.pictureBoxAlat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxAlat.Location = new System.Drawing.Point(148, 205);
            this.pictureBoxAlat.Name = "pictureBoxAlat";
            this.pictureBoxAlat.Size = new System.Drawing.Size(244, 251);
            this.pictureBoxAlat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxAlat.TabIndex = 8;
            this.pictureBoxAlat.TabStop = false;
            // 
            // FormTambahAlat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PROJEK_AKHIR.Properties.Resources.Informasi_Alat__5_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1077, 786);
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
    }
}