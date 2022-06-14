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
    Console.Write("new object[]{ ");
    Console.Write("new Item{ Name=\"" + originalItem.Name + "\", ");
    Console.Write("SellIn=" + originalItem.SellIn + ", ");
    Console.Write("Quality=" + originalItem.Quality + "},");
    Console.Write("new Item{ Name=\"" + updatedItem.Name + "\", ");
    Console.Write("SellIn=" + updatedItem.SellIn + ", ");
    Console.Write("Quality=" + updatedItem.Quality + "}");
    Console.Write("},");
    Console.WriteLine();
}
