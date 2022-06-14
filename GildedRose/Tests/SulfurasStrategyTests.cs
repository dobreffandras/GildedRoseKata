using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace GildedRose.Tests
{
    public class SulfurasStrategyTests : GildedRoseTest
    {
        [Theory]
        [InlineData(0, 0)]
        [InlineData(0, 1)]
        [InlineData(1, 0)]
        [InlineData(1, 1)]
        [InlineData(1, 50)]
        [InlineData(1, 49)]
        [InlineData(11, 49)]
        [InlineData(6, 49)]
        public void ItemNotChanged(int sellin, int quality)
        {
            var item = new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = sellin, Quality = quality };
            RunGildedRoseUpdateQualityForItem(item);
            Assert.Equal(sellin, item.SellIn);
            Assert.Equal(quality, item.Quality);
        }
    }
}
