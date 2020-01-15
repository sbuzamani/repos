using System;
using System.Collections.Generic;
using System.Text;

namespace SocketProgramming
{
    class NoContentResponseBuilder : ResponseBuilder
    {
        //build no content response here!!!!
        public NoContentResponseBuilder()
        {

        }

        public override Response GetResponse()
        {
            throw new NotImplementedException();
        }
    }
}
