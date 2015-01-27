using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ServerHost.Models
{
    class MessageDetail
    {
        public int Index { get; set; }
        public string UserName { get; set; }
        public string Message { get; set; }
        public int Time { get; set; }
    }
}
