
using System;
namespace Computers
{

    internal class Cpu
    {
        private readonly byte numberOfBits;
        byte NumberOfCores { get; set; }
        static readonly Random Random = new Random();

        internal Cpu(byte numberOfCores, byte numberOfBits)
        {
            this.numberOfBits = numberOfBits;
            this.NumberOfCores = numberOfCores;
        }

        public int ReturnSquareNumber(RamMemory ram)
        {
            var data = ram.LoadValue();
            if (data < 0)
            {
                throw new SmallNumberException("The random umber is too small");
            }
            else if ((this.numberOfBits == 32 && data > 500) || (this.numberOfBits == 64 && data > 1000))
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
