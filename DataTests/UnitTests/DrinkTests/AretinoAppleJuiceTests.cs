/*
 * Author: Bhargav Marada
 * Class: AretinoAppleJuiceTests.cs
 * Purpose: Test the AretinoAppleJuice.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Drinks;
//using Bleakwindbuffet.Data.Drinks;

namespace BleakwindBuffet.DataTests.UnitTests.DrinkTests
{
    public class AretinoAppleJuiceTests
    {
        /// <summary>
        /// no ice
        /// </summary>
        [Fact]
        public void ShouldNotIncludeIceByDefault()
        {
            AretinoAppleJuice aj = new AretinoAppleJuice();
            Assert.False(aj.Ice);
        }

        /// <summary>
        /// size is small
        /// </summary>
        [Fact]
        public void ShouldBeSmallByDefault()
        {
            AretinoAppleJuice aj = new AretinoAppleJuice();
            Assert.Equal(Size.Small, aj.Size);
        }

        /// <summary>
        /// add ice
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetIce()
        {
            AretinoAppleJuice aj = new AretinoAppleJuice();
            aj.Ice = true;
            Assert.True(aj.Ice);
            aj.Ice = false;
            Assert.False(aj.Ice);
        }

        /// <summary>
        /// change drink size
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            AretinoAppleJuice aj = new AretinoAppleJuice();
            aj.Size = Size.Large;
            Assert.Equal(Size.Large, aj.Size);
            aj.Size = Size.Medium;
            Assert.Equal(Size.Medium, aj.Size);
            aj.Size = Size.Small;
            Assert.Equal(Size.Small, aj.Size);
        }

        /// <summary>
        /// correct prices
        /// </summary>
        /// <param name="size">size of drink</param>
        /// <param name="price">price of drink</param>
        [Theory]
        [InlineData(Size.Small, 0.62)]
        [InlineData(Size.Medium, 0.87)]
        [InlineData(Size.Large, 1.01)]
        public void ShouldHaveCorrectPriceForSize(Size size, double price)
        {
            AretinoAppleJuice aj = new AretinoAppleJuice();
            aj.Size = size;
            Assert.Equal(price, aj.Price);
            
        }

        /// <summary>
        /// calories in drink
        /// </summary>
        /// <param name="size">size of drink</param>
        /// <param name="cal">calories in drink</param>
        [Theory]
        [InlineData(Size.Small, 44)]
        [InlineData(Size.Medium, 88)]
        [InlineData(Size.Large, 132)]
        public void ShouldHaveCorrectCaloriesForSize(Size size, uint cal)
        {
            AretinoAppleJuice aj = new AretinoAppleJuice();
            aj.Size = size;
            Assert.Equal(cal, aj.Calories);
        }

        /// <summary>
        /// special instructions
        /// </summary>
        /// <param name="includeIce">ice or no ice</param>
        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void ShouldHaveCorrectSpecialInstructions(bool includeIce)
        {
            AretinoAppleJuice aj = new AretinoAppleJuice();
            aj.Ice = includeIce;
            if (includeIce) Assert.Contains("Add Ice", aj.SpecialInstructions);
            else Assert.Empty(aj.SpecialInstructions);
        }

        /// <summary>
        /// to string
        /// </summary>
        /// <param name="size">size of drink</param>
        /// <param name="name">name of drink</param>
        [Theory]
        [InlineData(Size.Small, "Small Aretino Apple Juice")]
        [InlineData(Size.Medium, "Medium Aretino Apple Juice")]
        [InlineData(Size.Large, "Large Aretino Apple Juice")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            AretinoAppleJuice aj = new AretinoAppleJuice();
            aj.Size = size;
            Assert.Equal(name, aj.ToString());
        }

        /// <summary>
        /// Checks if drink class is abstract
        /// </summary>
        [Fact]
        public void ShouldBeAssignableToAbstractDrinkClass()
        {
            var bar = new AretinoAppleJuice();
            Assert.IsAssignableFrom<Drink>(bar);
        }

        /// <summary>
        /// checks if all items can be cast to their base class
        /// </summary>
        [Fact]
        public void ShouldBeAssignableToIOrderItem()
        {
            var bar = new AretinoAppleJuice();
            Assert.IsAssignableFrom<IOrderItem>(bar);
        }

        /// <summary>
        /// Checks if ice property is notified
        /// </summary>
        [Fact]
        public void ChangingIceNotifiesIceProperty()
        {
            var aj = new AretinoAppleJuice();

            Assert.PropertyChanged(aj, "Ice", () =>
            {
                aj.Ice = true;
            });

            Assert.PropertyChanged(aj, "Ice", () =>
            {
                aj.Ice = false;
            });
        }

        /// <summary>
        /// Changes the size property
        /// </summary>
        /// <param name="size"></param>
        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void ChangingSizeNotifiesSizeProperty(Size size)
        {
            AretinoAppleJuice aj = new AretinoAppleJuice();
            Assert.PropertyChanged(aj, "Size", () => aj.Size = size);
        }

        /// <summary>
        /// Changes the Calories property
        /// </summary>
        /// <param name="size"></param>
        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void ChangingSizeNotifiesCaloriesProperty(Size size)
        {
            AretinoAppleJuice aj = new AretinoAppleJuice();
            Assert.PropertyChanged(aj, "Calories", () => aj.Size = size);
        }

        /// <summary>
        /// Changes the price properyt
        /// </summary>
        /// <param name="size"></param>
        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void ChangingSizeNotifiesPriceProperty(Size size)
        {
            AretinoAppleJuice aj = new AretinoAppleJuice();
            Assert.PropertyChanged(aj, "Price", () => aj.Size = size);
        }

        /// <summary>
        /// Implements the INotify Property Change
        /// </summary>
        [Fact]
        public void ImplementsINotifyPropertyChange()
        {
            AretinoAppleJuice bb = new AretinoAppleJuice();
            Assert.IsAssignableFrom<System.ComponentModel.INotifyPropertyChanged>(bb);
        }
    }
}