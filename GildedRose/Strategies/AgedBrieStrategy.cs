namespace GildedRose.Strategies
{
    internal class AgedBrieStrategy : IQualityUpdateStrategy
    {
        private const int QualityCap = 50;

        public void UpdateQuality(Item item)
        {
            IncreaseQualityByOneUpToCap(item);

            item.SellIn--;

            if (item.SellIn < 0)
            {
                IncreaseQualityByOneUpToCap(item);
            }
        }

        private static void IncreaseQualityByOneUpToCap(Item item)
        {
            if (item.Quality < QualityCap)
            {
                item.Quality++;
            }
        }
    }
}
