using csharp;

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

var gildedRose = new csharp.GildedRose(items);
gildedRose.UpdateQuality();

for (int i = 0; i < gildedRose.Items.Count; i++)
{
    Item originalItem = originalItems[i];
    Item? updatedItem = gildedRose.Items[i];
    Console.Write(originalItem);
    Console.Write("  ->  ");
    Console.Write(updatedItem);
    Console.WriteLine();
}
