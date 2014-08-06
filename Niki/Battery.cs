namespace Computers
{
    internal class Battery
    {
        internal int PowerLeft { get; set; }

        internal Battery()
        {
            this.PowerLeft = 50;
        }

        internal void Charge(int newCharge)
        {
            PowerLeft += newCharge;
            if (PowerLeft > 100)
            {
                PowerLeft = 100;
            }

            if (PowerLeft < 0)
            {
                PowerLeft = 0;
            }
        }
    }
}
