namespace GildedRose.Tests
{
    public class GildedRoseTest
    {
        public void RunGildedRoseUpdateQualityForItem(Item item)
        {
            var g = new GildedRose(new List<Item> { item });
            g.UpdateQuality();
        }
    }
}
