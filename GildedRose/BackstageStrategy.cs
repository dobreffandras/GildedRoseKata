using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRose
{
    internal class BackstageStrategy : IQuantityUpdateStrategy
    {
        private const int QuantityCap = 50;

        public void UpdateQuantity(Item item)
        {
            IncreaseQuantitiyByOneUpToCap(item);

            if (item.SellIn < 11)
            {
                IncreaseQuantitiyByOneUpToCap(item);
            }

            if (item.SellIn < 6)
            {
                IncreaseQuantitiyByOneUpToCap(item);
            }

            item.SellIn--;

            if (item.SellIn < 0)
            {
                item.Quality = 0;
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
