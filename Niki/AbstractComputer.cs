using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computers
{
    internal abstract class AbstractComputer
    {
        internal MotherBoard motherBoard;
        internal IHardDrive HardDrives { get; set; }


        public AbstractComputer(MotherBoard motherBoard, IHardDrive hardDrives)
        {
            this.motherBoard = motherBoard;
            this.HardDrives = hardDrives;

        }
    }
}
