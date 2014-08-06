namespace Computers
{
    internal class Laptop : AbstractComputer
    {
        public Laptop(MotherBoard motherBoard, IHardDrive hardDrives, Battery battery)
            : base(motherBoard, hardDrives)
        {
            this.Battery = battery;
        }

        internal Battery Battery { get; set; }

        internal void ChargeBattery(int percentage)
        {
            this.Battery.Charge(percentage);
            this.MotherBoard.DrawOnVideoCard(string.Format("Battery status: {0}", Battery.PowerLeft));
        }
    }
}
