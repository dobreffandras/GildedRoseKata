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
                if (item.Name == AgedBire)
                {
                    var strategy = new AgedBrieStrategy();
                    strategy.UpdateQuantity(item);
                }

                if (item.Name == Backstage)
                {
                    var strategy = new BackstageStrategy();
                    strategy.UpdateQuantity(item);
                }

                if (item.Name != AgedBire
                    && item.Name != Backstage
                    && item.Name != Sulfuras) 
                {
                    var strategy = new NormalStrategy();
                    strategy.UpdateQuantity(item);
                }
            }
        }
    }
}