using csharp;

var quantitites = new[] { -1, 0, 1, 49, 50, 51 };
var sellins = new[] { -1, 0, 1, 5, 6, 7, 10, 11, 12 };
var names = new[] {
    "Anyname",
    "Aged Brie",
    "Backstage passes to a TAFKAL80ETC concert",
    "Sulfuras, Hand of Ragnaros",
};


var items = new List<Item>();
foreach(var n in names)
{
    foreach(var s in sellins)
    {
        foreach(var q in quantitites)
        {
            items.Add(new Item { Name = n, SellIn = s, Quality = q });
        }
    }
}

var gildedRose = new csharp.GildedRose(items);
gildedRose.UpdateQuality();

foreach(var item in gildedRose.Items)
{
    Console.WriteLine(item);
}
