using System;

namespace PlainUDPReceiver
{
    class Program
    {
        static void Main(string[] args)
        {
            UDPReceiver Receiver = new UDPReceiver();
            Receiver.Start();
            Console.ReadLine();
        }
    }
}
