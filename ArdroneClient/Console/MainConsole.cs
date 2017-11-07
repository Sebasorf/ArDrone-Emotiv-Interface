using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lib;

namespace ConsoleApp
{
    class MainConsole
    {
        static void Main(string[] args)
        {
            //EmotivClient emotiv = new EmotivClient("192.168.0.62" ,8000);
            Client emotiv = new Client("192.168.0.21", 8000);


            Console.WriteLine("IP: {0}", emotiv.Ip);
            Console.WriteLine("Port: {0}", emotiv.Port);
            Console.WriteLine("\n");

            if (emotiv.Connect())
            {
                if (emotiv.SendData())
                {
                    int i = 0; //No hago nada
                }
                emotiv.Disconnect();
                Console.WriteLine("El sistema finalizo con exito...");
            }
            else
            {
                Console.WriteLine("El sistema finalizo con errores...");
            }
            Console.ReadKey();

        }
    }
}
