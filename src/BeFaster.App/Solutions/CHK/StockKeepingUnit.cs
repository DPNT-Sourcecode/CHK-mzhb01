using System.Collections.Generic;
using System.Linq;

namespace BeFaster.App.Solutions.CHK
{
    public class StockKeepingUnit
    {
        public char Name { get; private set; }
        public int Price { get; private set; }
        public IEnumerable<Discount> SpecialOffers { get; private set; }

        private StockKeepingUnit()
        { }

        public StockKeepingUnit(
            char name,
            int price,
            params Discount[] specialOffers)
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
    }
}

