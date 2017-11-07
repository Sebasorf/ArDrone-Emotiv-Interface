using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    public class ServerDisconnectException : Exception
    {
        public ServerDisconnectException(String IP, int port)
            : base("Could not disconnect to Server at " + IP + ":" + port + ".")
        {
        }
    }
}
