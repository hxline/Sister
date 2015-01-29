using System;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using System.Collections;

namespace RemoteBase
{
    public class Services : MarshalByRefObject
    {
        Hashtable hTChatMsg=new Hashtable ();
        ArrayList alOnlineUser = new ArrayList();
        //untuk mendeteksi adanya pesan baru
        private int key = 0;
        
        public bool JoinToChatRoom(string name)
        {
            if (alOnlineUser.IndexOf(name) > -1)
            {
                return false;
            }
            else
            {
                //tambah user ke array online
                alOnlineUser.Add(name);
                //SendMsgToSvr(name + " online.");
                return true;
            }
            
        }
        public void LeaveChatRoom(string name)
        {
            //Hapus dari array online
            alOnlineUser.Remove(name);
            //SendMsgToSvr(name + " offline.");
        }
        public ArrayList GetOnlineUser()
        {
            return alOnlineUser;
        }

        //Mengembalikan key pesan
        public int CurrentKeyNo()
        {
            return key;
        }
        public void SendMsgToSvr(string chatMsgFromUsr)
        {
            //tambah pesan
            hTChatMsg.Add(++key, chatMsgFromUsr);
        }
        public string GetMsgFromSvr(int lastKey)
        {
            //kalo ada pesan baru
            if (key > lastKey)
            {
                return hTChatMsg[lastKey + 1].ToString();
            }
            else
            {
                return "";
            }
        }
    }
}
