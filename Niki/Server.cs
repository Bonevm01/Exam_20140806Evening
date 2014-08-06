namespace Computers
{
    internal class Server : AbstractComputer
    {
        public Server(MotherBoard motherBoard, IHardDrive hardDrives)
            : base(motherBoard, hardDrives)
        {
            this.MotherBoard.VideoCard.IsMonochrome = true;
        }

        internal void Process(int data)
        {
            this.MotherBoard.SaveRamValue(data);
            this.MotherBoard.DrawSquareNumber();
        }
    }
}
