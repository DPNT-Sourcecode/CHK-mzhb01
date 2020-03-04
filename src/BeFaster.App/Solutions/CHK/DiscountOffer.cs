namespace BeFaster.App.Solutions.CHK
{
    public class DiscountOffer : SpecialOffer
    {
        public int? Price { get; private set; }

        public DiscountOffer(int units, int price)
            : base(units)
        {
            Price = price;
            Type = OfferType.discount;
        }
    }
}

