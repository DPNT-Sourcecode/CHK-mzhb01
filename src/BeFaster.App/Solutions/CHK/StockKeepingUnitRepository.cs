using System.Collections.Generic;
using System.Linq;

namespace BeFaster.App.Solutions.CHK
{
    public class StockKeepingUnitRepository
    {
        private IEnumerable<StockKeepingUnit> stockKeepingUnits;

        public StockKeepingUnitRepository()
        {
            stockKeepingUnits = new List<StockKeepingUnit>
            {
                new StockKeepingUnit('A', 50, new SpecialOffer(3, 130)),
                new StockKeepingUnit('B', 30, new SpecialOffer(2, 45)),
                new StockKeepingUnit('C', 20),
                new StockKeepingUnit('D', 15)
                new StockKeepingUnit('E', 40)
            };
        }

        public StockKeepingUnit GetBy(char name)
        {
            return stockKeepingUnits.FirstOrDefault(s => s.Name == name);
        }
    }
}

