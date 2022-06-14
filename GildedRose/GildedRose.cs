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
            for (var i = 0; i < Items.Count; i++)
            {
                if (Items[i].Name == AgedBire)
                {
                    if (Items[i].Quality < 50)
                    {
                        Items[i].Quality = Items[i].Quality + 1;
                    }
                }

                if (Items[i].Name == Backstage)
                {
                    if (Items[i].Quality < 50)
                    {
                        Items[i].Quality = Items[i].Quality + 1;

                        if (Items[i].SellIn < 11)
                        {
                            if (Items[i].Quality < 50)
                            {
                                Items[i].Quality = Items[i].Quality + 1;
                            }
                        }

                        if (Items[i].SellIn < 6)
                        {
                            if (Items[i].Quality < 50)
                            {
                                Items[i].Quality = Items[i].Quality + 1;
                            }
                        }
                    }
                    
                }

                if (Items[i].Name != AgedBire 
                    && Items[i].Name != Backstage
                    && Items[i].Name != Sulfuras
                    && Items[i].Quality > 0) // Decrease Quantity for normal case
                {
                    Items[i].Quality = Items[i].Quality - 1;
                }

                if (Items[i].Name == AgedBire) // Decrease SellIn for AgedBrie
                {
                    Items[i].SellIn = Items[i].SellIn - 1;
                }

                if (Items[i].Name == Backstage) // Decrease SellIn BackStage
                {
                    Items[i].SellIn = Items[i].SellIn - 1;
                }


                if (Items[i].Name != Backstage 
                    && Items[i].Name != AgedBire 
                    && Items[i].Name != Sulfuras) // Decrease SellIn for Normal
                {
                    Items[i].SellIn = Items[i].SellIn - 1;
                }

                if (Items[i].Name != AgedBire
                    && Items[i].Name != Backstage
                    && Items[i].Name != Sulfuras 
                    && Items[i].Quality > 0) // Decrease Quantity for normal case
                {
                    if (Items[i].SellIn < 0)
                    {
                        Items[i].Quality = Items[i].Quality - 1;
                    }
                }

                if(Items[i].Name == AgedBire)
                {
                    if (Items[i].SellIn < 0)
                    {
                        if (Items[i].Quality < 50)
                        {
                            Items[i].Quality = Items[i].Quality + 1;
                        }
                    }
                }

                if (Items[i].Name == Backstage)
                {
                    if (Items[i].SellIn < 0)
                    {
                        Items[i].Quality = Items[i].Quality - Items[i].Quality;
                    }
                }

            }
        }
    }
}