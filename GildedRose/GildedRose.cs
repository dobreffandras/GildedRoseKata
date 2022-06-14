using System.Collections.Generic;

namespace csharp
{
    public class GildedRose
    {
        private const string AgedBire = "Aged Brie";
        private const string Backstage = "Backstage passes to a TAFKAL80ETC concert";
        private const string Sulfuras = "Sulfuras, Hand of Ragnaros";
        internal IList<Item> Items;
        public GildedRose(IList<Item> Items)
        {
            this.Items = Items;
        }

        public void UpdateQuality()
        {
            foreach (Item item in Items)
            {
                IQuantityUpdateStrategy strategy = item.Name switch
                {
                    AgedBire => new AgedBrieStrategy(),
                    Backstage => new BackstageStrategy(),
                    Sulfuras => new SulfurasStrategy(),
                    _ => new NormalStrategy()
                };

                strategy.UpdateQuantity(item);
            }
        }
    }
}