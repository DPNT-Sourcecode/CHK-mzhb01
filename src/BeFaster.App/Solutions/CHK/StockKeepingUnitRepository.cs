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
                new StockKeepingUnit('A', 50, new SpecialOffer(3, 130), new SpecialOffer(5, 200)),
                new StockKeepingUnit('B', 30, new SpecialOffer(2, 45)),
                new StockKeepingUnit('C', 20),
                new StockKeepingUnit('D', 15),
                new StockKeepingUnit('E', 40, new SpecialOffer(2, 'B')),
                new StockKeepingUnit('F', 10, new SpecialOffer(3, 'F')),
                new StockKeepingUnit('G', 20),
                new StockKeepingUnit('H', 10, new SpecialOffer(5, 45), new SpecialOffer(10, 80)),
                new StockKeepingUnit('I', 35),
                new StockKeepingUnit('J', 60),
                new StockKeepingUnit('K', 80, new SpecialOffer(2, 150)),
                new StockKeepingUnit('L', 90),
                new StockKeepingUnit('M', 15),
                new StockKeepingUnit('N', 40, new SpecialOffer(3, 'M')),
                new StockKeepingUnit('O', 10),
                new StockKeepingUnit('P', 50, new SpecialOffer(5, 200)),
                new StockKeepingUnit('Q', 30, new SpecialOffer(3, 80)),
                new StockKeepingUnit('R', 50, new SpecialOffer(3, 'Q')),
                new StockKeepingUnit('S', 20, new SpecialOffer(3, 1, 45)),
                new StockKeepingUnit('T', 20, new SpecialOffer(3, 1, 45)),
                new StockKeepingUnit('U', 40, new SpecialOffer(4, 'U')),
                new StockKeepingUnit('V', 50, new SpecialOffer(2, 90), new SpecialOffer(3, 130)),
                new StockKeepingUnit('W', 20),
                new StockKeepingUnit('X', 17, new SpecialOffer(3, 1, 45)),
                new StockKeepingUnit('Y', 20, new SpecialOffer(3, 1, 45)),
                new StockKeepingUnit('Z', 21, new SpecialOffer(3, 1, 45))
            };
        }

        public StockKeepingUnit GetBy(char name)
        {
            return stockKeepingUnits.FirstOrDefault(s => s.Name == name);
        }
    }
}

