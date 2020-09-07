/*
 * Author: Bhargav Marada
 * Class: CandlehearthCoffeeTests.cs
 * Purpose: Test the CandlehearthCoffee.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Drinks;


namespace BleakwindBuffet.DataTests.UnitTests.DrinkTests
{
    public class CandlehearthCoffeeTests
    {
        /// <summary>
        /// no ice
        /// </summary>
        [Fact]
        public void ShouldNotIncludeIceByDefault()
        {
            CandlehearthCoffe cc = new CandlehearthCoffe();
            Assert.False(cc.Ice);
        }

        /// <summary>
        /// not decaf
        /// </summary>
        [Fact]
        public void ShouldNotBeDecafByDefault()
        {
            CandlehearthCoffe cc = new CandlehearthCoffe();
            Assert.False(cc.Decaf);
        }

        /// <summary>
        /// no cream
        /// </summary>
        [Fact]
        public void ShouldNotHaveRoomForCreamByDefault()
        {
            CandlehearthCoffe cc = new CandlehearthCoffe();
            Assert.False(cc.RoomForCream);
        }

        /// <summary>
        /// size small
        /// </summary>
        [Fact]
        public void ShouldBeSmallByDefault()
        {
            CandlehearthCoffe cc = new CandlehearthCoffe();
            Assert.Equal(Size.Small, cc.Size);
        }

        /// <summary>
        /// add ice
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetIce()
        {
            CandlehearthCoffe cc = new CandlehearthCoffe();
            cc.Ice = true;
            Assert.True(cc.Ice);
            cc.Ice = false;
            Assert.False(cc.Ice);
        }

        /// <summary>
        /// make it decaf
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetDecaf()
        {
            CandlehearthCoffe cc = new CandlehearthCoffe();
            cc.Decaf = true;
            Assert.True(cc.Decaf);
            cc.Decaf = false;
            Assert.False(cc.Decaf);
        }

        /// <summary>
        /// add cream
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetRoomForCream()
        {
            CandlehearthCoffe cc = new CandlehearthCoffe();
            cc.RoomForCream = true;
            Assert.True(cc.RoomForCream);
            cc.RoomForCream = false;
            Assert.False(cc.RoomForCream);
        }

        /// <summary>
        /// change size
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            CandlehearthCoffe cc = new CandlehearthCoffe();
            cc.Size = Size.Large;
            Assert.Equal(Size.Large, cc.Size);
            cc.Size = Size.Medium;
            Assert.Equal(Size.Medium, cc.Size);
            cc.Size = Size.Small;
            Assert.Equal(Size.Small, cc.Size);
        }

        /// <summary>
        /// correct prices
        /// </summary>
        /// <param name="size">size of drink</param>
        /// <param name="price">price of drink</param>
        [Theory]
        [InlineData(Size.Small, 0.75)]
        [InlineData(Size.Medium, 1.25)]
        [InlineData(Size.Large, 1.75)]
        public void ShouldHaveCorrectPriceForSize(Size size, double price)
        {
            CandlehearthCoffe cc = new CandlehearthCoffe();
            cc.Size = size;
            Assert.Equal(price, cc.Price);
        }

        /// <summary>
        /// calories in drink
        /// </summary>
        /// <param name="size">size of drink</param>
        /// <param name="cal">calries in the drink</param>
        [Theory]
        [InlineData(Size.Small, 7)]
        [InlineData(Size.Medium, 10)]
        [InlineData(Size.Large, 20)]
        public void ShouldHaveCorrectCaloriesForSize(Size size, uint cal)
        {
            CandlehearthCoffe cc = new CandlehearthCoffe();
            cc.Size = size;
            Assert.Equal(cal, cc.Calories);
        }

        /// <summary>
        /// correct special instructions
        /// </summary>
        /// <param name="includeIce"> add ice</param>
        /// <param name="includeCream">add cream</param>
        [Theory]
        [InlineData(true, true)]
        [InlineData(true, false)]
        [InlineData(false, true)]
        [InlineData(false, false)]
        public void ShouldHaveCorrectSpecialInstructions(bool includeIce, bool includeCream)
        {
            CandlehearthCoffe cc = new CandlehearthCoffe();
            cc.Ice = includeIce;
            cc.RoomForCream = includeCream;
            if (includeIce && includeCream)
            {
                Assert.Contains("Add ice", cc.SpecialInstructions);
                Assert.Contains("Add cream", cc.SpecialInstructions);
            }
            else if (includeIce && !includeCream) Assert.Contains("Add ice", cc.SpecialInstructions);
            else if (!includeIce && includeCream) Assert.Contains("Add cream", cc.SpecialInstructions);
            else Assert.Empty(cc.SpecialInstructions);
        }

        /// <summary>
        /// to string
        /// </summary>
        /// <param name="decaf">decaf or not decaf</param>
        /// <param name="size">size of drink</param>
        /// <param name="name">name of drink</param>
        [Theory]
        [InlineData(true, Size.Small, "Small Decaf Candlehearth Coffee")]
        [InlineData(true, Size.Medium, "Medium Decaf Candlehearth Coffee")]
        [InlineData(true, Size.Large, "Large Decaf Candlehearth Coffee")]
        [InlineData(false, Size.Small, "Small Candlehearth Coffee")]
        [InlineData(false, Size.Medium, "Medium Candlehearth Coffee")]
        [InlineData(false, Size.Large, "Large Candlehearth Coffee")]
        public void ShouldReturnCorrectToStringBasedOnSize(bool decaf, Size size, string name)
        {
            CandlehearthCoffe cc = new CandlehearthCoffe();
            cc.Size = size;
            cc.Decaf = decaf;
            //if(decaf) Assert.Equal(name, cc.ToString());
            Assert.Equal(name, cc.ToString());
        }
    }
}
