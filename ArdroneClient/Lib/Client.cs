using System;
using System.Net.Sockets;
using System.Net;
using System.Text;
using Exceptions;

namespace Lib
{
    public class Client
    {
        private IPAddress ip;
        private int port;
        private Socket socket;
        private IPEndPoint endPoint;

        public Client(String ip, int port)
        {
            try
            {
                Console.Write("Initializing Server information...    ");
                this.ip = IPAddress.Parse(ip);
                this.port = port;
                Console.WriteLine("Done ✓");

                Console.Write("Initializing socket...   ");
                this.socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                Console.WriteLine("Done ✓");
                
                Console.Write("Inictializing endpoint...    ");
                this.endPoint = new IPEndPoint(this.ip, this.port);
                Console.WriteLine("Done ✓");
                
                Console.WriteLine("The connection to {0}:{1} was successfully initialized... ", this.ip, this.port);
                Console.WriteLine("\n");
            }
            catch (Exception e)
            {
                Console.WriteLine("Failed ✗");
                throw new InitializeConnectionException(this.ip.ToString(), this.port);
                Console.WriteLine("\n");
                Console.WriteLine("************************************************************************\n");
                Console.WriteLine("There was an error trying to initialize connection to endpoint {0}:{1}...", this.ip, this.port);
                Console.WriteLine("- {0}", e.StackTrace);
                Console.WriteLine("************************************************************************\n");
                Console.WriteLine("\n");
                Console.WriteLine("\n");
            }
        }

        public Client()
        {
            try
            {
                Console.Write("Initializing Server information...    ");
                this.ip = IPAddress.Parse("192.168.0.21");
                this.port = 8000;
                Console.WriteLine("Done ✓");

                Console.Write("Initializing socket...   ");
                this.socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                Console.WriteLine("Done ✓");

                Console.Write("Inictializing endpoint...    ");
                this.endPoint = new IPEndPoint(this.ip, this.port);
                Console.WriteLine("Done ✓");

                Console.WriteLine("The connection to {0}:{1} was successfully initialized... ", this.ip, this.port);
                Console.WriteLine("\n");
            }
            catch (Exception e)
            {
                throw new InitializeConnectionException(this.ip.ToString(), this.port);
                Console.WriteLine("\n");
                Console.WriteLine("************************************************************************\n");
                Console.WriteLine("There was an error trying to initialize connection: {0}...", this.ip);
                Console.WriteLine("- {0}", e.StackTrace);
                Console.WriteLine("************************************************************************\n");
                Console.WriteLine("\n");
                Console.WriteLine("\n");
            }
        }

        public Boolean Connect()
        {
            try
            {                
                Console.Write("Connecting socket to endpoint {0}:{1}...    ", this.ip, this.port);
                this.socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                socket.Connect(this.endPoint);
                Console.WriteLine("Done ✓");
                Console.WriteLine("\n");
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("Failed ✗");
                throw new ConnectionException(this.ip.ToString(), this.port);
                Console.WriteLine("\n");
                Console.WriteLine("************************************************************************\n");
                Console.WriteLine("There was an error trying to establish connection to endpoint {0}:{1}...", this.ip, this.port);
                Console.WriteLine("- {0}", e.StackTrace);
                Console.WriteLine("************************************************************************\n");
                Console.WriteLine("\n");
                Console.WriteLine("\n");
                return false;
            }
        }

        public Boolean SendCommand(String cmd)
        {
            try
            {
                this.Connect();
                byte[] message = Encoding.ASCII.GetBytes(cmd);
                Console.Write("Sending message to server: {0}...    ", cmd);
                int bytesSent = socket.Send(message);
                Console.WriteLine("Done ✓");
                Console.WriteLine("\n");
                this.Disconnect();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("Failed ✗");
                throw new MessageSenderException(this.ip.ToString(), this.port, cmd);
                Console.WriteLine("\n");
                Console.WriteLine("************************************************************************\n");
                Console.WriteLine("There was an error trying to send command to endpoint {0}:{1}...", this.ip, this.port);
                Console.WriteLine("- {0}", e.StackTrace);
                Console.WriteLine("************************************************************************\n");
                Console.WriteLine("\n");
                Console.WriteLine("\n");
                return false;
            }
        }

        public Boolean SendData()
        {
            try
            {
                this.Connect();
                byte[] message = Encoding.ASCII.GetBytes("Hoolaarar");
                Console.Write("Sending message to server: {0}...    ", message);
                int bytesSent = socket.Send(message);
                Console.WriteLine("Done ✓");
                Console.WriteLine("\n");
                this.Disconnect();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("Failed ✗");
                throw new MessageSenderException(this.ip.ToString(), this.port, "Hoolaarar");
                Console.WriteLine("\n");
                Console.WriteLine("************************************************************************\n");
                Console.WriteLine("There was an error trying to send message to endpoint {0}:{1}...", this.ip, this.port);
                Console.WriteLine("- {0}", e.StackTrace);
                Console.WriteLine("************************************************************************\n");
                Console.WriteLine("\n");
                Console.WriteLine("\n");
                return false;
            }
        }

        public void Disconnect()
        {
            try
            {
                Console.Write("Disconnecting socket from server {0}:{1}...    ", this.ip, this.port);
                socket.Shutdown(SocketShutdown.Both);
                socket.Dispose();
                Console.WriteLine("Done ✓");
                Console.WriteLine("\n");
            }
            catch (Exception e)
            {
                Console.WriteLine("Failed ✗");
                throw new ServerDisconnectException(this.ip.ToString(), this.port);
                Console.WriteLine("\n");
                Console.WriteLine("************************************************************************\n");
                Console.WriteLine("There was an error trying to disconnect from endpoint {0}:{1}...", this.ip, this.port);
                Console.WriteLine("- {0}", e.StackTrace);
                Console.WriteLine("************************************************************************\n");
                Console.WriteLine("\n");
                Console.WriteLine("\n");
            }
        }

        public IPAddress Ip
        {
            set { this.ip = value; }
            get { return this.ip; }
        }

        public int Port
        {
            set { this.port = value; }
            get { return this.port; }
        }


        public void ResetConfig()
        {
            Ip = null;
            port = 0;
        }
    }
}                                                                                                                                                                                                                                                             