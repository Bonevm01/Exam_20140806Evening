//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Computers
//{
//    class Computer
//    {

//        IEnumerable<HardDriver> HardDrives { get; set; }
//        VideoCard VideoCard { get; set; }
//        Cpu Cpu { get; set; }
//        readonly Battery battery;
//        RamMemory Ram { get; set; }

//        internal void ChargeBattery(int percentage)
//        {
//            battery.Charge(percentage);
//            VideoCard.Draw(string.Format("Battery status: {0}", battery.PowerLeft));
//        }

//        public void Play(int guessNumber)
//        {
//            Cpu.SaveRandomNumber(1, 10);
//            var number = Ram.LoadValue();
//            if (number != guessNumber)
//            {
//                VideoCard.Draw(string.Format("You didn't guess the number {0}.", number));
//            }
//            else
//            {
//                VideoCard.Draw("You win!");
//            }
//        }

//        internal Computer(Type type, Cpu cpu, RamMemory ram, IEnumerable<HardDriver> hardDrives, VideoCard videoCard, Battery battery)
//        {
//            Cpu = cpu;
//            Ram = ram;
//            HardDrives = hardDrives;
//            VideoCard = videoCard;
//            if (type != Type.LAPTOP && type != Type.PC)
//            {
//                VideoCard.IsMonochrome = true;
//            }

//            this.battery = battery;
//        }

//        internal void Process(int data)
//        {
//            Ram.SaveValue(data);
//            // TODO: Fix it
//            Cpu.ReturnSquareNumber();
//        }
//    }
//}
