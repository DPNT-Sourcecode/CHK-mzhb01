namespace BeFaster.App.Solutions.CHK
{
    public class FreeItemOffer : BaseSpecialOffer
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
