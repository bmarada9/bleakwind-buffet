/*
 * Author: Bhargav Marada
 * Class: SailorSodaTests.cs
 * Purpose: Test the SailorSoda.cs class in the Data library
 */
using System;

using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.DataTests.UnitTests.DrinkTests
{
    public class SailorSodaTests
    {
        /// <summary>
        /// ice by default in drink
        /// </summary>
        [Fact]
        public void ShouldIncludeIceByDefault()
        {
            SailorsSoda ss = new SailorsSoda();
            Assert.True(ss.Ice);
        }

        /// <summary>
        /// drink is small by default
        /// </summary>
        [Fact]
        public void ShouldBeSmallByDefault()
        {
            SailorsSoda ss = new SailorsSoda();
            Assert.Equal(Size.Small, ss.Size);
        }

        /// <summary>
        /// default flavor is cherry
        /// </summary>
        [Fact]
        public void FlavorShouldBeCherryByDefault()
        {
            SailorsSoda ss = new SailorsSoda();
            Assert.Equal(SodaFlavor.Cherry, ss.Flavor);
        }

        /// <summary>
        /// choose if you wnt ice
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetIce()
        {
            SailorsSoda ss = new SailorsSoda();
            ss.Ice = true;
            Assert.True(ss.Ice);
            ss.Ice = false;
            Assert.False(ss.Ice);
        }

        /// <summary>
        /// choose the size
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            SailorsSoda ss = new SailorsSoda();
            ss.Size = Size.Large;
            Assert.Equal(Size.Large, ss.Size);
            ss.Size = Size.Medium;
            Assert.Equal(Size.Medium, ss.Size);
            ss.Size = Size.Small;
            Assert.Equal(Size.Small, ss.Size);
        }

        /// <summary>
        /// choose the flavor
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetFlavor()
        {
            SailorsSoda ss = new SailorsSoda();
            ss.Flavor = SodaFlavor.Blackberry;
            Assert.Equal(SodaFlavor.Blackberry, ss.Flavor);
            ss.Flavor = SodaFlavor.Cherry;
            Assert.Equal(SodaFlavor.Cherry, ss.Flavor);
            ss.Flavor = SodaFlavor.Grapefruit;
            Assert.Equal(SodaFlavor.Grapefruit, ss.Flavor);
            ss.Flavor = SodaFlavor.Lemon;
            Assert.Equal(SodaFlavor.Lemon, ss.Flavor);
            ss.Flavor = SodaFlavor.Peach;
            Assert.Equal(SodaFlavor.Peach, ss.Flavor);
            ss.Flavor = SodaFlavor.Watermelon;
            Assert.Equal(SodaFlavor.Watermelon, ss.Flavor);
        }

        /// <summary>
        /// price for size
        /// </summary>
        /// <param name="size">size of drink</param>
        /// <param name="price">price of drink</param>
        [Theory]
        [InlineData(Size.Small, 1.42)]
        [InlineData(Size.Medium, 1.74)]
        [InlineData(Size.Large, 2.07)]
        public void ShouldHaveCorrectPriceForSize(Size size, double price)
        {
            SailorsSoda ss = new SailorsSoda();
            ss.Size = size;
            Assert.Equal(price, ss.Price);
        }

        /// <summary>
        /// right calories per size
        /// </summary>
        /// <param name="size">size of drink</param>
        /// <param name="cal">calories in drink</param>
        [Theory]
        [InlineData(Size.Small, 117)]
        [InlineData(Size.Medium, 153)]
        [InlineData(Size.Large, 205)]
        public void ShouldHaveCorrectCaloriesForSize(Size size, uint cal)
        {
            SailorsSoda ss = new SailorsSoda();
            ss.Size = size;
            Assert.Equal(cal, ss.Calories);
        }

        /// <summary>
        /// correct instructions
        /// </summary>
        /// <param name="includeIce">ice or no ice</param>
        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void ShouldHaveCorrectSpecialInstructions(bool includeIce)
        {
            SailorsSoda ss = new SailorsSoda();
            ss.Ice = includeIce;
            if (!includeIce) Assert.Contains("Hold Ice", ss.SpecialInstructions);
            else Assert.Empty(ss.SpecialInstructions);
        }
        
        /// <summary>
        /// to string
        /// </summary>
        /// <param name="flavor">flavor of drink</param>
        /// <param name="size">size of drink</param>
        /// <param name="name">name of drink</param>
        [Theory]
        [InlineData(SodaFlavor.Cherry, Size.Small, "Small Cherry Sailor Soda")]
        [InlineData(SodaFlavor.Cherry, Size.Medium, "Medium Cherry Sailor Soda")]
        [InlineData(SodaFlavor.Cherry, Size.Large, "Large Cherry Sailor Soda")]

        [InlineData(SodaFlavor.Blackberry, Size.Small, "Small Blackberry Sailor Soda")]
        [InlineData(SodaFlavor.Blackberry, Size.Medium, "Medium Blackberry Sailor Soda")]
        [InlineData(SodaFlavor.Blackberry, Size.Large, "Large Blackberry Sailor Soda")]

        [InlineData(SodaFlavor.Grapefruit, Size.Small, "Small Grapefruit Sailor Soda")]
        [InlineData(SodaFlavor.Grapefruit, Size.Medium, "Medium Grapefruit Sailor Soda")]
        [InlineData(SodaFlavor.Grapefruit, Size.Large, "Large Grapefruit Sailor Soda")]

        [InlineData(SodaFlavor.Lemon, Size.Small, "Small Lemon Sailor Soda")]
        [InlineData(SodaFlavor.Lemon, Size.Medium, "Medium Lemon Sailor Soda")]
        [InlineData(SodaFlavor.Lemon, Size.Large, "Large Lemon Sailor Soda")]

        [InlineData(SodaFlavor.Peach, Size.Small, "Small Peach Sailor Soda")]
        [InlineData(SodaFlavor.Peach, Size.Medium, "Medium Peach Sailor Soda")]
        [InlineData(SodaFlavor.Peach, Size.Large, "Large Peach Sailor Soda")]

        [InlineData(SodaFlavor.Watermelon, Size.Small, "Small Watermelon Sailor Soda")]
        [InlineData(SodaFlavor.Watermelon, Size.Medium, "Medium Watermelon Sailor Soda")]
        [InlineData(SodaFlavor.Watermelon, Size.Large, "Large Watermelon Sailor Soda")]
        public void ShouldHaveCorrectToStringBasedOnSizeAndFlavor(SodaFlavor flavor, Size size, string name)
        {
            SailorsSoda ss = new SailorsSoda();
            ss.Size = size;
            ss.Flavor = flavor;
            Assert.Equal(name, ss.ToString());
        }

        /// <summary>
        /// Checks if the Drink class is abstract
        /// </summary>
        [Fact]
        public void ShouldBeAssignableToAbstractDrinkClass()
        {
            var bar = new SailorsSoda();
            Assert.IsAssignableFrom<Drink>(bar);
        }

        /// <summary>
        /// checks if all items can be cast to their base class
        /// </summary>
        [Fact]
        public void ShouldBeAssignableToIOrderItem()
        {
            var bar = new SailorsSoda();
            Assert.IsAssignableFrom<IOrderItem>(bar);
        }
    }
}
