using Xunit;

namespace GildedRose.Tests
{
    public class NormalStrategyTests : GildedRoseTest
    {

        [Fact]
        public void When_SellInGreaterEqualOne_Then_DecreaseQualityBy1()
        {
            var item = new Item { Name = "AnyName", SellIn = 2, Quality = 1 };
            RunGildedRoseUpdateQualityForItem(item);
            Assert.Equal(0, item.Quality);
        }

        [Fact]
        public void DontDecreaseZeroQuality()
        {
            var item = new Item { Name = "AnyName", SellIn = 2, Quality = 0 };
            RunGildedRoseUpdateQualityForItem(item);
            Assert.Equal(0, item.Quality);
        }

        [Fact]
        public void SellInDecreased()
        {
            var item = new Item { Name = "AnyName", SellIn = 2, Quality = 1 };
            RunGildedRoseUpdateQualityForItem(item);
            Assert.Equal(1, item.SellIn);
        }

        [Fact]
        public void When_SellInLessThanOne_Then_DecreaseQualityBy2()
        {
            var item = new Item { Name = "AnyName", SellIn = 0, Quality = 3 };
            RunGildedRoseUpdateQualityForItem(item);
            Assert.Equal(1, item.Quality);
        }
    }
}
