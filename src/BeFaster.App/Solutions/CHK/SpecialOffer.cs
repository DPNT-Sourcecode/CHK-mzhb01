namespace BeFaster.App.Solutions.CHK
{
    public class SpecialOffer
    {
        public int Units { get; private set; }
        public int Price { get; private set; }

        private SpecialOffer()
        { }

        public SpecialOffer(int units, int price)
        {
            Units = units;
            Price = price;
        }
    }
}
