using System;
using System.Collections.Generic;
using System.Text;

namespace SocketProgramming
{
    public class ResponseDirector
    {
        private ResponseBuilder responseBuilder;
        ResponseDirector(ResponseBuilder responseBuilder)
        {
            this.responseBuilder = responseBuilder;
        }

        public void Construct()
        {
            responseBuilder.GetResponse();
        }
    }
}
