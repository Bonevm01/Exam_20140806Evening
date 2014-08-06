namespace Computers
{
    public class HP : Manifacturer
    {
        public HP()
        {
            this.Name = "HP";
        }

        internal override Laptop ProduceLaptop()
        {
            var motherBoardHPLaptop = new MotherBoard(new Cpu(2, 64), new RamMemory(4), new VideoCard());
            return new Laptop(motherBoardHPLaptop, new HardDriver(500), new Battery());
        }

        internal override PersonalComputer ProducePC()
        {
            var motherBoardHPPC = new MotherBoard(new Cpu(2, 32), new RamMemory(2), new VideoCard());
            return new PersonalComputer(motherBoardHPPC, new HardDriver(500));
        }

        internal override Server ProduceServer()
        {
            var motherBoardHPServer = new MotherBoard(new Cpu(4, 32), new RamMemory(32), new VideoCard());
            var raidofHD = new RaidOfHD();
            raidofHD.AddHD(new HardDriver(1000));
            raidofHD.AddHD(new HardDriver(1000));
            return new Server(motherBoardHPServer, raidofHD);
        }
    }
}
