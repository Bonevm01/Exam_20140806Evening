using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computers
{
    class MotherBoard : IMotherboard
    {
        internal Cpu CPU;
        internal RamMemory Ram;
        internal VideoCard VideoCard;

        public MotherBoard(Cpu cpu, RamMemory ram, VideoCard videoCard)
        {
            this.CPU = cpu;
            this.Ram = ram;
            this.VideoCard = videoCard;
        }


        public int LoadRamValue()
        {
            return this.Ram.LoadValue();
        }

        public void SaveRamValue(int value)
        {
            // int value = this.CPU.GenerateRandomNumber();
            this.Ram.SaveValue(value);
        }

        public void DrawOnVideoCard(string data)
        {
            this.VideoCard.Draw(data);
        }

        public void DrawSquareNumber()
        {
            try
            {
                var data = LoadRamValue();
                var squareNumber = this.CPU.ReturnSquareNumber(Ram);
                DrawOnVideoCard(string.Format("Square of {0} is {1}.", data, squareNumber));
            }
            catch (BigNumbersException)
            {
                DrawOnVideoCard("Number too high.");
            }
            catch (SmallNumberException)
            {
                DrawOnVideoCard("Number too low.");
            }
        }
    }
}
