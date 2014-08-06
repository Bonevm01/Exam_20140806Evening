namespace Computers
{
    using System;

    internal class SmallNumberException : Exception
    {
        public SmallNumberException(string message)
            : base(message)
        {
        }
    }
}
