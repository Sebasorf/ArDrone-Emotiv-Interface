using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    public class MessageSenderException: Exception
    {
        public MessageSenderException(string IP, int port, string msg)
            : base("Could not send your message '" + msg + "' to server " + IP + ":" + port + ".")
        {
        }
    }
}
