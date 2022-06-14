using GildedRose.Strategies;
using System.Collections.Generic;

namespace GildedRose
{
    public class GildedRose
    {
        private const string AgedBire = "Aged Brie";
        private const string Backstage = "Backstage passes to a TAFKAL80ETC concert";
        private const string Sulfuras = "Sulfuras, Hand of Ragnaros";
        
        IList<Item> Items;
        public GildedRose(IList<Item> Items)
        {
            this.Items = Items;
        }

        public void UpdateQuality()
        {
            foreach (Item item in Items)
            {
                IQualityUpdateStrategy strategy = item.Name switch
                {
                    AgedBire => new AgedBrieStrategy(),
                    Backstage => new BackstageStrategy(),
                    Sulfuras => new SulfurasStrategy(),
                    _ => new NormalStrategy()
                };

                strategy.UpdateQuality(item);
            }
        }
    }
}