using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computers
{
    class Laptop : AbstractComputer
    {
        internal Battery battery;


        public Laptop(MotherBoard motherBoard, IHardDrive hardDrives, Battery battery)
            : base(motherBoard, hardDrives)
        {
            this.battery = battery;
        }

        internal void ChargeBattery(int percentage)
        {
            this.battery.Charge(percentage);
            this.motherBoard.DrawOnVideoCard(string.Format("Battery status: {0}", battery.PowerLeft));
        }

    }
}
