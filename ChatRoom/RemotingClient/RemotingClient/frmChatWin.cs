using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using System.Collections;
using RemoteBase;
using System.Media;

namespace RemotingClient
{
    public partial class frmChatWin : Form
    {
        internal Services remoteObj;
        internal int key = 0;
        internal string username;
        ArrayList alOnlineUser = new ArrayList();
        Encrypted encrypted = new Encrypted();
        //int skipCounter = 4;
        private SoundPlayer player;
        private Countdown countdown;

        public frmChatWin()
        {
            InitializeComponent();
            player = new SoundPlayer("notif.wav");
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            SendMessage();
        }

        
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (remoteObj != null)
            {
                //disimpen ke string dulu pesannya
                string tempStr = remoteObj.GetMsgFromSvr(key);
                if (tempStr.Trim().Length > 0)
                {
                    key++;
                    //ubah ke plaintext
                    string plainText = encrypted.decrypt(tempStr);
                    txtAllChat.Text = txtAllChat.Text + "\n" + plainText;
                    if (checkBoxNotif.Checked)
                    {
                        player.Play();
                    }
                }
                else
                //if (skipCounter > 3)
                {
                    //gunain servis getonline
                    ArrayList onlineUser = remoteObj.GetOnlineUser();
                    //ngambil source dari array online
                    lstOnlineUser.DataSource = onlineUser;
                    
                    //skipCounter = 0;
                }
            }
        }        

        private void SendMessage()
        {
            //kalau textchat ada isian dan masih konek
            if (remoteObj != null && txtChatHere.Text.Trim().Length>0)
            {
                if (comboBoxTimer.Text != "")
                {
                    countdown = new Countdown(comboBoxTimer.Text);
                    countdown.ShowDialog();
                }
                //ubah ke chiper text
                string chiperText = encrypted.encrypt(username + " : " + txtChatHere.Text);
                //gunain servis sendmsg
                remoteObj.SendMsgToSvr(chiperText);
                //kosongin txtchat
                txtChatHere.Text = "";
            }
        }
    
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            //masih konek atau engga
            if (remoteObj != null)
            {
                //gunain 
                remoteObj.LeaveChatRoom(username);             
                txtChatHere.Text = "";
            }
            Application.Exit();
        }
    }
}

