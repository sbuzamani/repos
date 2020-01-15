using System;
using System.Collections.Generic;
using System.Text;

namespace SocketProgramming
{
    class OkResponseBuilder : ResponseBuilder
    {
        //build ok response object here!!!!
        private Response _response = new Response();

        public OkResponseBuilder()
        {

        }

        public override Response GetResponse()
        {
            throw new NotImplementedException();
        }
    }
}
