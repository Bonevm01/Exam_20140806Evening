using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computers
{
    class Server : AbstractComputer
    {
        public Server(MotherBoard motherBoard, IHardDrive hardDrives)
            : base(motherBoard, hardDrives)
        {
            this.motherBoard.VideoCard.IsMonochrome = true;
        }
        internal void Process(int data)
        {
            this.motherBoard.SaveRamValue(data);
            this.motherBoard.DrawSquareNumber();
        }

    }


}
