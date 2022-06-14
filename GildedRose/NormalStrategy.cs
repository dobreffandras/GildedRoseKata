using System;
namespace GildedRose
{
    internal class NormalStrategy : IQuantityUpdateStrategy
    {
        public void UpdateQuantity(Item item)
        {
            DecreaseQuantityByOne(item);

            item.SellIn--;

            if (item.SellIn < 0)
            {
                DecreaseQuantityByOne(item);
            }
        }

        private void DecreaseQuantityByOne(Item item)
        {
            if (item.Quality > 0)
            {
                item.Quality--;
            }
        }
    }
}
