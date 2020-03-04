using System.Collections.Generic;
using System.Linq;

namespace BeFaster.App.Solutions.CHK
{
    public class StockKeepingUnit
    {
        public char Name { get; private set; }
        public int Price { get; private set; }
        public SpecialOffer SpecialOffer { get; private set; }
        public IEnumerable<SpecialOffer> SpecialOffers { get; private set; }

        private StockKeepingUnit()
        { }

        public StockKeepingUnit(
            char name,
            int price,
            SpecialOffer specialOffer = null,
            IEnumerable<SpecialOffer> specialOffers = null)
        {
            Name = name;
            Price = price;
            SpecialOffer = specialOffer;
            SpecialOffers = specialOffers;
        }

        public bool HasOffer()
        {
            return SpecialOffer != null;
        }

        public bool HasOffers()
        {
            return SpecialOffers.Any();
        }
    }
}

