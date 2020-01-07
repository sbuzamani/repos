using System;
using System.Collections.Generic;
using System.Text;

namespace SocketProgramming
{
    public class Response
    {
        public string Type { get; set; }

        public int Code { get; set; }

        public string Reason { get; set; }

        public string Headers { get; set; }

        public string ContentInfo { get; set; }

        public int ContentLength { get; set; }

        public string Content { get; set; }

        public string ToString()
        {
            string statusLine = $"{Type}{Code} {Reason}\r\n";
            string headersLine = $"{Headers}\r\n";
            string contentLine = $"{ContentInfo}{ContentLength}\r\n\r\n";

            return $"{statusLine}{headersLine}{contentLine}{Content}";
        }
    }
}
