using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRose.Strategies
{
    internal class BackstageStrategy : IQualityUpdateStrategy
    {
        private const int QualityCap = 50;

        public void UpdateQuality(Item item)
        {
            IncreaseQualityByOneUpToCap(item);

            if (item.SellIn < 11)
            {
                IncreaseQualityByOneUpToCap(item);
            }

            if (item.SellIn < 6)
            {
                IncreaseQualityByOneUpToCap(item);
            }

            item.SellIn--;

            if (item.SellIn < 0)
            {
                item.Quality = 0;
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
