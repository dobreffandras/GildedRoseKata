using Xunit;

namespace GildedRose
{
    public class AgedBrieStrategyTests : GildedRoseTest
    {
        [Fact]
        public void When_SellInGreaterEqualOne_Then_IncreaseQuantityBy1()
        {
            var item = new Item { Name = "Aged Brie", SellIn = 2, Quality = 1 };
            RunGildedRoseUpdateQuantityForItem(item);
            Assert.Equal(2, item.Quality);
        }

        [Fact]
        public void DontIncreaseQuantityAbove50()
        {
            var item = new Item { Name = "Aged Brie", SellIn = 2, Quality = 50 };
            RunGildedRoseUpdateQuantityForItem(item);
            Assert.Equal(50, item.Quality);
        }

        [Fact]
        public void SellInDecreased()
        {
            var item = new Item { Name = "Aged Brie", SellIn = 2, Quality = 1 };
            RunGildedRoseUpdateQuantityForItem(item);
            Assert.Equal(1, item.SellIn);
        }

        [Fact]
        public void When_SellInLessThanOne_Then_IncreaseQuantityBy2()
        {
            var item = new Item { Name = "Aged Brie", SellIn = 0, Quality = 1 };
            RunGildedRoseUpdateQuantityForItem(item);
            Assert.Equal(3, item.Quality);
        }
    }
}
