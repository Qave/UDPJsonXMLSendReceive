using System;

namespace JsonUDPreceiver
{
    class Program
    {
        static void Main(string[] args)
        {
            UDPreceiver Receiver = new UDPreceiver();
            Receiver.Start();
            Console.ReadLine();
        }
    }
}
