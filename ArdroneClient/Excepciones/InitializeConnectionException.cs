using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    public class InitializeConnectionException : Exception
    {
        public InitializeConnectionException(String IP, int port)
            : base("Could not initialize connection to Server at " + IP + ":" + port + ".")
        {
        }
    }
}
