namespace Computers
{
    using System.Collections.Generic;

    internal class HardDriver : IHardDrive
    {
        private int capacity;

        private Dictionary<int, string> data;

        internal HardDriver()
        {
            this.data = new Dictionary<int, string>();
        }

        internal HardDriver(int capacity)
        {
            this.capacity = capacity;
        }

        internal int Capacity
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
