namespace Computers
{
    using System;

    internal class VideoCard
    {
        public bool IsMonochrome { get; set; }

        public void Draw(string message)
        {
            if (this.IsMonochrome)
            {
                this.PrintMessage(ConsoleColor.Gray, message);
            }
            else
            {
                this.PrintMessage(ConsoleColor.Green, message);
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
