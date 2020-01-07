using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace ExampleTcpClient
{
    class Program
    {
        static void Main(string[] args)
        {
            ExecuteClient();
        }

        static void ExecuteClient()
        {
            try
            {
                IPHostEntry ipHost = Dns.GetHostEntry(Dns.GetHostName());
                IPAddress ipAddress = ipHost.AddressList[0];
                IPEndPoint localEndPoint = new IPEndPoint(ipAddress, 9999);

                Socket sender = new Socket(ipAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
                try
                {
                    sender.Connect(localEndPoint);

                    Console.WriteLine($"Socket connected to -> {sender.RemoteEndPoint.ToString()}");

                    byte[] messageSent = Encoding.ASCII.GetBytes("Test Client<EOF>, this is a test, a remarkable test, we have very limited examples test it out");
                    int byteSent = sender.Send(messageSent);

                    byte[] messageReceived = new byte[1024];

                    int bytesReceived = sender.Receive(messageReceived);
                    Console.WriteLine($"Message from Server -> {Encoding.ASCII.GetString(messageReceived, 0, bytesReceived)}");
                    sender.Shutdown(SocketShutdown.Send);
                    sender.Close();
                    Console.ReadLine();
                }
                catch (ArgumentNullException ne)
                {
                    Console.WriteLine($"ArgumentNullException: {ne.ToString()}");
                }
                catch (SocketException se)
                {
                    Console.WriteLine($"SocketException: {se.ToString()}");
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Unexpected exception: {e.ToString()}");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }
}
