using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computers
{
    class PersonalComputer : AbstractComputer
    {
        public PersonalComputer(MotherBoard motherBoard, IHardDrive hardDrives)
            : base(motherBoard, hardDrives)
        {
        }

        public void Play(int guessNumber)
        {
            //this.motherBoard.CPU.GenerateRandomNumber();
            var number = this.motherBoard.CPU.GenerateRandomNumber();
            if (number != guessNumber)
            {
                this.motherBoard.DrawOnVideoCard(string.Format("You didn't guess the number {0}.", number));
            }
            else
            {
                this.motherBoard.DrawOnVideoCard("You win!");
            }
        }
    }
}
