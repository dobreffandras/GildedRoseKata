namespace GildedRose
{
    internal class AgedBrieStrategy : IQuantityUpdateStrategy
    {
        private const int QuantityCap = 50;

        public void UpdateQuantity(Item item)
        {
            IncreaseQuantitiyByOneUpToCap(item);

            item.SellIn--;

            if (item.SellIn < 0)
            {
                IncreaseQuantitiyByOneUpToCap(item);
            }
        }

        private static void IncreaseQuantitiyByOneUpToCap(Item item)
        {
            if (item.Quality < QuantityCap)
            {
                item.Quality++;
            }
        }
    }
}
