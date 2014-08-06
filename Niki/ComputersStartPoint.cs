namespace Computers
{
    using System;

    internal class ComputersStartPoint
    {
        // static Computer pc, laptop, server;
        public static void Main()
        {
            var manufacturerName = Console.ReadLine();
            Manifacturer computerProducer;
            switch (manufacturerName)
            {
                case "HP":
                    computerProducer = new HP();
                    break;
                case "Dell":
                    computerProducer = new Dell();
                    break;
                case "Lenovo":
                    computerProducer = new Lenovo();
                    break;
                default:
                    throw new InvalidArgumentException("Invalid manufacturer!");
            }

            var laptop = computerProducer.ProduceLaptop();
            var personalComputer = computerProducer.ProducePC();
            var server = computerProducer.ProduceServer();

            while (true)
            {
                var command = Console.ReadLine();
                if (command == null)
                {
                    break;
                }

                if (command == "Exit")
                {
                    break;
                }

                var cp = command.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                if (cp.Length != 2)
                {
                    {
                        throw new ArgumentException("Invalid command!");
                    }
                }

                var commandName = cp[0];
                var commandValue = int.Parse(cp[1]);
                if (commandName == "Charge")
                {
                    laptop.Battery.Charge(commandValue);
                    string message = string.Format("Battery status: {0}%", laptop.Battery.PowerLeft);
                    laptop.MotherBoard.DrawOnVideoCard(message);
                }
                else if (commandName == "Process")
                {
                    server.Process(commandValue);
                }
                else if (commandName == "Play")
                {
                    personalComputer.Play(commandValue);
                }
            }

            Console.Read(); // Whait Enter to finish the run
        }
    }
}
