namespace BeFaster.App.Solutions.CHK
{
    public class DiscountOffer : BaseSpecialOffer
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
