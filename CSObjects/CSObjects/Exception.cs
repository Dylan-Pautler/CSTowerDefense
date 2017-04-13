using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSObjects
{
    class CSObjectsException : System.Exception
    {
        public CSObjectsException()
        { }

        public CSObjectsException(string message) : base(message)
        {

        }
    }

    class OutOfBoundsException : CSObjectsException
    {
        public OutOfBoundsException()
        { }
        public OutOfBoundsException(string message) : base(message)
        {

        }
    }
}
