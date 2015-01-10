using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.AspNet.SignalR.Client;
using System.Threading;
using ClientHostForm.Models;

namespace ClientHostForm
{
    public partial class Pesan : Form
    {
        #region data user
        static BindingList<Members> ConnectedUsers = new BindingList<Members>();
        static BindingList<string> MessageDetail = new BindingList<string>();
        #endregion

        private HubConnection connection;
        private IHubProxy hub;
        private string myId;

        public Pesan()
        {
            InitializeComponent();
            #region Koneksi
            string url = @"http://192.168.10.62:5000";
            connection = new HubConnection(url);
            hub = connection.CreateHubProxy("MyHub");
            var SyncHub = SynchronizationContext.Current;

            #region Hapus daftar user offline
            hub.On<string, string>("onUserDisconnected", (id, username) =>
            {
                this.Invoke((Action)(() =>
                {
                    SyncHub.Post(_ =>
                    {
                        var item = ConnectedUsers.FirstOrDefault(x => x.id == id);
                        if (item != null)
                        {
                            ConnectedUsers.Remove(item);
                            listOnline.DataSource = ConnectedUsers;
                        }
                    }, null);
                }
                ));
            });
            #endregion

            connection.Start().Wait();
            #endregion
        }

        public void Send()
        {
            #region Kirim pesan
            var SyncSend= SynchronizationContext.Current;
            var hubmsg= hub.On<string, string>("messageReceived", (username,message) =>
                {
                    SyncSend.Post(delegate
                        {
                            string pesan = username + " : " + message;
                            listPesan.Items.Add(pesan);
                        }, null);
                });
            
            #endregion

            hub.Invoke("SendMessageToAll", textUsername.Text, textPesan.Text).Wait();
            hubmsg.Dispose();
        }

        public void SendPrivate()
        {
            #region Kirim pesan private

            var Syncpriv = SynchronizationContext.Current;
            var hubmsg = hub.On<string, string>("serndPrivateMessega", (username, message) =>
            {
                Syncpriv.Post(delegate
                {
                    string pesan = username + " : " + message;
                    listPesan.Items.Add(pesan);
                }, null);
            });
            #endregion

            hub.Invoke("SendMessageToAll", textUsername.Text, textPesan.Text).Wait();
            hubmsg.Dispose();
        }

        public void Load_user()
        {
            var Sync = SynchronizationContext.Current;

            #region User baru online
            var newUser = hub.On<string,string>("onNewUserConnected", (id, username) =>
            {
                Sync.Post(delegate
                {
                    ConnectedUsers.Add(new Members(username, id));

                    listOnline.DataSource = ConnectedUsers;

                }, null);
            });
            #endregion

            #region load daftar user
            var connect = hub.On<string, string, string>("onConnected", (id,Ud,Md) =>
            {
                Sync.Post(delegate
                {
                    myId = id;
                    if (Ud != null)
                    {
                        var users = Ud.Split('?');
                        foreach (var user in users)
                        {
                            var splUser = user.Split('|');
                            ConnectedUsers.Add(new Members(splUser[1], splUser[0]));
                        }

                        if (Md != null)
                        {
                            var msgs = Md.Split('?');
                            foreach (var msg in msgs)
                            {
                                var splMsg = msg.Split('|');
                                string pesan = splMsg[0] + " : " + splMsg[1];
                                listPesan.Items.Add(pesan);
                            }
                        }

                        listOnline.DataSource = ConnectedUsers;
                    }
                }, null);
            });
            #endregion

            hub.Invoke("Connect", textUsername.Text).Wait();
        }

        #region Control
        private void buttonKirim_Click(object sender, EventArgs e)
        {
            Send();
        }

        private void buttonUsername_Click(object sender, EventArgs e)
        {
            Load_user();
            
            buttonUsername.Enabled = false;
            textUsername.Enabled = false;
        }

        private void listOnline_DoubleClick(object sender, EventArgs e)
        {
            Members m = (Members)listOnline.SelectedItem;
            label1.Text = m.id;
            label2.Text = m.name;
        }

        #endregion

    }
}
