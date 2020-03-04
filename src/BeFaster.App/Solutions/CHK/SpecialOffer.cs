namespace BeFaster.App.Solutions.CHK
{
    public abstract class SpecialOffer
    {
        public int Units { get; private set; }
        public OfferType Type { get; protected set; }

        private SpecialOffer()
        { }

        public SpecialOffer(int units)
        {
            Units = units;
        }
    }
}
