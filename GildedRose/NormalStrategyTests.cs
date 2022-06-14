using Xunit;

namespace GildedRose
{
    public class NormalStrategyTests : GildedRoseTest
    {

        [Fact]
        public void When_SellInGreaterEqualOne_Then_DecreaseQuantityBy1()
        {
            var item = new Item { Name = "AnyName", SellIn = 2, Quality = 1 };
            RunGildedRoseUpdateQuantityForItem(item);
            Assert.Equal(0, item.Quality);
        }

        [Fact]
        public void DontDecreaseZeroQuantitiy()
        {
            var item = new Item { Name = "AnyName", SellIn = 2, Quality = 0 };
            RunGildedRoseUpdateQuantityForItem(item);
            Assert.Equal(0, item.Quality);
        }

        [Fact]
        public void SellInDecreased()
        {
            var item = new Item { Name = "AnyName", SellIn = 2, Quality = 1 };
            RunGildedRoseUpdateQuantityForItem(item);
            Assert.Equal(1, item.SellIn);
        }

        [Fact]
        public void When_SellInLessThanOne_Then_DecreaseQuantityBy2()
        {
            var item = new Item { Name = "AnyName", SellIn = 0, Quality = 3 };
            RunGildedRoseUpdateQuantityForItem(item);
            Assert.Equal(1, item.Quality);
        }
    }
}
