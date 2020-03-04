namespace BeFaster.App.Solutions.CHK
{
    public abstract class BaseSpecialOffer
    {
        public int Units { get; private set; }
        public OfferType Type { get; private set; }

        private BaseSpecialOffer()
        { }

        public BaseSpecialOffer(int units)
        {
            Units = units;
        }
    }
}

