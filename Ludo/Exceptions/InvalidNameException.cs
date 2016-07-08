using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ludo.Exceptions
{
    public class InvalidNameException : ApplicationException
    {
        public InvalidNameException()
        {
        }

        public InvalidNameException(string message)
        : base(message)
        {
        }

        public InvalidNameException(string message, Exception inner)
        : base(message, inner)
        {
        }
    }
}
