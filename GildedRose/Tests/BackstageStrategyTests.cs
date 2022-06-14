using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace GildedRose.Tests
{
    public class BackstageStrategyTests : GildedRoseTest
    {

        // increase by 1 if sellin <= 11
        // increase by 2 if sellin <= 6 and < 11
        // increase by 3 if sellin < 6
        // quantity up to 50
        // decrease sellin
        // set quantity to 0 if sellin < 1
        [Fact]
        public void When_SellInGreaterEqualEleven_Then_IncreaseQuantityBy1()
        {
            var item = new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 11, Quality = 1 };
            RunGildedRoseUpdateQuantityForItem(item);
            Assert.Equal(2, item.Quality);
        }

        [Fact]
        public void When_SellInGreaterBetweenSixAndEleven_Then_IncreaseQuantityBy2()
        {
            var item = new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 7, Quality = 1 };
            RunGildedRoseUpdateQuantityForItem(item);
            Assert.Equal(3, item.Quality);
        }

        [Fact]
        public void When_SellInLessThanSix_Then_IncreaseQuantityBy3()
        {
            var item = new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 5, Quality = 1 };
            RunGildedRoseUpdateQuantityForItem(item);
            Assert.Equal(4, item.Quality);
        }

        [Theory]
        [InlineData(5, 48)]
        [InlineData(7, 49)]
        [InlineData(11, 50)]
        [InlineData(12, 50)]
        public void DontIncreaseQuantityAbove50(int sellin, int quantitiy)
        {
            var item = new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = sellin, Quality = quantitiy };
            RunGildedRoseUpdateQuantityForItem(item);
            Assert.Equal(50, item.Quality);
        }

        [Fact]
        public void SellInDecreased()
        {
            var item = new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 2, Quality = 1 };
            RunGildedRoseUpdateQuantityForItem(item);
            Assert.Equal(1, item.SellIn);
        }


        [Fact]
        public void When_SellInLessThanOne_Then_SetQuantityToZero()
        {
            var item = new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 0, Quality = 34 };
            RunGildedRoseUpdateQuantityForItem(item);
            Assert.Equal(0, item.Quality);
        }
    }
}
