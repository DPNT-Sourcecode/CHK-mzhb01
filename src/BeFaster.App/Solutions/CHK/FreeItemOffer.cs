namespace BeFaster.App.Solutions.CHK
{
    public class FreeItemOffer : SpecialOffer
    {
        public char FreeItem { get; private set; }

        public FreeItemOffer(int units, char freeItem)
            : base(units)
        {
            FreeItem = freeItem;
            Type = OfferType.freeItem;
        }
    }
}

