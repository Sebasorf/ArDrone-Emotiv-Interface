using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    public class ConnectionException : Exception
    {
        public ConnectionException(String IP, int port)
            : base("Could not connect to Server at " + IP + ":" + port + ".")
        {
        }
    }
}
