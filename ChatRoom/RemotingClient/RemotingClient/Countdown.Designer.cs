namespace RemotingClient
{
    partial class Countdown
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
            this.labelCount = new System.Windows.Forms.Label();
            this.timerCount = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // labelCount
            // 
            this.labelCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelCount.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCount.Location = new System.Drawing.Point(0, 0);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(83, 43);
            this.labelCount.TabIndex = 0;
            this.labelCount.Text = "Count";
            this.labelCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timerCount
            // 
            this.timerCount.Interval = 1000;
            this.timerCount.Tick += new System.EventHandler(this.timerCount_Tick);
            // 
            // Countdown
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(83, 43);
            this.Controls.Add(this.labelCount);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Countdown";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Countdown";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelCount;
        private System.Windows.Forms.Timer timerCount;
    }
}