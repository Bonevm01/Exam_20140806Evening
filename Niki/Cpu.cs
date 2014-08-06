namespace Computers
{
    using System;

    internal class Cpu
    {
        private static readonly Random Random = new Random();
        private readonly byte numberOfBits;

        internal Cpu(byte numberOfCores, byte numberOfBits)
        {
            this.numberOfBits = numberOfBits;
            this.NumberOfCores = numberOfCores;
        }

        internal byte NumberOfCores { get; set; }

        public int ReturnSquareNumber(RamMemory ram)
        {
            var data = ram.LoadValue();
            if (data < 0)
            {
                throw new SmallNumberException("The random umber is too small");
            }
            else if ((this.numberOfBits == 32 && data > 500) || (this.numberOfBits == 64 && data > 1000) || (this.numberOfBits == 128 && data > 2000))
            {
                throw new BigNumbersException("The random number is too high");
            }
            else
            {
                return data * data;
            }
        }

        internal int GenerateRandomNumber()
        {
            int randomNumber = Random.Next(1, 10);

            return randomNumber;
        }
    }
}
