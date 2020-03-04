using System;
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
            var totalPrice = 0;

            var basketSkus = skus.ToCharArray().ToList();

            foreach (var sku in basketSkus)
            {
                var stockKeepingUnit = stockKeepingUnitRepository.GetBy(sku);

                if (stockKeepingUnit == null)
                    return -1;

                stockKeepingUnits.Add(stockKeepingUnit);
            }

            totalPrice += stockKeepingUnits.Where(s => !s.HasOffers()).Sum(s => s.Price);

            foreach (var skuWithOffer in stockKeepingUnits.Where(s => s.HasOffers()).GroupBy(s => s.Name))
            {
                var specialOffer = skuWithOffer.First().SpecialOffer;
                var unitOfferApplied = (int)Math.Truncate((decimal)(skuWithOffer.Count() / specialOffer.Units));

                var priceOffer = unitOfferApplied * specialOffer.Price;

                var priceNoOffer =
                    (skuWithOffer.Count() - (unitOfferApplied * specialOffer.Units)) * skuWithOffer.First().Price;

                totalPrice += priceOffer + priceNoOffer;
            }

            return totalPrice;
        }

        public static int Checkout(string skus)
        {
            var stockKeepingUnitRepository = new StockKeepingUnitRepository();
            var stockKeepingUnits = new List<StockKeepingUnit>();
            var totalPrice = 0;

            var basketSkus = skus.ToCharArray().ToList();

            foreach (var sku in basketSkus)
            {
                var stockKeepingUnit = stockKeepingUnitRepository.GetBy(sku);

                if (stockKeepingUnit == null)
                    return -1;

                stockKeepingUnits.Add(stockKeepingUnit);
            }

            totalPrice += stockKeepingUnits.Where(s => !s.HasOffers()).Sum(s => s.Price);

            foreach (var skuWithOffer in stockKeepingUnits.Where(s => s.HasOffers()).GroupBy(s => s.Name))
            {
                var specialOffer = skuWithOffer.First().SpecialOffer;
                var unitOfferApplied = (int)Math.Truncate((decimal)(skuWithOffer.Count() / specialOffer.Units));

                var priceOffer = unitOfferApplied * specialOffer.Price;

                var priceNoOffer =
                    (skuWithOffer.Count() - (unitOfferApplied * specialOffer.Units)) * skuWithOffer.First().Price;

                totalPrice += priceOffer + priceNoOffer;
            }

            return totalPrice;
        }
    }
}
