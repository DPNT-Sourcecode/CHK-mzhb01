namespace BeFaster.App.Solutions.CHK
{
    public class StockKeepingUnit
    {
        public string Name { get; private set; }
        public int Price { get; private set; }
        public SpecialOffer SpecialOffer { get; private set; }

        private StockKeepingUnit()
        { }

        public StockKeepingUnit(
            string name,
            int price,
            SpecialOffer specialOffer = null)
        {
            Name = name;
            Price = price;
            SpecialOffer = specialOffer;
        }
    }
}

