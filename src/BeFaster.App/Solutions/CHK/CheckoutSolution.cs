namespace BeFaster.App.Solutions.CHK
{
    public static class CheckoutSolution
    {
        public static int ComputePrice(string skus)
        {
            var skusPriceTable = new StockKeepingUnitRepository().GetAll();
            var totalPrice = 0;

            var items = skus.Split(',');

            return totalPrice;
        }
    }
}

