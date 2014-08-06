using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computers
{

    class BigNumbersException : Exception
    {
        public BigNumbersException(string message)
            : base(message)
        {
        }
    }

}
