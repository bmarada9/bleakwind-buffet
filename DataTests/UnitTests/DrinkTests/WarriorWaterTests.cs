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
    public class WarriorWaterTests
    {
        /// <summary>
        /// ice by default in drink
        /// </summary>
        [Fact]
        public void ShouldIncludeIceByDefault()
        {
            WarriorWater ww = new WarriorWater();
            Assert.True(ww.Ice);
        }

        /// <summary>
        /// drink is small by default
        /// </summary>
        [Fact]
        public void ShouldBySmallByDefault()
        {
            WarriorWater ww = new WarriorWater();
            Assert.Equal(Size.Small, ww.Size);
        }

        /// <summary>
        /// user can choose to have ice or no ice
        /// </summary>
        [Fact]
        public void ShouldByAbleToSetIce()
        {
            WarriorWater ww = new WarriorWater();
            ww.Ice = true;
            Assert.True(ww.Ice);
            ww.Ice = false;
            Assert.False(ww.Ice);
        }
        
        /// <summary>
        /// user can choose size of drink
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            WarriorWater ww = new WarriorWater();
            ww.Size = Size.Large;
            Assert.Equal(Size.Large, ww.Size);
            ww.Size = Size.Medium;
            Assert.Equal(Size.Medium, ww.Size);
            ww.Size = Size.Small;
            Assert.Equal(Size.Small, ww.Size);
        }

        /// <summary>
        /// the price of drink
        /// </summary>
        /// <param name="size">the size of the drink</param>
        /// <param name="price">the price of the drink</param>
        [Theory]
        [InlineData(Size.Small, 0.00)]
        [InlineData(Size.Medium, 0.00)]
        [InlineData(Size.Large, 0.00)]
        public void ShouldHaveCorrectPriceForSize(Size size, double price)
        {
            WarriorWater ww = new WarriorWater();
            ww.Size = size;
            Assert.Equal(price, ww.Price);
        }

        /// <summary>
        /// correct calories
        /// </summary>
        /// <param name="size">size of drink</param>
        /// <param name="cal">calories in drink</param>
        [Theory]
        [InlineData(Size.Small, 0)]
        [InlineData(Size.Medium, 0)]
        [InlineData(Size.Large, 0)]
        public void ShouldHaveCorrectCaloriesForSize(Size size, uint cal)
        {
            WarriorWater ww = new WarriorWater();
            ww.Size = size;
            Assert.Equal(cal, ww.Calories);
        }

        /// <summary>
        /// correct special instructions
        /// </summary>
        /// <param name="includeIce">if the user wants ice or not</param>
        /// <param name="includeLemon">if the user wants lemon or not</param>
        [Theory]
        [InlineData(true, true)]
        [InlineData(true, false)]
        [InlineData(false, true)]
        [InlineData(false, false)]
        public void ShouldHaveCorrectSpecialInstructions(bool includeIce, bool includeLemon)
        {
            WarriorWater ww = new WarriorWater();
            ww.Ice = includeIce;
            ww.Lemon = includeLemon;
            if (includeIce && includeLemon)
            {
                Assert.Contains("Hold Ice", ww.SpecialInstructions);
                Assert.Contains("Add Lemon", ww.SpecialInstructions);
            }
            else if (includeIce && !includeLemon) Assert.Contains("Hold Ice", ww.SpecialInstructions);
            else if (!includeIce && includeLemon) Assert.Contains("Add Lemon", ww.SpecialInstructions);
            else Assert.Empty(ww.SpecialInstructions);
        }

        /// <summary>
        /// correct to string
        /// </summary>
        /// <param name="lemon">lemon or no lemon</param>
        /// <param name="size">size of drink</param>
        /// <param name="name">name of drink</param>
        [Theory]
        [InlineData(true, Size.Small, "Small Warrior Water")]
        [InlineData(true, Size.Medium, "Medium Warrior Water")]
        [InlineData(true, Size.Large, "Large Warrior Water")]
        [InlineData(false, Size.Small, "Small Warrior Water")]
        [InlineData(false, Size.Medium, "Medium Warrior Water")]
        [InlineData(false, Size.Large, "Large Warrior Water")]
        public void ShouldReturnCorrectToStringBasedOnSize(bool lemon, Size size, string name)
        {
            WarriorWater ww = new WarriorWater();
            ww.Size = size;
            ww.Lemon = lemon;
            
            Assert.Equal(name, ww.ToString());
        }
    }
}
