using System.Collections.Generic;
using System.Linq;

namespace BeFaster.App.Solutions.CHK
{
    public class StockKeepingUnit
    {
        public char Name { get; private set; }
        public int Price { get; private set; }
        public IEnumerable<SpecialOffer> SpecialOffers { get; private set; }

        private StockKeepingUnit()
        { }

        public StockKeepingUnit(
            char name,
            int price,
            params SpecialOffer[] specialOffers)
        {
            Name = name;
            Price = price;
            SpecialOffers = specialOffers;
        }

        public bool HasDiscount()
        {
            return SpecialOffers.Where(o => o.Type == OfferType.discount).Any();
        }

        public bool HasFreeItem()
        {
            return SpecialOffers.Where(o => o.Type == OfferType.freeItem).Any();
        }

        public bool HasDiscountGroup()
        {
            return SpecialOffers.Where(o => o.Type == OfferType.discountGroup).Any();
        }
    }
}

