namespace ClientHostForm
{
    partial class Pesan
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
            this.textPesan = new System.Windows.Forms.TextBox();
            this.buttonKirim = new System.Windows.Forms.Button();
            this.listPesan = new System.Windows.Forms.ListBox();
            this.listOnline = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textUsername = new System.Windows.Forms.TextBox();
            this.buttonUsername = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listPM = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textPM = new System.Windows.Forms.TextBox();
            this.listIsiPM = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textPesan
            // 
            this.textPesan.Enabled = false;
            this.textPesan.Location = new System.Drawing.Point(12, 72);
            this.textPesan.Name = "textPesan";
            this.textPesan.Size = new System.Drawing.Size(100, 20);
            this.textPesan.TabIndex = 0;
            // 
            // buttonKirim
            // 
            this.buttonKirim.Enabled = false;
            this.buttonKirim.Location = new System.Drawing.Point(118, 69);
            this.buttonKirim.Name = "buttonKirim";
            this.buttonKirim.Size = new System.Drawing.Size(75, 23);
            this.buttonKirim.TabIndex = 1;
            this.buttonKirim.Text = "Kirim";
            this.buttonKirim.UseVisualStyleBackColor = true;
            this.buttonKirim.Click += new System.EventHandler(this.buttonKirim_Click);
            // 
            // listPesan
            // 
            this.listPesan.FormattingEnabled = true;
            this.listPesan.Location = new System.Drawing.Point(12, 246);
            this.listPesan.Name = "listPesan";
            this.listPesan.Size = new System.Drawing.Size(300, 95);
            this.listPesan.TabIndex = 2;
            // 
            // listOnline
            // 
            this.listOnline.FormattingEnabled = true;
            this.listOnline.Location = new System.Drawing.Point(12, 123);
            this.listOnline.Name = "listOnline";
            this.listOnline.Size = new System.Drawing.Size(120, 95);
            this.listOnline.TabIndex = 3;
            this.listOnline.DoubleClick += new System.EventHandler(this.listOnline_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Online";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Pesan";
            // 
            // textUsername
            // 
            this.textUsername.Location = new System.Drawing.Point(12, 23);
            this.textUsername.Name = "textUsername";
            this.textUsername.Size = new System.Drawing.Size(100, 20);
            this.textUsername.TabIndex = 7;
            // 
            // buttonUsername
            // 
            this.buttonUsername.Location = new System.Drawing.Point(121, 23);
            this.buttonUsername.Name = "buttonUsername";
            this.buttonUsername.Size = new System.Drawing.Size(50, 23);
            this.buttonUsername.TabIndex = 8;
            this.buttonUsername.Text = "Masuk";
            this.buttonUsername.UseVisualStyleBackColor = true;
            this.buttonUsername.Click += new System.EventHandler(this.buttonUsername_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "User COC";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Pesan";
            // 
            // listPM
            // 
            this.listPM.FormattingEnabled = true;
            this.listPM.Location = new System.Drawing.Point(388, 25);
            this.listPM.Name = "listPM";
            this.listPM.Size = new System.Drawing.Size(145, 95);
            this.listPM.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(385, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Yang Nge-PM";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(385, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "PM";
            // 
            // textPM
            // 
            this.textPM.Location = new System.Drawing.Point(388, 160);
            this.textPM.Name = "textPM";
            this.textPM.Size = new System.Drawing.Size(100, 20);
            this.textPM.TabIndex = 14;
            // 
            // listIsiPM
            // 
            this.listIsiPM.FormattingEnabled = true;
            this.listIsiPM.Location = new System.Drawing.Point(388, 211);
            this.listIsiPM.Name = "listIsiPM";
            this.listIsiPM.Size = new System.Drawing.Size(260, 95);
            this.listIsiPM.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(494, 157);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(68, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Kirim PM";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(385, 195);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "PM-an";
            // 
            // Pesan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 353);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listIsiPM);
            this.Controls.Add(this.textPM);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listPM);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonUsername);
            this.Controls.Add(this.textUsername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listOnline);
            this.Controls.Add(this.listPesan);
            this.Controls.Add(this.buttonKirim);
            this.Controls.Add(this.textPesan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Pesan";
            this.Text = "Pesan 40B";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textPesan;
        private System.Windows.Forms.Button buttonKirim;
        private System.Windows.Forms.ListBox listPesan;
        private System.Windows.Forms.ListBox listOnline;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textUsername;
        private System.Windows.Forms.Button buttonUsername;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listPM;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textPM;
        private System.Windows.Forms.ListBox listIsiPM;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
    }
}

