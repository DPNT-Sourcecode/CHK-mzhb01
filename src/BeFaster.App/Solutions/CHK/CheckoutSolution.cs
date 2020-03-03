using System.Linq;

namespace BeFaster.App.Solutions.CHK
{
    public static class CheckoutSolution
    {
        public static int ComputePrice(string skus)
        {
            var stockKeepingUnitRepository = new StockKeepingUnitRepository();
            var totalPrice = 0;

            var basketSkus = skus.Split(',').ToList();

            foreach (var sku in basketSkus)
            {
                var stockKeepingUnit = stockKeepingUnitRepository.GetBy(sku);

                if (stockKeepingUnit == null)
                    return -1;

                if (stockKeepingUnit.HasOffer())
                {

                }
                else
                {
                    totalPrice += stockKeepingUnit.Price;
                }
            }

            return totalPrice;
        }
    }
}


