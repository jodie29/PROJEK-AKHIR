namespace PROJEK_AKHIR
{
    partial class FormRegister
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
            this.tbnama = new System.Windows.Forms.TextBox();
            this.tbemail = new System.Windows.Forms.TextBox();
            this.tbnohp = new System.Windows.Forms.TextBox();
            this.tbusername = new System.Windows.Forms.TextBox();
            this.tbpw = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbnama
            // 
            this.tbnama.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbnama.Cursor = System.Windows.Forms.Cursors.Default;
            this.tbnama.Location = new System.Drawing.Point(37, 153);
            this.tbnama.Name = "tbnama";
            this.tbnama.Size = new System.Drawing.Size(199, 13);
            this.tbnama.TabIndex = 13;
            // 
            // tbemail
            // 
            this.tbemail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbemail.Cursor = System.Windows.Forms.Cursors.Default;
            this.tbemail.Location = new System.Drawing.Point(37, 196);
            this.tbemail.Name = "tbemail";
            this.tbemail.Size = new System.Drawing.Size(199, 13);
            this.tbemail.TabIndex = 14;
            // 
            // tbnohp
            // 
            this.tbnohp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbnohp.Cursor = System.Windows.Forms.Cursors.Default;
            this.tbnohp.Location = new System.Drawing.Point(37, 240);
            this.tbnohp.Name = "tbnohp";
            this.tbnohp.Size = new System.Drawing.Size(199, 13);
            this.tbnohp.TabIndex = 15;
            // 
            // tbusername
            // 
            this.tbusername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbusername.Cursor = System.Windows.Forms.Cursors.Default;
            this.tbusername.Location = new System.Drawing.Point(37, 286);
            this.tbusername.Name = "tbusername";
            this.tbusername.Size = new System.Drawing.Size(199, 13);
            this.tbusername.TabIndex = 16;
            // 
            // tbpw
            // 
            this.tbpw.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbpw.Cursor = System.Windows.Forms.Cursors.Default;
            this.tbpw.Location = new System.Drawing.Point(37, 329);
            this.tbpw.Name = "tbpw";
            this.tbpw.Size = new System.Drawing.Size(199, 13);
            this.tbpw.TabIndex = 17;
            this.tbpw.TextChanged += new System.EventHandler(this.tbpw_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.button1.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(28, 366);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(222, 28);
            this.button1.TabIndex = 18;
            this.button1.Text = "Register";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightBlue;
            this.button2.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(28, 389);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(222, 28);
            this.button2.TabIndex = 19;
            this.button2.Text = "Batal";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FormRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PROJEK_AKHIR.Properties.Resources.Register;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(718, 511);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbpw);
            this.Controls.Add(this.tbusername);
            this.Controls.Add(this.tbnohp);
            this.Controls.Add(this.tbemail);
            this.Controls.Add(this.tbnama);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormRegister";
            this.Load += new System.EventHandler(this.FormRegister_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbnama;
        private System.Windows.Forms.TextBox tbemail;
        private System.Windows.Forms.TextBox tbnohp;
        private System.Windows.Forms.TextBox tbusername;
        private System.Windows.Forms.TextBox tbpw;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}