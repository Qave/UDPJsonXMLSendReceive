using ModelLib;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace PlainUDPSender
{
    public class UDPSender
    {

        public void Start()
        {
            Car tesla = new Car() { Model = "Tesla", Color = "Black", RegNr = 41238};
            
            IPAddress ip = IPAddress.Parse("127.0.0.1"); //
            UdpClient udpClient = new UdpClient("127.0.0.1", 11001);

            IPEndPoint RemoteIpEndPoint = new IPEndPoint(ip, 11001); //
            //udpClient.Connect(RemoteIpEndPoint); //

            Console.Write("String to send:");
            Console.WriteLine();
            //string stringToSend = Console.ReadLine();

            Byte[] sendBytes = Encoding.ASCII.GetBytes(tesla.ToString());

            udpClient.Send(sendBytes, sendBytes.Length); //, (RemoteEndPoint NOT in 1-1 communication);

            //for (int i = 0; i < 5000; i++)
            //{
            //    Byte[] sendBytes = Encoding.ASCII.GetBytes(name + " " + number + " hello");

            //    udpClient.Send(sendBytes, sendBytes.Length); //, (RemoteEndPoint NOT in 1-1 communication);
            //    Byte[] receiveBytes = udpClient.Receive(ref RemoteIpEndPoint);
            //    //Client is now activated");

            //    string receivedData = Encoding.ASCII.GetString(receiveBytes);
            //    Console.WriteLine(receivedData);
            //    number++;
            //}
        }
    }
}
