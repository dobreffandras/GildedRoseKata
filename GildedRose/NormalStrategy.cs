using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp
{
    internal class NormalStrategy : IQuantityUpdateStrategy
    {
        public void UpdateQuantity(Item item)
        {
            if (item.Quality > 0)
            {
                item.Quality = item.Quality - 1;
            }

            item.SellIn = item.SellIn - 1; // Decrease SellIn for normal case

            if (item.SellIn < 0 && item.Quality > 0)
            {
                item.Quality = item.Quality - 1; // Decrease Quantity for normal case if sellIn is below zero
            }
        }
    }
}
