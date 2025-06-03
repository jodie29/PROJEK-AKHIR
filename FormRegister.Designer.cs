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
            this.SuspendLayout();
            // 
            // tbnama
            // 
            this.tbnama.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbnama.Cursor = System.Windows.Forms.Cursors.Default;
            this.tbnama.Location = new System.Drawing.Point(56, 235);
            this.tbnama.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbnama.Name = "tbnama";
            this.tbnama.Size = new System.Drawing.Size(298, 19);
            this.tbnama.TabIndex = 13;
            // 
            // tbemail
            // 
            this.tbemail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbemail.Cursor = System.Windows.Forms.Cursors.Default;
            this.tbemail.Location = new System.Drawing.Point(56, 302);
            this.tbemail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbemail.Name = "tbemail";
            this.tbemail.Size = new System.Drawing.Size(298, 19);
            this.tbemail.TabIndex = 14;
            // 
            // tbnohp
            // 
            this.tbnohp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbnohp.Cursor = System.Windows.Forms.Cursors.Default;
            this.tbnohp.Location = new System.Drawing.Point(56, 369);
            this.tbnohp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbnohp.Name = "tbnohp";
            this.tbnohp.Size = new System.Drawing.Size(298, 19);
            this.tbnohp.TabIndex = 15;
            // 
            // tbusername
            // 
            this.tbusername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbusername.Cursor = System.Windows.Forms.Cursors.Default;
            this.tbusername.Location = new System.Drawing.Point(56, 440);
            this.tbusername.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbusername.Name = "tbusername";
            this.tbusername.Size = new System.Drawing.Size(298, 19);
            this.tbusername.TabIndex = 16;
            // 
            // tbpw
            // 
            this.tbpw.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbpw.Cursor = System.Windows.Forms.Cursors.Default;
            this.tbpw.Location = new System.Drawing.Point(56, 506);
            this.tbpw.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbpw.Name = "tbpw";
            this.tbpw.Size = new System.Drawing.Size(298, 19);
            this.tbpw.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(42, 563);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(333, 43);
            this.button1.TabIndex = 18;
            this.button1.Text = "Register";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PROJEK_AKHIR.Properties.Resources.Register;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1077, 786);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbpw);
            this.Controls.Add(this.tbusername);
            this.Controls.Add(this.tbnohp);
            this.Controls.Add(this.tbemail);
            this.Controls.Add(this.tbnama);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
    }
}