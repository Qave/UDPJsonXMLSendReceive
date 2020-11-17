using ModelLib;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace JsonUDPreceiver
{
    public class UDPreceiver
    {
        public void Start()

        { //Creates a UdpClient for reading incoming data.
            UdpClient udpReceiver = new UdpClient(11002);

            //Creates an IPEndPoint to record the IP Address and port number of the sender.  
            //IPAddress ip = IPAddress.Parse("127.0.0.1");
            IPEndPoint RemoteIpEndPoint = new IPEndPoint(IPAddress.Any, 11002);
            //IPEndPoint object will allow us to read datagrams sent from another source.

            try
            {
                // Blocks until a message is received on this socket from a remote host (a client).
                Console.WriteLine("Server is blocked");
                while (true)
                {
                    Byte[] receiveBytes = udpReceiver.Receive(ref RemoteIpEndPoint);
                    Car receivedCar = JsonConvert.DeserializeObject<Car>(Encoding.ASCII.GetString(receiveBytes));
                    Console.WriteLine(receivedCar);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }
}
