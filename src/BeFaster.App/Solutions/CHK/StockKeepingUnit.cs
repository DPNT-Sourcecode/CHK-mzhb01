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
            params SpecialOffer[] specialOffers)
        {
            Name = name;
            Price = price;
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


