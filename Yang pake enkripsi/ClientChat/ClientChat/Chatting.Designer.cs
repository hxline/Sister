namespace ClientChat
{
    partial class Chatting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Chatting));
            this.radTextMessage = new Telerik.WinControls.UI.RadTextBoxControl();
            this.radListOnline = new Telerik.WinControls.UI.RadListControl();
            this.radButtonSend = new Telerik.WinControls.UI.RadButton();
            this.radListMessages = new System.Windows.Forms.ListBox();
            this.radButtonExit = new Telerik.WinControls.UI.RadButton();
            this.telerikMetroTouchTheme1 = new Telerik.WinControls.Themes.TelerikMetroTouchTheme();
            this.telerikMetroTouchTheme2 = new Telerik.WinControls.Themes.TelerikMetroTouchTheme();
            this.windows7Theme1 = new Telerik.WinControls.Themes.Windows7Theme();
            this.aquaTheme1 = new Telerik.WinControls.Themes.AquaTheme();
            this.desertTheme1 = new Telerik.WinControls.Themes.DesertTheme();
            this.radCheckNotif = new Telerik.WinControls.UI.RadCheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.radTextMessage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radListOnline)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonSend)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckNotif)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radTextMessage
            // 
            this.radTextMessage.Location = new System.Drawing.Point(12, 270);
            this.radTextMessage.Name = "radTextMessage";
            this.radTextMessage.Size = new System.Drawing.Size(421, 20);
            this.radTextMessage.TabIndex = 0;
            this.radTextMessage.ThemeName = "VisualStudio2012Light";
            // 
            // radListOnline
            // 
            this.radListOnline.Location = new System.Drawing.Point(12, 43);
            this.radListOnline.Name = "radListOnline";
            this.radListOnline.Size = new System.Drawing.Size(97, 212);
            this.radListOnline.TabIndex = 0;
            this.radListOnline.Text = "radListControl1";
            this.radListOnline.ThemeName = "VisualStudio2012Light";
            // 
            // radButtonSend
            // 
            this.radButtonSend.Location = new System.Drawing.Point(456, 270);
            this.radButtonSend.Name = "radButtonSend";
            this.radButtonSend.Size = new System.Drawing.Size(84, 20);
            this.radButtonSend.TabIndex = 0;
            this.radButtonSend.Text = "Kirim";
            this.radButtonSend.ThemeName = "VisualStudio2012Light";
            this.radButtonSend.Click += new System.EventHandler(this.radButtonSend_Click);
            // 
            // radListMessages
            // 
            this.radListMessages.FormattingEnabled = true;
            this.radListMessages.Location = new System.Drawing.Point(124, 43);
            this.radListMessages.Name = "radListMessages";
            this.radListMessages.Size = new System.Drawing.Size(388, 212);
            this.radListMessages.TabIndex = 0;
            // 
            // radButtonExit
            // 
            this.radButtonExit.Location = new System.Drawing.Point(547, 12);
            this.radButtonExit.Name = "radButtonExit";
            this.radButtonExit.Size = new System.Drawing.Size(19, 24);
            this.radButtonExit.TabIndex = 1;
            this.radButtonExit.Text = "X";
            this.radButtonExit.ThemeName = "Aqua";
            this.radButtonExit.Click += new System.EventHandler(this.radButtonExit_Click);
            // 
            // radCheckNotif
            // 
            this.radCheckNotif.BackColor = System.Drawing.Color.Transparent;
            this.radCheckNotif.ForeColor = System.Drawing.Color.Linen;
            this.radCheckNotif.Location = new System.Drawing.Point(521, 55);
            this.radCheckNotif.Name = "radCheckNotif";
            this.radCheckNotif.Size = new System.Drawing.Size(45, 18);
            this.radCheckNotif.TabIndex = 3;
            this.radCheckNotif.Text = "Notif";
            // 
            // Chatting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(578, 302);
            this.Controls.Add(this.radCheckNotif);
            this.Controls.Add(this.radButtonExit);
            this.Controls.Add(this.radListMessages);
            this.Controls.Add(this.radButtonSend);
            this.Controls.Add(this.radListOnline);
            this.Controls.Add(this.radTextMessage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Chatting";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chatting";
            this.ThemeName = "ControlDefault";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Chatting_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.radTextMessage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radListOnline)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonSend)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckNotif)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadTextBoxControl radTextMessage;
        private Telerik.WinControls.UI.RadListControl radListOnline;
        private Telerik.WinControls.UI.RadButton radButtonSend;
        private System.Windows.Forms.ListBox radListMessages;
        private Telerik.WinControls.UI.RadButton radButtonExit;
        private Telerik.WinControls.Themes.TelerikMetroTouchTheme telerikMetroTouchTheme1;
        private Telerik.WinControls.Themes.TelerikMetroTouchTheme telerikMetroTouchTheme2;
        private Telerik.WinControls.Themes.Windows7Theme windows7Theme1;
        private Telerik.WinControls.Themes.AquaTheme aquaTheme1;
        private Telerik.WinControls.Themes.DesertTheme desertTheme1;
        private Telerik.WinControls.UI.RadCheckBox radCheckNotif;
    }
}
