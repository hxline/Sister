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

namespace RemotingClient
{
    public partial class frmLogin : Form
    {
        TcpChannel tcp;        
        ArrayList alOnlineUser = new ArrayList();
        frmChatWin objChatWin;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnJoin_Click(object sender, EventArgs e)
        {
            //masuk ke chat room
            JoinToChatRoom();
        }
        private void JoinToChatRoom()
        {
            if (tcp == null && txtName.Text.Trim().Length != 0)
            {
                //buat channel untuk kounikasi sama remoteobject
                tcp = new TcpChannel();
                ChannelServices.RegisterChannel(tcp,false);

                //membuat instance si remote object
                objChatWin = new frmChatWin();
                objChatWin.remoteObj = (Services)Activator.GetObject(typeof(RemoteBase.Services), txtServerAdd.Text);

                //gunain service joinchat
                if (!objChatWin.remoteObj.JoinToChatRoom(txtName.Text))
                {
                    MessageBox.Show(txtName.Text+ " nama sudah ada.");
                    //unregister channel kalo nama udh ada
                    ChannelServices.UnregisterChannel(tcp);
                    tcp = null;
                    objChatWin.Dispose();
                    return;
                }

                objChatWin.key = objChatWin.remoteObj.CurrentKeyNo();
                
                objChatWin.username= txtName.Text;

                this.Hide();
                objChatWin.Show();
                
            }
        }
    }
}