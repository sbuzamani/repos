using System;
using System.Collections.Generic;
using System.Text;

namespace SocketProgramming
{
    public class Request
    {
        public string MethodType { get; set; }

        public string Url { get; set; }

        public string Protocol { get; set; }

        public Dictionary<string, string> Headers { get; set; }
    }
}
