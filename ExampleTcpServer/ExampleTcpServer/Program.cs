using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace ExampleTcpServer
{
    class Program
    {
        const int port = 3000;
        const string ipAddress = "127.0.0.1";
        static void Main(string[] args)
        {
            ExecuteServer();
        }

        public static void ExecuteServer()
        {
            IPHostEntry hostEntry = Dns.GetHostEntry(Dns.GetHostName());
            IPAddress address = hostEntry.AddressList[0];
            IPEndPoint localEndpoint = new IPEndPoint(address, 11111);

            Socket listener = new Socket(address.AddressFamily, SocketType.Stream, ProtocolType.Tcp);

            try
            {
                listener.Bind(localEndpoint);

                listener.Listen(10);

                while (true)
                {
                    Console.WriteLine("Waiting connection...");

                    Socket clientSocket = listener.Accept();

                    byte[] bytes = new Byte[1024];
                    string data = null;

                    while (true)
                    {
                        int numberOfBytes = clientSocket.Receive(bytes);

                        data += Encoding.ASCII.GetString(bytes, 0, numberOfBytes);

                        if (data.IndexOf("<EOF>") > -1)
                        {
                            break;
                        }
                    }
                    Console.WriteLine($"Text received -> {data.Length}");
                    byte[] message = Encoding.ASCII.GetBytes("Test Server");

                    clientSocket.Send(message);

                    clientSocket.Shutdown(SocketShutdown.Both);
                    clientSocket.Close();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }
}
