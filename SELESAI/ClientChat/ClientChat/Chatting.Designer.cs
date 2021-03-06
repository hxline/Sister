﻿namespace ClientChat
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Chatting));
            this.radTextMessage = new Telerik.WinControls.UI.RadTextBoxControl();
            this.radListOnline = new Telerik.WinControls.UI.RadListControl();
            this.radButtonSend = new Telerik.WinControls.UI.RadButton();
            this.radListMessages = new System.Windows.Forms.ListBox();
            this.radButtonExit = new Telerik.WinControls.UI.RadButton();
            this.aquaTheme1 = new Telerik.WinControls.Themes.AquaTheme();
            this.radCheckNotif = new Telerik.WinControls.UI.RadCheckBox();
            this.radButtonSlide = new Telerik.WinControls.UI.RadButton();
            this.timerSlide = new System.Windows.Forms.Timer(this.components);
            this.office2013DarkTheme1 = new Telerik.WinControls.Themes.Office2013DarkTheme();
            this.timerSlideLeft = new System.Windows.Forms.Timer(this.components);
            this.labelUsername = new System.Windows.Forms.Label();
            this.labelKeyCount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxTimer = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.radTextMessage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radListOnline)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonSend)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckNotif)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonSlide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radTextMessage
            // 
            this.radTextMessage.Location = new System.Drawing.Point(8, 269);
            this.radTextMessage.MaxLength = 47;
            this.radTextMessage.Name = "radTextMessage";
            this.radTextMessage.Size = new System.Drawing.Size(311, 20);
            this.radTextMessage.TabIndex = 0;
            this.radTextMessage.ThemeName = "Office2013Dark";
            this.radTextMessage.KeyDown += new System.Windows.Forms.KeyEventHandler(this.radTextMessage_KeyDown);
            this.radTextMessage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.radTextMessage_KeyPress);
            // 
            // radListOnline
            // 
            this.radListOnline.Location = new System.Drawing.Point(463, 42);
            this.radListOnline.Name = "radListOnline";
            this.radListOnline.Size = new System.Drawing.Size(97, 212);
            this.radListOnline.TabIndex = 0;
            this.radListOnline.Text = "radListControl1";
            this.radListOnline.ThemeName = "Office2013Dark";
            // 
            // radButtonSend
            // 
            this.radButtonSend.Location = new System.Drawing.Point(347, 269);
            this.radButtonSend.Name = "radButtonSend";
            this.radButtonSend.Size = new System.Drawing.Size(46, 20);
            this.radButtonSend.TabIndex = 0;
            this.radButtonSend.Text = "Kirim";
            this.radButtonSend.ThemeName = "Office2013Dark";
            this.radButtonSend.Click += new System.EventHandler(this.radButtonSend_Click);
            // 
            // radListMessages
            // 
            this.radListMessages.FormattingEnabled = true;
            this.radListMessages.Location = new System.Drawing.Point(6, 42);
            this.radListMessages.Name = "radListMessages";
            this.radListMessages.Size = new System.Drawing.Size(379, 212);
            this.radListMessages.TabIndex = 0;
            // 
            // radButtonExit
            // 
            this.radButtonExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radButtonExit.Location = new System.Drawing.Point(437, 12);
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
            this.radCheckNotif.Location = new System.Drawing.Point(388, 42);
            this.radCheckNotif.Name = "radCheckNotif";
            this.radCheckNotif.Size = new System.Drawing.Size(45, 18);
            this.radCheckNotif.TabIndex = 3;
            this.radCheckNotif.Text = "Notif";
            // 
            // radButtonSlide
            // 
            this.radButtonSlide.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radButtonSlide.BackColor = System.Drawing.Color.Transparent;
            this.radButtonSlide.Font = new System.Drawing.Font("Verdana", 12F);
            this.radButtonSlide.Location = new System.Drawing.Point(437, 130);
            this.radButtonSlide.Name = "radButtonSlide";
            this.radButtonSlide.Size = new System.Drawing.Size(19, 54);
            this.radButtonSlide.TabIndex = 2;
            this.radButtonSlide.Text = ">";
            this.radButtonSlide.ThemeName = "Aqua";
            this.radButtonSlide.Click += new System.EventHandler(this.radButtonSlide_Click);
            // 
            // timerSlide
            // 
            this.timerSlide.Interval = 10;
            this.timerSlide.Tick += new System.EventHandler(this.timerSlide_Tick);
            // 
            // timerSlideLeft
            // 
            this.timerSlideLeft.Interval = 10;
            this.timerSlideLeft.Tick += new System.EventHandler(this.timerSlideLeft_Tick);
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.BackColor = System.Drawing.Color.Transparent;
            this.labelUsername.Font = new System.Drawing.Font("Segoe Print", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsername.ForeColor = System.Drawing.Color.White;
            this.labelUsername.Location = new System.Drawing.Point(199, 9);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(88, 26);
            this.labelUsername.TabIndex = 4;
            this.labelUsername.Text = "Username";
            // 
            // labelKeyCount
            // 
            this.labelKeyCount.AutoSize = true;
            this.labelKeyCount.BackColor = System.Drawing.Color.Black;
            this.labelKeyCount.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKeyCount.ForeColor = System.Drawing.Color.White;
            this.labelKeyCount.Location = new System.Drawing.Point(319, 269);
            this.labelKeyCount.Name = "labelKeyCount";
            this.labelKeyCount.Size = new System.Drawing.Size(28, 21);
            this.labelKeyCount.TabIndex = 5;
            this.labelKeyCount.Text = "47";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(139, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 26);
            this.label1.TabIndex = 6;
            this.label1.Text = "Clasher";
            // 
            // comboBoxTimer
            // 
            this.comboBoxTimer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTimer.FormattingEnabled = true;
            this.comboBoxTimer.Items.AddRange(new object[] {
            "0",
            "5",
            "30",
            "60",
            "180",
            "900",
            "1800",
            "3600"});
            this.comboBoxTimer.Location = new System.Drawing.Point(388, 85);
            this.comboBoxTimer.Name = "comboBoxTimer";
            this.comboBoxTimer.Size = new System.Drawing.Size(57, 21);
            this.comboBoxTimer.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(385, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Timer (detik)";
            // 
            // Chatting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(460, 301);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxTimer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelKeyCount);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.radButtonSlide);
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
            ((System.ComponentModel.ISupportInitialize)(this.radButtonSlide)).EndInit();
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
        private Telerik.WinControls.Themes.AquaTheme aquaTheme1;
        private Telerik.WinControls.UI.RadCheckBox radCheckNotif;
        private Telerik.WinControls.UI.RadButton radButtonSlide;
        private System.Windows.Forms.Timer timerSlide;
        private Telerik.WinControls.Themes.Office2013DarkTheme office2013DarkTheme1;
        private System.Windows.Forms.Timer timerSlideLeft;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label labelKeyCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxTimer;
        private System.Windows.Forms.Label label2;
    }
}
