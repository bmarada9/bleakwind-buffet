/*
 * Author: Bhargav Marada
 * Class: SailorSodaTests.cs
 * Purpose: Test the SailorSoda.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Drinks;
//using Bleakwindbuffet.Data.Drinks;

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

        /// <summary>
        /// Checks if the Drink class is abstract
        /// </summary>
        [Fact]
        public void ShouldBeAssignableToAbstractDrinkClass()
        {
            var ww = new WarriorWater();
            Assert.IsAssignableFrom<Drink>(ww);
        }

        /// <summary>
        /// checks if all items can be cast to their base class
        /// </summary>
        [Fact]
        public void ShouldBeAssignableToIOrderItem()
        {
            var ww = new WarriorWater();
            Assert.IsAssignableFrom<IOrderItem>(ww);
        }

        /// <summary>
        /// Checks if ice property is notified
        /// </summary>
        [Fact]
        public void ChangingIceNotifiesIceProperty()
        {
            var ww = new WarriorWater();

            Assert.PropertyChanged(ww, "Ice", () =>
            {
                ww.ice = true;
            });

            Assert.PropertyChanged(ww, "Ice", () =>
            {
                ww.ice = false;
            });
        }

        /// <summary>
        /// Checks if lemon property is notified
        /// </summary>
        [Fact]
        public void ChangingLemonNotifiesLemonProperty()
        {
            var ww = new WarriorWater();

            Assert.PropertyChanged(ww, "Lemon", () =>
            {
                ww.lemon = true;
            });

            Assert.PropertyChanged(ww, "Lemon", () =>
            {
                ww.lemon = false;
            });
        }

        /// <summary>
        /// Checks if size property is notified
        /// </summary>
        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void ChangingSizeNotifiesSizeProperty(Size size)
        {
            var ww = new WarriorWater();
            Assert.PropertyChanged(ww, "Size", () => ww.Size = size);
        }

        /// <summary>
        /// Checks if calories property is notified
        /// </summary>
        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void ChangingSizeNotifiesCaloriesProperty(Size size)
        {
            var ww = new WarriorWater();
            Assert.PropertyChanged(ww, "Calories", () => ww.Size = size);
        }

        /// <summary>
        /// Checks if price property is notified
        /// </summary>
        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void ChangingSizeNotifiesPriceProperty(Size size)
        {
            var ww = new WarriorWater();
            Assert.PropertyChanged(ww, "Price", () => ww.Size = size);
        }

        /// <summary>
        /// Implements the INotify Property Change
        /// </summary>
        [Fact]
        public void ImplementsINotifyPropertyChange()
        {
            var ww = new WarriorWater();
            Assert.IsAssignableFrom<System.ComponentModel.INotifyPropertyChanged>(ww);
        }

        [Fact]
        public void ShouldHaveCorrectDescription()
        {
            var ww = new WarriorWater();
            Assert.Equal("It’s water. Just water.", ww.Description);
        }

    }
}

