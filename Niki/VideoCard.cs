using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computers
{
    class VideoCard
    {
        public bool IsMonochrome { get; set; }

        public void Draw(string message)
        {
            if (this.IsMonochrome)
            {
                PrintMessage(ConsoleColor.Gray, message);
            }

            else
            {
                PrintMessage(ConsoleColor.Green, message);
            }
        }

        internal void PrintMessage(ConsoleColor color, string message)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}
