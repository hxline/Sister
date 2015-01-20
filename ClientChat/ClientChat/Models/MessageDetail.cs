namespace ClientChat.Models
{
    class MessageDetail
    {
        public string UserName;
        public string Message;

        public MessageDetail(string username, string message)
        {
            UserName = username;
            Message = message;
        }

        public override string ToString()
        { 
            return UserName + " : " + Message;
        }
    }
}
