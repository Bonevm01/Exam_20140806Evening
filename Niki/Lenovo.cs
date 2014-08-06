namespace Computers
{
    internal class Lenovo : Manifacturer
    {
        public Lenovo()
        {
            this.Name = "Lenovo";
        }

        internal override Laptop ProduceLaptop()
        {
            var motherBoardHPLaptop = new MotherBoard(new Cpu(2, 64), new RamMemory(16), new VideoCard());
            return new Laptop(motherBoardHPLaptop, new HardDriver(1000), new Battery());
        }

        internal override PersonalComputer ProducePC()
        {
            var motherBoardHPPC = new MotherBoard(new Cpu(2, 64), new RamMemory(4), new VideoCard());
            return new PersonalComputer(motherBoardHPPC, new HardDriver(2000));
        }

        internal override Server ProduceServer()
        {
            var motherBoardHPServer = new MotherBoard(new Cpu(2, 128), new RamMemory(8), new VideoCard());
            var raidofHD = new RaidOfHD();
            raidofHD.AddHD(new HardDriver(500));
            raidofHD.AddHD(new HardDriver(500));
            return new Server(motherBoardHPServer, raidofHD);
        }
    }
}
