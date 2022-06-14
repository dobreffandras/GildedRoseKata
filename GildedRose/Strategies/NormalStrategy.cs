using System;
namespace GildedRose.Strategies
{
    internal class NormalStrategy : IQualityUpdateStrategy
    {
        public void UpdateQuality(Item item)
        {
            DecreaseQualityByOne(item);

            item.SellIn--;

            if (item.SellIn < 0)
            {
                DecreaseQualityByOne(item);
            }
        }

        private void DecreaseQualityByOne(Item item)
        {
            if (item.Quality > 0)
            {
                item.Quality--;
            }
        }
    }
}
