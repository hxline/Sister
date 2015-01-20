namespace enkripsiee
{
    partial class Form1
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
            this.buttonEnkripsi = new System.Windows.Forms.Button();
            this.buttonDeskripsi = new System.Windows.Forms.Button();
            this.textBoxKataAwal = new System.Windows.Forms.TextBox();
            this.textBoxEnkripsi = new System.Windows.Forms.TextBox();
            this.textBoxDeskrip = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonEnkripsi
            // 
            this.buttonEnkripsi.Location = new System.Drawing.Point(59, 66);
            this.buttonEnkripsi.Name = "buttonEnkripsi";
            this.buttonEnkripsi.Size = new System.Drawing.Size(75, 23);
            this.buttonEnkripsi.TabIndex = 0;
            this.buttonEnkripsi.Text = "Enkripsi";
            this.buttonEnkripsi.UseVisualStyleBackColor = true;
            this.buttonEnkripsi.Click += new System.EventHandler(this.buttonEnkripsi_Click);
            // 
            // buttonDeskripsi
            // 
            this.buttonDeskripsi.Location = new System.Drawing.Point(574, 54);
            this.buttonDeskripsi.Name = "buttonDeskripsi";
            this.buttonDeskripsi.Size = new System.Drawing.Size(75, 23);
            this.buttonDeskripsi.TabIndex = 1;
            this.buttonDeskripsi.Text = "Deskripsi";
            this.buttonDeskripsi.UseVisualStyleBackColor = true;
            this.buttonDeskripsi.Click += new System.EventHandler(this.buttonDeskripsi_Click);
            // 
            // textBoxKataAwal
            // 
            this.textBoxKataAwal.Location = new System.Drawing.Point(12, 134);
            this.textBoxKataAwal.Name = "textBoxKataAwal";
            this.textBoxKataAwal.Size = new System.Drawing.Size(198, 20);
            this.textBoxKataAwal.TabIndex = 2;
            // 
            // textBoxEnkripsi
            // 
            this.textBoxEnkripsi.Location = new System.Drawing.Point(312, 134);
            this.textBoxEnkripsi.Name = "textBoxEnkripsi";
            this.textBoxEnkripsi.Size = new System.Drawing.Size(100, 20);
            this.textBoxEnkripsi.TabIndex = 3;
            // 
            // textBoxDeskrip
            // 
            this.textBoxDeskrip.Location = new System.Drawing.Point(490, 134);
            this.textBoxDeskrip.Name = "textBoxDeskrip";
            this.textBoxDeskrip.Size = new System.Drawing.Size(215, 20);
            this.textBoxDeskrip.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 262);
            this.Controls.Add(this.textBoxDeskrip);
            this.Controls.Add(this.textBoxEnkripsi);
            this.Controls.Add(this.textBoxKataAwal);
            this.Controls.Add(this.buttonDeskripsi);
            this.Controls.Add(this.buttonEnkripsi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonEnkripsi;
        private System.Windows.Forms.Button buttonDeskripsi;
        private System.Windows.Forms.TextBox textBoxKataAwal;
        private System.Windows.Forms.TextBox textBoxEnkripsi;
        private System.Windows.Forms.TextBox textBoxDeskrip;
    }
}

