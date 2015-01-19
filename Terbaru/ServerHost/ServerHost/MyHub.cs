using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.SignalR;
using ServerHost.Models;

namespace ServerHost
{
    public class MyHub : Hub
    {
        #region Data Members

        static List<UserDetail> ConnectedUsers = new List<UserDetail>();
        static List<MessageDetail> CurrentMessage = new List<MessageDetail>();
        static List<UserPrivateMessage> PrivateMessage = new List<UserPrivateMessage>();
        
        #endregion
        
        private string Ud = null;
        private string Md = null;
        private string Pm = null;
        private string reg1 = "-z<zx>x-";
        private string reg2 = "-z<xz>x-";

        #region Procedures

        #region koneksi awal dari client ke server
        public void Connect(string userName)
        {
            var id = Context.ConnectionId;

            if (ConnectedUsers.Count(x => x.ConnectionId == id) == 0)
            {
                // Tambah ke list user
                ConnectedUsers.Add(new UserDetail { ConnectionId = id, UserName = userName });

                if (ConnectedUsers.Count > 1)
                {
                    foreach (var cu in ConnectedUsers.Where(x => x.ConnectionId != id))
                    {
                        if (Ud != null)
                        {
                            Ud = Ud + reg1 + cu.ConnectionId + reg2 + cu.UserName;
                        }
                        else
                        {
                            Ud = cu.ConnectionId + reg2 + cu.UserName;
                        }
                    }

                    foreach(var cm in CurrentMessage)
                    {
                        if (Md != null)
                        {
                            Md = Md + reg1 + cm.UserName + reg2 + cm.Message;
                        }
                        else
                        {
                            Md = cm.UserName + reg2 + cm.Message;
                        }
                    }
                }

                // Ngirim ke caller baru daftar user online
                Clients.Caller.onConnected(id,Ud,Md);

                // Ngirim ke semua client kecuali caller
                Clients.AllExcept(id).onNewUserConnected(id, userName);
                
            }
        }
        #endregion

        #region Kirim pesan kesemua
        public void SendMessageToAll(string userName, string message)
        {
            StringBuilder bul = new StringBuilder();
            // cache pesan ke list
            if (message.Length > 0)
            {
                AddMessageinCache(userName, message);
                Console.WriteLine(userName + " mengirim pesan publik");
            }

            foreach (var cm in CurrentMessage)
            {
                if (Md != null)
                {
                    Md = Md + reg1 + cm.UserName + reg2 + cm.Message;
                }
                else
                {
                    Md = cm.UserName + reg2 + cm.Message;
                }
            }

            Clients.All.messageReceived(Md);
        }

        #endregion

        #region PM (Masih dalam percobaan)
        public void SendPrivateMessage(string toConId, string message)
        {
            string fromConId = Context.ConnectionId;

            var toUser = ConnectedUsers.FirstOrDefault(x => x.ConnectionId == toConId);
            var fromUser = ConnectedUsers.FirstOrDefault(x => x.ConnectionId == fromConId);

            string DetailMsg = fromUser.ToString() + reg2 + message;

            if (message.Length > 0)
            {
                AddMessageinCache(fromConId,toConId,DetailMsg);
                Console.WriteLine(fromUser + " mengirim pesan private");
            }

            if (toUser != null && fromUser != null)
            {
                foreach (var pm in PrivateMessage)
                {
                    if (Pm != null)
                    {
                        Pm = Pm + reg1 + pm.message;
                    }
                    else
                    {
                        Pm = pm.message;
                    }
                }

                // Ngirim ke client tertentu
                Clients.Client(toConId).receivePrivateMessage(Pm);
                Clients.Client(toConId).listPrivateMessage(Pm);

                // Ngirim ke caller
                Clients.Caller.receivePrivateMessage(Pm);
            }

        }
        #endregion

        #region Tambah ke cache pesan

        private void AddMessageinCache(string userName, string message)
        {
            CurrentMessage.Add(new MessageDetail { UserName = userName, Message = message });

            if (CurrentMessage.Count > 100)
            {
                CurrentMessage.RemoveAt(0);
            }
        }

        private void AddMessageinCache(string fromConId, string toConId, string message)
        {
            PrivateMessage.Add(new UserPrivateMessage { fromConnectionId = fromConId, toConnectionId = toConId, message = message });

            if (PrivateMessage.Count > 100)
            {
                PrivateMessage.RemoveAt(0);
            }
        }

        #endregion

        #endregion Procedures

        #region Task
        public override Task OnConnected()
        {
            Console.WriteLine("Terkoneksi {0}",Context.ConnectionId);
            return base.OnConnected();
        }

        public override Task OnDisconnected(bool stopCalled)
        {
            var item = ConnectedUsers.FirstOrDefault(x => x.ConnectionId == Context.ConnectionId);
            if (item != null)
            {
                ConnectedUsers.Remove(item);

                var id = Context.ConnectionId;
                Clients.All.onUserDisconnected(id, item.UserName);
            }
            Console.WriteLine("Terputus {0}", Context.ConnectionId);
            return base.OnDisconnected(stopCalled);
        }
        #endregion
    }
}
