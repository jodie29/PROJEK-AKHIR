namespace PROJEK_AKHIR
{
    partial class FromLogin
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
            this.btnlogin = new System.Windows.Forms.Button();
            this.tbusername = new System.Windows.Forms.TextBox();
            this.tbpassword = new System.Windows.Forms.TextBox();
            this.lilaregister = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // btnlogin
            // 
            this.btnlogin.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnlogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogin.ForeColor = System.Drawing.Color.White;
            this.btnlogin.Location = new System.Drawing.Point(28, 259);
            this.btnlogin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(222, 28);
            this.btnlogin.TabIndex = 0;
            this.btnlogin.Text = "Login";
            this.btnlogin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnlogin.UseVisualStyleBackColor = false;
            this.btnlogin.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbusername
            // 
            this.tbusername.Location = new System.Drawing.Point(28, 180);
            this.tbusername.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbusername.Name = "tbusername";
            this.tbusername.Size = new System.Drawing.Size(222, 20);
            this.tbusername.TabIndex = 1;
            // 
            // tbpassword
            // 
            this.tbpassword.Location = new System.Drawing.Point(28, 231);
            this.tbpassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbpassword.Name = "tbpassword";
            this.tbpassword.Size = new System.Drawing.Size(222, 20);
            this.tbpassword.TabIndex = 2;
            // 
            // lilaregister
            // 
            this.lilaregister.AutoSize = true;
            this.lilaregister.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lilaregister.Location = new System.Drawing.Point(25, 296);
            this.lilaregister.Name = "lilaregister";
            this.lilaregister.Size = new System.Drawing.Size(47, 12);
            this.lilaregister.TabIndex = 4;
            this.lilaregister.TabStop = true;
            this.lilaregister.Text = "Registrasi";
            this.lilaregister.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // FromLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PROJEK_AKHIR.Properties.Resources.Login1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(718, 511);
            this.Controls.Add(this.lilaregister);
            this.Controls.Add(this.tbpassword);
            this.Controls.Add(this.tbusername);
            this.Controls.Add(this.btnlogin);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FromLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.TextBox tbusername;
        private System.Windows.Forms.TextBox tbpassword;
        private System.Windows.Forms.LinkLabel lilaregister;
    }
}

