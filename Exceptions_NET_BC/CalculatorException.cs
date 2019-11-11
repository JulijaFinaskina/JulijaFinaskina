using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions_NET_BC
{
    class CalculatorException : Exception
    {
        public CalculatorException(string message)
            : base(message)
        {
        }
    }

}
