using System;

namespace Computers
{
    class SmallNumberException : Exception
    {
        public SmallNumberException(string message)
            : base(message)
        {
        }
    }
}
