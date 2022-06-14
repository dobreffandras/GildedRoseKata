namespace csharp
{
    internal class AgedBrieStrategy : IQuantityUpdateStrategy
    {
        public void UpdateQuantity(Item item)
        {
            if (item.Quality < 50)
            {
                item.Quality++;
            }

            item.SellIn--;

            if (item.SellIn < 0)
            {
                if (item.Quality < 50)
                {
                    item.Quality++;
                }
            }
        }
    }
}
