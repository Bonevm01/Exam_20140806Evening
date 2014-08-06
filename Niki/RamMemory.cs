﻿namespace Computers
{
    internal class RamMemory
    {
        internal int value;
        internal RamMemory(int a)
        {
            Amount = a;
        }

        int Amount{ get; set; }

        public void SaveValue(int newValue)
        {
            value = newValue;
        }

        public int LoadValue()
        {
            return value;
        }
    }
}