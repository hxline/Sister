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
using System.Text.RegularExpressions;

namespace ClientHostForm
{
    public partial class Pesan : Form
    {
        #region data user
        static BindingList<Members> ConnectedUsers = new BindingList<Members>();
        static BindingList<Members> usersD = new BindingList<Members>();
        #endregion

        private HubConnection connection;
        private IHubProxy hub;
        private string myId;
        private string toId;
        private string reg1 = "-z<zx>x-";
        private string reg2 = "-z<xz>x-";

        public Pesan()
        {
            InitializeComponent();
            #region Koneksi
            string url = @"http://localhost:8080";
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
            var SyncSend = SynchronizationContext.Current;
            var hubmsg = hub.On<string>("messageReceived", (Md) =>
            {
                SyncSend.Post(delegate
                {
                    if (Md != null)
                    {
                        var msgs = Regex.Split(Md, reg1);
                        listPesan.Items.Clear();
                        foreach (var msg in msgs)
                        {
                            var splMsg = Regex.Split(msg, reg2);
                            string pesan = splMsg[0] + " : " + splMsg[1];
                            listPesan.Items.Add(pesan);
                            
                        }

                        int maxList = listPesan.ClientSize.Height / listPesan.ItemHeight;
                        listPesan.TopIndex = Math.Max(listPesan.Items.Count - maxList + 1, 0);
                    }
                }, null);
            });

            #endregion
            hub.Invoke("SendMessageToAll", textUsername.Text, textPesan.Text).Wait();

        }

        public void TestList()
        {
            #region Kirim pesan
            var SyncSend = SynchronizationContext.Current;
            var hubmsg = hub.On<List<UserDetail>>("ListData", (Md) =>
            {
                SyncSend.Post(delegate
                {
                    listPesan.Items.Clear();
                    foreach (var msg in Md)
                    {
                        usersD.Add(new Members(msg.ConnectionId, msg.UserName));
                    }

                    listBox1.DataSource = usersD;
                }, null);
            });

            #endregion
            hub.Invoke("ListTest").Wait();

        }

        public void SendPrivate()
        {
            #region Kirim pesan private

            var Syncpriv = SynchronizationContext.Current;
            hub.On<string>("receivePrivateMessega", (message) =>
            {
                Syncpriv.Post(delegate
                {
                    if (message != null)
                    {
                        var msgs = Regex.Split(message, reg1);
                        listPesan.Items.Clear();
                        foreach (var msg in msgs)
                        {
                            var splMsg = Regex.Split(msg, reg2);
                            string pesan = splMsg[0] + " : " + splMsg[1];
                            listIsiPM.Items.Add(pesan);
                        }

                        int maxList = listPesan.ClientSize.Height / listPesan.ItemHeight;
                        listPesan.TopIndex = Math.Max(listPesan.Items.Count - maxList + 1, 0);
                    }
                }, null);
            });
            #endregion

            hub.Invoke("SendPrivateMessage", textUsername.Text, textPM.Text).Wait();
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
                        var users = Regex.Split(Ud, reg1);
                        foreach (var user in users)
                        {
                            var splUser = Regex.Split(user, reg2);
                            ConnectedUsers.Add(new Members(splUser[1], splUser[0]));
                        }

                        if (Md != null)
                        {
                            var msgs = Regex.Split(Md, reg1);
                            foreach (var msg in msgs)
                            {
                                var splMsg = Regex.Split(msg, reg2);
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
            Send();
            buttonUsername.Enabled = false;
            textUsername.Enabled = false;
            textPesan.Enabled = true;
            buttonKirim.Enabled = true;
        }

        private void listOnline_DoubleClick(object sender, EventArgs e)
        {
            Members m = (Members)listOnline.SelectedItem;
            label1.Text = m.id;
            label2.Text = m.name;
        }

        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            TestList();
        }

    }
}
