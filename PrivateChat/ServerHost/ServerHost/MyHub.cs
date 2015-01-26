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
        static List<UserPrivateMessage> userPrivateMessage = new List<UserPrivateMessage>();
        
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

                }

                // Ngirim ke caller baru daftar user online
                Clients.Caller.onConnected(id,Ud,CurrentMessage);

                // Ngirim ke semua client kecuali caller
                Clients.AllExcept(id).onNewUserConnected(id, userName);
                
            }
        }
        #endregion

        #region Kirim pesan kesemua
        public void SendMessageToAll(string userName, string message)
        {
            // cache pesan ke list
            if (message.Length > 0)
            {
                AddMessageinCache(userName, message);
                Console.WriteLine(userName + " mengirim pesan publik");
            }

            Clients.All.messageReceived(CurrentMessage);
        }

        #endregion

        #region PM (Masih dalam percobaan)
        public void SendPrivateMessage(string toConId = "")
        {
            string fromConId = Context.ConnectionId;

            if (toConId != "")
            {
                var toUser = ConnectedUsers.FirstOrDefault(x => x.ConnectionId == toConId).UserName;
                var fromUser = ConnectedUsers.FirstOrDefault(x => x.ConnectionId == fromConId).UserName;

                if (toUser != null && fromUser != null)
                {
                    userPrivateMessage.Add(new UserPrivateMessage { fromConnectionId = fromConId, toConnectionId = toConId });
                    Clients.Client(toConId).GetUser(userPrivateMessage.Where(x => x.toConnectionId == toConId));
                    Clients.Caller.GetUser(userPrivateMessage.Where(x => x.fromConnectionId == toConId));
                }
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

        //private void AddMessageinCache(string fromConId, string toConId, string message)
        //{
        //    PrivateMessage.Add(new UserPrivateMessage { fromConnectionId = fromConId, toConnectionId = toConId, message = message });

        //    if (PrivateMessage.Count > 100)
        //    {
        //        PrivateMessage.RemoveAt(0);
        //    }
        //}

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
