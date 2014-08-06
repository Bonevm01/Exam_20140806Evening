namespace Computers
{
    internal class Battery
    {
        internal Battery()
        {
            this.PowerLeft = 50;
        }

        internal int PowerLeft { get; set; }

        internal void Charge(int newCharge)
        {
            this.PowerLeft += newCharge;
            if (this.PowerLeft > 100)
            {
                this.PowerLeft = 100;
            }

            if (this.PowerLeft < 0)
            {
                this.PowerLeft = 0;
            }
        }
    }
}
