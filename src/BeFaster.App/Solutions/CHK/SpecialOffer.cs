namespace BeFaster.App.Solutions.CHK
{
    public class SpecialOffer
    {
        public int Units { get; private set; }
        public int? Price { get; private set; }
        public char FreeItem { get; private set; }
        public OfferType Type { get; private set; }
        public int? GroupId { get; private set; }

        private SpecialOffer()
        { }

        public SpecialOffer(int units, int price)
        {
            Units = units;
            Price = price;
            Type = OfferType.discount;
        }

        public SpecialOffer(int units, char freeItem)
        {
            Units = units;
            FreeItem = freeItem;
            Type = OfferType.freeItem;
        }

        public SpecialOffer(int units, int groupId, int price)
        {
            Units = units;
            GroupId = groupId;
            Price = price;
            Type = OfferType.discountGroup;
        }
    }
}
