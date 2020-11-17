using System;

namespace JsonUDPSender
{
    class Program
    {
        static void Main(string[] args)
        {
            UDPSender sender = new UDPSender();
            sender.Start();
            Console.ReadLine();
        }
    }
}
