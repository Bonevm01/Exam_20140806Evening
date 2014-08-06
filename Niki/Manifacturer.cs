namespace Computers
{
    public abstract class Manifacturer
    {
        public string Name { get; set; }
        
        internal abstract Laptop ProduceLaptop();

        internal abstract PersonalComputer ProducePC();

        internal abstract Server ProduceServer();
    }
}
