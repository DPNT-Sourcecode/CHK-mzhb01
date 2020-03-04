namespace BeFaster.App.Solutions.CHK
{
    public class Discount : BaseSpecialOffer
    {
        public int? Price { get; private set; }
        public char FreeItem { get; private set; }

        public Discount(int units, int price)
            : base(units)
        {
            Price = price;
            Type = OfferType.discount;
        }

        //public SpecialOffer(int units, char freeItem)
        //{
        //    Units = units;
        //    FreeItem = freeItem;
        //    Type = OfferType.freeItem;
        //}

    }
}

