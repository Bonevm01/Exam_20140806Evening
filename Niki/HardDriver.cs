using System;
using System.Collections.Generic;
using System.Linq;

namespace Computers
{

    internal class HardDriver : IHardDrive
    {
        internal int capacity;
        Dictionary<int, string> data;

        internal HardDriver()
        {
            this.data = new Dictionary<int, string>();
        }

        internal HardDriver(int capacity)
        {
            this.capacity = capacity;
        }


        int Capacity
        {
            get
            {
                return this.capacity;
            }
        }

        public void SaveData(int addr, string newData)
        {

            this.data.Add(addr, newData);
        }

        public string LoadData(int address)
        {
            return this.data[address];
        }

    }

}
