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
        private string Ud = null;
        private string Md = null;
        #endregion

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
                            Ud = Ud + "?" + cu.ConnectionId + "|" + cu.UserName;
                        }
                        else
                        {
                            Ud = cu.ConnectionId + "|" + cu.UserName;
                        }
                    }

                    foreach(var cm in CurrentMessage)
                    {
                        if (Md != null)
                        {
                            Md = Md + "?" + cm.UserName + "|" + cm.Message;
                        }
                        else
                        {
                            Md = cm.UserName + "|" + cm.Message;
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
            // store last 100 messages in cache
            AddMessageinCache(userName, message);

            // Broad cast message
            Clients.All.messageReceived(userName, message);
        }
        #endregion

        #region PM
        public void SendPrivateMessage(string toUserId, string message)
        {
            string fromUserId = Context.ConnectionId;

            var toUser = ConnectedUsers.FirstOrDefault(x => x.ConnectionId == toUserId);
            var fromUser = ConnectedUsers.FirstOrDefault(x => x.ConnectionId == fromUserId);

            if (toUser != null && fromUser != null)
            {
                // Ngirim ke client tertentu
                Clients.Client(toUserId).sendPrivateMessage(fromUserId, fromUser.UserName, message);

                // Ngirim ke caller
                Clients.Caller.sendPrivateMessage(toUserId, fromUser.UserName, message);
            }

        }
        #endregion

        #region Tambah ke cache pesan

        private void AddMessageinCache(string userName, string message)
        {
            CurrentMessage.Add(new MessageDetail { UserName = userName, Message = message });

            if (CurrentMessage.Count > 100)
                CurrentMessage.RemoveAt(0);
        }

        #endregion

        #endregion Procedure

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
