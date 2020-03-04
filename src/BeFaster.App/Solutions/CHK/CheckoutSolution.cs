using System;
using System.Collections.Generic;
using System.Linq;

namespace BeFaster.App.Solutions.CHK
{
    public static class CheckoutSolution
    {
        public static int ComputePrice(string skus)
        {
            return Checkout(skus);
        }

        public static int Checkout(string skus)
        {
            var stockKeepingUnitRepository = new StockKeepingUnitRepository();
            var stockKeepingUnits = new List<StockKeepingUnit>();

            foreach (var sku in skus.ToCharArray().ToList())
            {
                var stockKeepingUnit = stockKeepingUnitRepository.GetBy(sku);

                if (stockKeepingUnit == null)
                    return -1;

                stockKeepingUnits.Add(stockKeepingUnit);
            }

            RemoveFreeItems(stockKeepingUnits);

            var totalPriceNoOffer = CalculTotalPriceWithoutDiscount(stockKeepingUnits);
            var totalPriceDiscount = ApplyDiscount(stockKeepingUnits);
            var totalPriceDiscountGroup = ApplyDiscountGroup(stockKeepingUnits);

            return totalPriceNoOffer + totalPriceDiscount + totalPriceDiscountGroup;
        }

        private static int CalculTotalPriceWithoutDiscount(List<StockKeepingUnit> stockKeepingUnits)
        {
            return stockKeepingUnits.Where(s => !s.HasDiscount() && !s.HasDiscountGroup()).Sum(s => s.Price);
        }

        private static int ApplyDiscount(List<StockKeepingUnit> stockKeepingUnits)
        {
            var totalPrice = 0;

            foreach (var skuGrouped in stockKeepingUnits.Where(s => s.HasDiscount()).GroupBy(s => s.Name))
            {
                var priceOffer = 0;
                var priceNoOffer = 0;
                var remainingSkus = skuGrouped.Count();
                var groupedOffers = skuGrouped
                    .First()
                    .SpecialOffers
                        .Where(o => o.Type == OfferType.discount)
                        .OrderByDescending(o => o.Units);

                foreach (var groupedOffer in groupedOffers)
                {
                    var nbSkuApplied = (int)Math.Truncate((decimal)remainingSkus / groupedOffer.Units);
                    priceOffer += nbSkuApplied * groupedOffer.Price.Value;

                    remainingSkus = remainingSkus - (nbSkuApplied * groupedOffer.Units);
                }

                if (remainingSkus > 0)
                {
                    priceNoOffer += remainingSkus * skuGrouped.First().Price;
                }

                totalPrice += priceOffer + priceNoOffer;
            }

            return totalPrice;
        }

        private static void RemoveFreeItems(List<StockKeepingUnit> stockKeepingUnits)
        {
            var skuFreeItems = stockKeepingUnits.Where(s => s.HasFreeItem()).GroupBy(s => s.Name);

            foreach (var skuFreeItem in skuFreeItems)
            {
                var offers = skuFreeItem.First().SpecialOffers.OrderByDescending(o => o.Units);

                foreach (var offer in offers)
                {
                    var nbFreeItem = (int)Math.Truncate((decimal)skuFreeItem.Count() / offer.Units);

                    stockKeepingUnits.Where(s => s.Name == offer.FreeItem)
                        .Take(nbFreeItem)
                        .ToList()
                        .ForEach(s => stockKeepingUnits.Remove(s));
                }
            }
        }

        private static int ApplyDiscountGroup(List<StockKeepingUnit> stockKeepingUnits)
        {
            var totalPrice = 0;
            var skuWithDiscountGroup = stockKeepingUnits
                .Where(s => s.HasDiscountGroup())
                .GroupBy(s => s.SpecialOffers.FirstOrDefault(o => o.Type == OfferType.discountGroup).GroupId);

            return totalPrice;
        }
    }
}


