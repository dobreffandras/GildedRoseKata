using GildedRose;

var quantitites = new[] { -1, 0, 1, 49, 50, 51 };
var sellins = new[] { -1, 0, 1, 5, 6, 7, 10, 11, 12 };
var names = new[] {
    "Anyname",
    "Aged Brie",
    "Backstage passes to a TAFKAL80ETC concert",
    "Sulfuras, Hand of Ragnaros",
};


var originalItems = new List<Item>();
var items = new List<Item>();
foreach (var n in names)
{
    foreach(var s in sellins)
    {
        foreach(var q in quantitites)
        {
            originalItems.Add(new Item { Name = n, SellIn = s, Quality = q }); 
            items.Add(new Item { Name = n, SellIn = s, Quality = q }); // create a separate instance purposely because its mutable
        }
    }
}

var gildedRose = new GildedRose.GildedRose(items);
gildedRose.UpdateQuality();

for (int i = 0; i < items.Count; i++)
{
    Item originalItem = originalItems[i];
    Item? updatedItem = items[i];
    Console.WriteLine($"new object[] {{ " +
        $"new Item{{ Name=\"{originalItem.Name}\", SellIn={originalItem.SellIn}, Quality={originalItem.Quality} }}," +
        $"new Item{{ Name=\"{updatedItem.Name}\", SellIn={updatedItem.SellIn}, Quality={updatedItem.Quality} }}" +
        $"}},");
}
