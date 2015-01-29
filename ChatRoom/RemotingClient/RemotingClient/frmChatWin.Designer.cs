namespace RemotingClient
{
    partial class frmChatWin
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
            this.btnSend = new System.Windows.Forms.Button();
            this.txtChatHere = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtAllChat = new System.Windows.Forms.RichTextBox();
            this.lstOnlineUser = new System.Windows.Forms.ListBox();
            this.checkBoxNotif = new System.Windows.Forms.CheckBox();
            this.comboBoxTimer = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(562, 320);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(45, 23);
            this.btnSend.TabIndex = 0;
            this.btnSend.Text = "Kirim";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtChatHere
            // 
            this.txtChatHere.Location = new System.Drawing.Point(5, 322);
            this.txtChatHere.Name = "txtChatHere";
            this.txtChatHere.Size = new System.Drawing.Size(542, 20);
            this.txtChatHere.TabIndex = 4;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txtAllChat
            // 
            this.txtAllChat.AutoWordSelection = true;
            this.txtAllChat.BackColor = System.Drawing.SystemColors.Window;
            this.txtAllChat.Location = new System.Drawing.Point(141, 11);
            this.txtAllChat.Name = "txtAllChat";
            this.txtAllChat.ReadOnly = true;
            this.txtAllChat.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.txtAllChat.Size = new System.Drawing.Size(466, 290);
            this.txtAllChat.TabIndex = 7;
            this.txtAllChat.Text = "";
            // 
            // lstOnlineUser
            // 
            this.lstOnlineUser.FormattingEnabled = true;
            this.lstOnlineUser.Location = new System.Drawing.Point(5, 11);
            this.lstOnlineUser.Name = "lstOnlineUser";
            this.lstOnlineUser.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lstOnlineUser.Size = new System.Drawing.Size(118, 290);
            this.lstOnlineUser.TabIndex = 8;
            // 
            // checkBoxNotif
            // 
            this.checkBoxNotif.AutoSize = true;
            this.checkBoxNotif.Location = new System.Drawing.Point(618, 13);
            this.checkBoxNotif.Name = "checkBoxNotif";
            this.checkBoxNotif.Size = new System.Drawing.Size(48, 17);
            this.checkBoxNotif.TabIndex = 9;
            this.checkBoxNotif.Text = "Notif";
            this.checkBoxNotif.UseVisualStyleBackColor = true;
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
            "900",
            "1800",
            "3600"});
            this.comboBoxTimer.Location = new System.Drawing.Point(617, 56);
            this.comboBoxTimer.Name = "comboBoxTimer";
            this.comboBoxTimer.Size = new System.Drawing.Size(48, 21);
            this.comboBoxTimer.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(616, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Timer";
            // 
            // frmChatWin
            // 
            this.AcceptButton = this.btnSend;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 355);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxTimer);
            this.Controls.Add(this.checkBoxNotif);
            this.Controls.Add(this.lstOnlineUser);
            this.Controls.Add(this.txtAllChat);
            this.Controls.Add(this.txtChatHere);
            this.Controls.Add(this.btnSend);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "frmChatWin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chat client";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txtChatHere;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.RichTextBox txtAllChat;
        private System.Windows.Forms.ListBox lstOnlineUser;
        private System.Windows.Forms.CheckBox checkBoxNotif;
        private System.Windows.Forms.ComboBox comboBoxTimer;
        private System.Windows.Forms.Label label1;
    }
}

