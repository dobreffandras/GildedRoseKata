using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp
{
    internal class BackstageStrategy : IQuantityUpdateStrategy
    {
        public void UpdateQuantity(Item item)
        {
            if (item.Quality < 50)
            {
                item.Quality++;

                if (item.SellIn < 11)
                {
                    if (item.Quality < 50)
                    {
                        item.Quality++;
                    }
                }
                
                if (item.SellIn < 6)
                {
                    if (item.Quality < 50)
                    {
                        item.Quality++;
                    }
                }
            }

            item.SellIn--;

            if (item.SellIn < 0)
            {
                item.Quality = 0;
            }
        }
    }
}
