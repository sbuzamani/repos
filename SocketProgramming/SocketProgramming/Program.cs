using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SocketProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            var server = new TcpListener(IPAddress.Any, 9999);
            string seperator = "\r\n";
            Dictionary<string, string> headersDictionary = new Dictionary<string, string>();

            server.Start();

            while (true)
            {
                var client = server.AcceptTcpClient(); 

                var networkStream = client.GetStream();

                var nBuffer = new byte[1024];

                while (client.Connected)
                {
                    var buffer = new byte[1024];

                    networkStream.Read(buffer, 0, buffer.Length);

                    var str = Encoding.ASCII.GetString(buffer);

                    string debufferedText = str.Split($"{seperator}{seperator}").GetValue(0).ToString();
                    var lines = debufferedText.Split($"{seperator}");

                    var headerLineMatch = Regex.Match(lines[0], @"(GET|POST)\s([^\s]*)\s(HTTP\/1\.1)");

                    string methodType = headerLineMatch.Groups[1].ToString();
                    string requestUrl = headerLineMatch.Groups[2].ToString();
                    string protocol = headerLineMatch.Groups[3].ToString();

                    Console.WriteLine($"{methodType} {requestUrl} {protocol}");
                    
                    for (int i = 1; i < lines.Length; i++)
                    {
                        var dictionaryEntry = Regex.Match(lines[i], @"(.+):\s(.*)").Groups;
                        headersDictionary.Add(dictionaryEntry[1].ToString(), dictionaryEntry[2].ToString());

                        Console.WriteLine($"{lines[i]}");
                    }

                    var request = new Request
                    {
                        MethodType = methodType,
                        Url = requestUrl,
                        Protocol = protocol,
                        Headers = headersDictionary
                    };

                    var response = new Response
                    {
                        Type = "HTTP/1.1 ",
                        Code = 200,
                        Reason = "OK",
                        Headers = "Cache-control: no-cache, private",
                        ContentInfo ="Content-Length: ",
                        ContentLength = 5,
                        Content = "Heyaa"
                    };

                    networkStream.Write(ASCIIEncoding.ASCII.GetBytes(response.ToString()));
                    networkStream.Flush();
                }


            }

        }
    }
}
