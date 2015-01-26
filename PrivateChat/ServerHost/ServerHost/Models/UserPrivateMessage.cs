using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerHost.Models
{
    class UserPrivateMessage
    {
        public string fromConnectionId { get; set; }
        public string toConnectionId { get; set; }
    }
}
