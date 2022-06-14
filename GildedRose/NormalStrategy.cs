using System;
namespace csharp
{
    internal class NormalStrategy : IQuantityUpdateStrategy
    {
        public void UpdateQuantity(Item item)
        {
            if (item.Quality > 0)
            {
                item.Quality--;
            }

            item.SellIn--;

            if (item.SellIn < 0 && item.Quality > 0)
            {
                item.Quality--;
            }
        }
    }
}
