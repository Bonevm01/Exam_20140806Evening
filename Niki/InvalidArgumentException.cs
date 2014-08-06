namespace Computers
{
    using System;

    internal class InvalidArgumentException : ArgumentException
    {
        public InvalidArgumentException(string message)
            : base(message)
        {
        }
    }
}
