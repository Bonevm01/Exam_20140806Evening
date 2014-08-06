namespace Computers
{
    internal class RamMemory
    {
        private int value;

        internal RamMemory(int ram)
        {
            this.Amount = ram;
        }

        internal int Amount { get; set; }

        public void SaveValue(int newValue)
        {
            this.value = newValue;
        }

        public int LoadValue()
        {
            return this.value;
        }
    }
}