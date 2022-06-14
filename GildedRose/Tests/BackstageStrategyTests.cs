using Xunit;

namespace GildedRose.Tests
{
    public class BackstageStrategyTests : GildedRoseTest
    {
        [Fact]
        public void When_SellInGreaterEqualEleven_Then_IncreaseQualityBy1()
        {
            var item = new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 11, Quality = 1 };
            RunGildedRoseUpdateQualityForItem(item);
            Assert.Equal(2, item.Quality);
        }

        [Fact]
        public void When_SellInGreaterBetweenSixAndEleven_Then_IncreaseQualityBy2()
        {
            var item = new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 7, Quality = 1 };
            RunGildedRoseUpdateQualityForItem(item);
            Assert.Equal(3, item.Quality);
        }

        [Fact]
        public void When_SellInLessThanSix_Then_IncreaseQualityBy3()
        {
            var item = new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 5, Quality = 1 };
            RunGildedRoseUpdateQualityForItem(item);
            Assert.Equal(4, item.Quality);
        }

        [Theory]
        [InlineData(5, 48)]
        [InlineData(7, 49)]
        [InlineData(11, 50)]
        [InlineData(12, 50)]
        public void DontIncreaseQualityAbove50(int sellin, int quality)
        {
            var item = new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = sellin, Quality = quality };
            RunGildedRoseUpdateQualityForItem(item);
            Assert.Equal(50, item.Quality);
        }

        [Fact]
        public void SellInDecreased()
        {
            var item = new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 2, Quality = 1 };
            RunGildedRoseUpdateQualityForItem(item);
            Assert.Equal(1, item.SellIn);
        }


        [Fact]
        public void When_SellInLessThanOne_Then_SetQualityToZero()
        {
            var item = new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 0, Quality = 34 };
            RunGildedRoseUpdateQualityForItem(item);
            Assert.Equal(0, item.Quality);
        }
    }
}
