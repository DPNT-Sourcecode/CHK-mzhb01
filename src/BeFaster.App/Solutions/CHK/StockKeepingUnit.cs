using System;

namespace BeFaster.App.Solutions.CHK
{
    public class StockKeepingUnit
    {
        public char Name { get; private set; }
        public int Price { get; private set; }
        public SpecialOffer SpecialOffer { get; private set; }

        private StockKeepingUnit()
        { }

        public StockKeepingUnit(
            char name,
            int price,
            SpecialOffer specialOffer = null)
        {
            Name = name;
            Price = price;
            SpecialOffer = specialOffer;
        }

        public bool HasOffer()
        {
            return SpecialOffer != null;
        }
    }
}
