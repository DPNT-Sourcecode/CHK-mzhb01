using System.Collections.Generic;
using System.Linq;

namespace BeFaster.App.Solutions.CHK
{
    public static class CheckoutSolution
    {
        public static int ComputePrice(string skus)
        {
            var stockKeepingUnitRepository = new StockKeepingUnitRepository();
            var stockKeepingUnits = new List<StockKeepingUnit>();
            var totalPriceNoOffer = 0;
            var totalPriceOffer = 0;
            var totalPrice = 0;

            var basketSkus = skus.Split(',').ToList();

            foreach (var sku in basketSkus)
            {
                var stockKeepingUnit = stockKeepingUnitRepository.GetBy(sku);

                if (stockKeepingUnit == null)
                    return -1;

                stockKeepingUnits.Add(stockKeepingUnit);
            }

            totalPriceNoOffer = stockKeepingUnits.Where(s => !s.HasOffer()).Sum(s => s.Price);

            var skusWithOffer = stockKeepingUnits.Where(s => s.HasOffer()).GroupBy(s => s.Name);
            


            return totalPrice;
        }
    }
}


