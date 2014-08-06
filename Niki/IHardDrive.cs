using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computers
{
    public interface IHardDrive
    {
        void SaveData(int addr, string newData);
        string LoadData(int address);
    }
}
