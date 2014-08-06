using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computers
{
    internal class RaidOfHD : IHardDrive
    {
        IList<HardDriver> ListOfHD;

        internal RaidOfHD()
        {
            this.ListOfHD = new List<HardDriver>();
        }

        internal void AddHD(HardDriver HD)
        {
            this.ListOfHD.Add(HD);
        }

        int Capacity
        {
            get
            {
                if (this.ListOfHD.Count == 0)
                {
                    return 0;
                }
                else
                {
                    return this.ListOfHD[0].capacity;
                }
            }
        }

        public void SaveData(int addr, string newData)
        {
            if (this.ListOfHD.Count == 0)
            {
                throw new OutOfMemoryException("No hard drive in the RAID array!");
            }
            else if (this.ListOfHD.Count > 1)
            {
                foreach (var hardDrive in this.ListOfHD)
                {
                    hardDrive.SaveData(addr, newData);
                }
            }
            else
            {
                this.ListOfHD[0].SaveData(addr, newData);
            }
        }

        public string LoadData(int address)
        {
            if (this.ListOfHD.Count == 0)
            {
                throw new OutOfMemoryException("No hard drive in the RAID array!");
            }
            else if (true)
            {
                return this.ListOfHD[0].LoadData(address);
            }
        }
    }
}
