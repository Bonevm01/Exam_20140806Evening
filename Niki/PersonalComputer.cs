namespace Computers
{
    internal class PersonalComputer : AbstractComputer
    {
        public PersonalComputer(MotherBoard motherBoard, IHardDrive hardDrives)
            : base(motherBoard, hardDrives)
        {
        }

        public void Play(int guessNumber)
        {
            var number = this.MotherBoard.CPU.GenerateRandomNumber();
            if (number != guessNumber)
            {
                this.MotherBoard.DrawOnVideoCard(string.Format("You didn't guess the number {0}.", number));
            }
            else
            {
                this.MotherBoard.DrawOnVideoCard("You win!");
            }
        }
    }
}
