using System;
using System.Collections.Generic;

namespace Computers
{
    class Computers
    {
        static Computer pc, laptop, server;
        public static void Main()
        {
            var manufacturer = Console.ReadLine();
            if (manufacturer == "HP")
            {
                var ram = new RamMemory(Eight / 4);
                var videoCard = new VideoCard()
                {
                    IsMonochrome = false
                };

                pc = new Computer(Type.PC, new Cpu(Eight / 4, 32, ram, videoCard), ram, new[] { new HardDriver(500, false, 0) }, videoCard, null);

                var serverRam = new RamMemory(Eight * 4);
                var serverVideo = new VideoCard();
                server = new Computer(Type.SERVER, new Cpu(Eight / 2, 32, serverRam, serverVideo), serverRam,
                    new List<HardDriver>{new HardDriver(0, true, 2, new List<HardDriver> { new HardDriver(1000, false, 0),
                        new HardDriver(1000, false, 0) })}, serverVideo, null);
                {
                    var card = new VideoCard()
                    {
                        IsMonochrome = false
                    };
                    var ram1 = new RamMemory(Eight / 2);
                    laptop = new Computer(Type.LAPTOP, new Cpu(Eight / 4, 64, ram1, card), ram1,
                        new[] { new HardDriver(500, false, 0) }, card, new LaptopBattery());
                }
            }
            else if (manufacturer == "Dell")
            {
                var ram = new RamMemory(Eight);
                var videoCard = new VideoCard(); // { IsMonochrome = false };
                pc = new Computer(Type.PC, new Cpu(Eight / 2, 64, ram, videoCard), ram, new[] { new HardDriver(1000, false, 0) }, videoCard, null);
                var ram1 = new RamMemory(Eight * Eight);
                var card = new VideoCard();
                server = new Computer(Type.SERVER, new Cpu(Eight, 64, ram1, card), ram1,
                     new List<HardDriver>{new HardDriver(0, true, 2, new List<HardDriver> { new HardDriver(2000, false, 0), 
                         new HardDriver(2000, false, 0) })}, card, null);
                var ram2 = new RamMemory(Eight);
                var videoCard1 = new VideoCard() { IsMonochrome = false };
                laptop = new Computer(Type.LAPTOP, new Cpu(Eight / 2, ((32)), ram2, videoCard1),
                    ram2, new[] { new HardDriver(1000, false, 0) }, videoCard1, new LaptopBattery());
            }
            else
            {
                throw new InvalidArgumentException("Invalid manufacturer!");
            }

            while (true)
            {
                var command = Console.ReadLine();
                if (command == null)
                {
                    break; 
                }

                if (command.StartsWith("Exit"))
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
                    laptop.ChargeBattery(commandValue);
                }
                else if (commandName == "Process")
                {
                    server.Process(commandValue);
                }
                else if (commandName == "Play")
                {
                    pc.Play(commandValue);
                }

                Console.WriteLine("Invalid command!");
            }

            //Wait user input
            Console.ReadLine();
        }

        //class Computer
        //{
        //    IEnumerable<HardDriver> HardDrives { get; set; }
        //    HardDriver VideoCard { get; set; }
        //    [Obsolete("")]
        //    internal void ChargeBattery(int percentage)
        //    {
        //        battery.Charge(percentage);
        //        VideoCard.Draw(string.Format("Battery status: {0}", battery.Percentage));
        //    }

        //    Cpu Cpu { get; set; }
        //    readonly LaptopBattery battery;
        //    RamMemory Ram { get; set; }

        //    public void Play(int guessNumber)
        //    {
        //        Cpu.rand(1, 10);
        //        var number = Ram.LoadValue();
        //        if (number != guessNumber)
        //        {
        //            VideoCard.Draw(string.Format("You didn't guess the number {0}.", number));
        //        }
        //        else
        //        {
        //            VideoCard.Draw("You win!");
        //        }
        //    }

        //    internal Computer(Computers.Type type, Cpu cpu, RamMemory ram, IEnumerable<HardDriver> hardDrives, HardDriver videoCard, LaptopBattery battery)
        //    {
        //        Cpu = cpu;
        //        Ram = ram;
        //        HardDrives = hardDrives;
        //        VideoCard = videoCard;
        //        if (type != Type.LAPTOP && type != Type.PC)
        //        {
        //            VideoCard.IsMonochrome = true;
        //        }

        //        this.battery = battery;
        //    }

        //    internal void Process(int data)
        //    {
        //        Ram.SaveValue(data);
        //        // TODO: Fix it
        //        Cpu.SquareNumber();
        //    }
        //}

        //public class InvalidArgumentException : ArgumentException
        //{
        //    public InvalidArgumentException(string message)
        //        : base(message)
        //    { 
        //    }
        //}

        const int Eight = 8;

    }
}
