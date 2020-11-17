using ModelLib;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using Newtonsoft.Json;

namespace JsonUDPSender
{
    public class UDPSender
    {
        public void Start()
        {
            Car tesla = new Car() { Model = "Tesla", Color = "Green", RegNr = "JsonCar5" };

            //IPAddress ip = IPAddress.Parse("127.0.0.1"); //
            UdpClient udpClient = new UdpClient(0);

            IPEndPoint RemoteIpEndPoint = new IPEndPoint(IPAddress.Broadcast, 11002); //


            Console.Write("String to send:");
            Console.WriteLine();
            string stringToSend = JsonConvert.SerializeObject(tesla);

            Byte[] sendBytes = Encoding.ASCII.GetBytes(stringToSend);

            udpClient.Send(sendBytes, sendBytes.Length, RemoteIpEndPoint); //, (RemoteEndPoint NOT in 1-1 communication);

        }
    }
}
