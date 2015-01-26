using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Microsoft.AspNet.SignalR.Client;
using System.Threading;
using ClientChat.Models;
using System.Text.RegularExpressions;
using System.IO;
using System.Runtime.InteropServices;
using System.Media;

namespace ClientChat
{
    public partial class Chatting : Telerik.WinControls.UI.RadForm
    {
        #region drag
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        #endregion

        #region enkripsi
        private Encrypted encrypted = new Encrypted();
        #endregion

        #region data user

        static BindingList<Members> ConnectedUsers = new BindingList<Members>();
        static BindingList<MessageDetail> messageDetail = new BindingList<MessageDetail>();

        #endregion

        #region Input
        private int KeyCount = 47;
        private bool Backspace;
        #endregion

        private HubConnection connection;
        private IHubProxy hub;
        private string myId;
        private string reg1 = "-z<zx>x-";
        private string reg2 = "-z<xz>x-";
        private SoundPlayer player;
        private SoundPlayer player2;
        public string Un { get; set; }

        public Chatting(string loginname)
        {
            InitializeComponent();
            player = new SoundPlayer("notif.wav");
            player2 = new SoundPlayer("online.wav");
            Un = loginname;
            labelUsername.Text = Un;
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
                            radListOnline.DataSource = ConnectedUsers;
                        }
                    }, null);
                }
                ));
            });
            #endregion
            try
            {
                connection.Start().Wait();
                #region Load data saat online
                Load_user();
                Send();
                #endregion
            }
            catch
            {
                MessageBox.Show("Tidak bisa terhubung ke server","Gagal",MessageBoxButtons.OK,MessageBoxIcon.Error);
                Application.Exit();
            }
            #endregion
        }

        public void Send()
        {
            #region Kirim pesan
            var SyncSend = SynchronizationContext.Current;
            try
            {
                hub.On<List<MessageDetail>>("messageReceived", (Md) =>
                {
                    SyncSend.Post(delegate
                    {
                        if (Md != null)
                        {
                            messageDetail.Clear();
                            foreach (var msg in Md)
                            {
                                string chipertext = encrypted.decrypt(msg.Message);
                                messageDetail.Add(new MessageDetail(msg.UserName, chipertext));
                            }

                            radListMessages.DataSource = messageDetail;

                            int maxList = radListMessages.ClientSize.Height / radListMessages.ItemHeight;
                            radListMessages.TopIndex = Math.Max(radListMessages.Items.Count - maxList + 1, 0);

                            
                        }
                    }, null);
                });

                if (radTextMessage.Text != null && !string.IsNullOrWhiteSpace(radTextMessage.Text))
                {
                    if (radCheckNotif.Checked)
                    {
                        player.Play();
                    }
                    string plaintext = encrypted.encrypt(radTextMessage.Text);
                    hub.Invoke("SendMessageToAll", Un, plaintext).Wait();
                }
                else
                {
                    hub.Invoke("SendMessageToAll", Un, radTextMessage.Text).Wait();
                }
            }
            catch
            {
                MessageBox.Show("Gagal terhubung ke server", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
            #endregion
        }

        public void Load_user()
        {
            var Sync = SynchronizationContext.Current;
            try
            {
                #region User baru online
                var newUser = hub.On<string, string>("onNewUserConnected", (id, username) =>
                {
                    Sync.Post(delegate
                    {
                        ConnectedUsers.Add(new Members(username, id));

                        radListOnline.DataSource = ConnectedUsers;
                        if (radCheckNotif.Checked)
                        {
                            player2.Play();
                        }
                    }, null);
                });
                #endregion

                #region load daftar user
                var connect = hub.On<string, string, List<MessageDetail>>("onConnected", (id, Ud, Md) =>
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

                            messageDetail.Clear();
                            if (Md.All(x => string.IsNullOrWhiteSpace(x.UserName)))
                            {
                                foreach (var msg in Md)
                                {
                                    string chipertext = encrypted.decrypt(msg.Message);
                                    messageDetail.Add(new MessageDetail(msg.UserName, chipertext.ToLower()));
                                }
                            }

                            radListMessages.DataSource = messageDetail;

                            int maxList = radListMessages.ClientSize.Height / radListMessages.ItemHeight;
                            radListMessages.TopIndex = Math.Max(radListMessages.Items.Count - maxList + 1, 0);

                            radListOnline.DataSource = ConnectedUsers;
                        }
                    }, null);
                });
                #endregion

                hub.Invoke("Connect", Un).Wait();
            }
            catch
            {
                MessageBox.Show("Gagal terhubung ke server", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        #region Control

        public void SendCtrl()
        {
            Send();
            radTextMessage.Clear();
            KeyCount = 47;
            labelKeyCount.Text = KeyCount.ToString();
        }

        private void radButtonSend_Click(object sender, EventArgs e)
        {
            SendCtrl();
        }

        private void Chatting_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void radButtonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #region Slide form
        private void radButtonSlide_Click(object sender, EventArgs e)
        {
            if (this.Width >= 900)
            {
                timerSlideLeft.Enabled = true;
            }
            else
            {
                timerSlide.Enabled = true;
            }
        }

        private void timerSlide_Tick(object sender, EventArgs e)
        {
            if (this.Width >= 900)
            {
                timerSlide.Enabled = false;
                radButtonSlide.Text = "<";
            }
            else
            {
                this.Width += 10;
            }
        }

        private void timerSlideLeft_Tick(object sender, EventArgs e)
        {
            if (this.Width <= 570)
            {
                timerSlideLeft.Enabled = false;
                radButtonSlide.Text = ">";
            }
            else
            {
                this.Width -= 10;
            }
        }
        #endregion

        #region Batas Inputan
        private void radTextMessage_KeyDown(object sender, KeyEventArgs e)
        {
            // Backspace
            if (e.KeyCode == Keys.Back)
            {
                Backspace = true;
            }
            // enter
            else if(e.KeyCode == Keys.Enter)
            {
                SendCtrl();
            }
            else
            {
                Backspace = false;
            }
        }

        private void radTextMessage_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char pressedKey = e.KeyChar;
            if (Char.IsLetterOrDigit(pressedKey) || Char.IsSeparator(pressedKey) || Char.IsPunctuation(pressedKey) || Char.IsSymbol(pressedKey) || Backspace == true)
            {
                // input yang masuk
                e.Handled = false;
                if (Backspace == true && KeyCount <= 47)
                {
                    if (KeyCount < 47)
                    {
                        KeyCount += 1;
                    }
                }
                else
                {
                    if (KeyCount >= 0 && KeyCount >0)
                    {
                        KeyCount -= 1;
                    }
                }
                
                labelKeyCount.Text = KeyCount.ToString();
            }
            else
            {
                // input ga masuk
                e.Handled = true;
            }
        }
        #endregion

        #endregion
    }
}
