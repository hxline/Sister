namespace ClientHostForm
{
    partial class Pesan_Private
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
            this.textBoxPesan = new System.Windows.Forms.TextBox();
            this.buttonKirim = new System.Windows.Forms.Button();
            this.listBoxPesan = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // textBoxPesan
            // 
            this.textBoxPesan.Location = new System.Drawing.Point(30, 28);
            this.textBoxPesan.Name = "textBoxPesan";
            this.textBoxPesan.Size = new System.Drawing.Size(100, 20);
            this.textBoxPesan.TabIndex = 0;
            // 
            // buttonKirim
            // 
            this.buttonKirim.Location = new System.Drawing.Point(150, 26);
            this.buttonKirim.Name = "buttonKirim";
            this.buttonKirim.Size = new System.Drawing.Size(75, 23);
            this.buttonKirim.TabIndex = 1;
            this.buttonKirim.Text = "Kirim";
            this.buttonKirim.UseVisualStyleBackColor = true;
            // 
            // listBoxPesan
            // 
            this.listBoxPesan.FormattingEnabled = true;
            this.listBoxPesan.Location = new System.Drawing.Point(8, 86);
            this.listBoxPesan.Name = "listBoxPesan";
            this.listBoxPesan.Size = new System.Drawing.Size(264, 160);
            this.listBoxPesan.TabIndex = 2;
            // 
            // Pesan_Private
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.listBoxPesan);
            this.Controls.Add(this.buttonKirim);
            this.Controls.Add(this.textBoxPesan);
            this.Name = "Pesan_Private";
            this.Text = "Pesan Private";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxPesan;
        private System.Windows.Forms.Button buttonKirim;
        private System.Windows.Forms.ListBox listBoxPesan;
    }
}