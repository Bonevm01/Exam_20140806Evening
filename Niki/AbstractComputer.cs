namespace Computers
{
    internal abstract class Computer
    {
        public Computer(MotherBoard motherBoard, IHardDrive hardDrives)
        {
            this.MotherBoard = motherBoard;
            this.HardDrives = hardDrives;
        }

        internal MotherBoard MotherBoard { get; set; }

        internal IHardDrive HardDrives { get; set; }
    }
}
