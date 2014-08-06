namespace Computers
{
    internal class MotherBoard : IMotherboard
    {
        public MotherBoard(Cpu cpu, RamMemory ram, VideoCard videoCard)
        {
            this.CPU = cpu;
            this.Ram = ram;
            this.VideoCard = videoCard;
        }

        internal Cpu CPU { get; set; }

        internal RamMemory Ram { get; set; }

        internal VideoCard VideoCard { get; set; }

        public int LoadRamValue()
        {
            return this.Ram.LoadValue();
        }

        public void SaveRamValue(int value)
        {
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
                var data = this.LoadRamValue();
                var squareNumber = this.CPU.ReturnSquareNumber(this.Ram);
                this.DrawOnVideoCard(string.Format("Square of {0} is {1}.", data, squareNumber));
            }
            catch (BigNumbersException)
            {
                this.DrawOnVideoCard("Number too high.");
            }
            catch (SmallNumberException)
            {
                this.DrawOnVideoCard("Number too low.");
            }
        }
    }
}
