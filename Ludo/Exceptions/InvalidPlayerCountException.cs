using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ludo.Exceptions
{
    public class InvalidPlayerCountException : ApplicationException
    {
        public InvalidPlayerCountException()
        {
        }

        public InvalidPlayerCountException(string message)
        : base(message)
        {
        }

        public InvalidPlayerCountException(string message, Exception inner)
        : base(message, inner)
        {
        }
    }
}
