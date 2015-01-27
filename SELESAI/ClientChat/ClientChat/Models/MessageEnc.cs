using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientChat.Models
{
    class MessageEnc
    {
        public string UserName { get; set; }

        public byte[] Message { get; set; }
    }
}
