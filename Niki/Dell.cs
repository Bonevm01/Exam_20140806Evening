namespace Computers
{
    internal class Dell : Manifacturer
    {
        public Dell()
        {
            this.Name = "DELL";
        }

        internal override Laptop ProduceLaptop()
        {
            var motherBoardHPLaptop = new MotherBoard(new Cpu(2, 32), new RamMemory(8), new VideoCard());
            return new Laptop(motherBoardHPLaptop, new HardDriver(1000), new Battery());
        }

        internal override PersonalComputer ProducePC()
        {
            var motherBoardHPPC = new MotherBoard(new Cpu(4, 64), new RamMemory(8), new VideoCard());
            return new PersonalComputer(motherBoardHPPC, new HardDriver(1000));
        }

        internal override Server ProduceServer()
        {
            var motherBoardHPServer = new MotherBoard(new Cpu(8, 64), new RamMemory(64), new VideoCard());
            var raidofHD = new RaidOfHD();
            raidofHD.AddHD(new HardDriver(2000));
            raidofHD.AddHD(new HardDriver(2000));
            return new Server(motherBoardHPServer, raidofHD);
        }
    }
}
