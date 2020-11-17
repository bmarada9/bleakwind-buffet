/*
 * Author: Bhargav Marada
 * Class: FriedMiraakTests.cs
 * Purpose: Test the FriedMiraak.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Sides;

namespace BleakwindBuffet.DataTests.UnitTests.SideTests
{
    public class FriedMiraakTests
    {
        /// <summary>
        /// size is small
        /// </summary>
        [Fact]
        public void ShouldBeSmallByDefault()
        {
            FriedMiraak fm = new FriedMiraak();
            Assert.Equal(Size.Small, fm.Size);
        }

        /// <summary>
        /// change size
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            FriedMiraak fm = new FriedMiraak();
            fm.Size = Size.Large;
            Assert.Equal(Size.Large, fm.Size);
            fm.Size = Size.Medium;
            Assert.Equal(Size.Medium, fm.Size);
            fm.Size = Size.Small;
            Assert.Equal(Size.Small, fm.Size);
        }

        /// <summary>
        /// special instructions
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectSpecialInstructions()
        {
            FriedMiraak fm = new FriedMiraak();
            Assert.Empty(fm.SpecialInstructions);
        }

        /// <summary>
        /// price of side
        /// </summary>
        /// <param name="size">size of side</param>
        /// <param name="price">price of side</param>
        [Theory]
        [InlineData(Size.Small, 1.78)]
        [InlineData(Size.Medium, 2.01)]
        [InlineData(Size.Large, 2.88)]
        public void ShouldReturnCorrectPriceBasedOnSize(Size size, double price)
        {
            FriedMiraak fm = new FriedMiraak();
            fm.Size = size;
            Assert.Equal(price, fm.Price);
        }

        /// <summary>
        /// calories
        /// </summary>
        /// <param name="size">size of side</param>
        /// <param name="calories">calories in side</param>
        [Theory]
        [InlineData(Size.Small, 151)]
        [InlineData(Size.Medium, 236)]
        [InlineData(Size.Large, 306)]
        public void ShouldReturnCorrectCaloriesBasedOnSize(Size size, uint calories)
        {
            FriedMiraak fm = new FriedMiraak();
            fm.Size = size;
            Assert.Equal(calories, fm.Calories);
        }

        /// <summary>
        /// to string
        /// </summary>
        /// <param name="size">size of side</param>
        /// <param name="name">name of side</param>
        [Theory]
        [InlineData(Size.Small, "Small Fried Miraak")]
        [InlineData(Size.Medium, "Medium Fried Miraak")]
        [InlineData(Size.Large, "Large Fried Miraak")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            FriedMiraak fm = new FriedMiraak();
            fm.Size = size;
            Assert.Equal(name, fm.ToString());
        }

        /// <summary>
        /// Checks if Side class is abstract
        /// </summary>
        [Fact]
        public void ShouldBeAssignableToAbstractDrinkClass()
        {
            var bar = new FriedMiraak();
            Assert.IsAssignableFrom<Side>(bar);
        }

        /// <summary>
        /// checks if all items can be cast to their base class
        /// </summary>
        [Fact]
        public void ShouldBeAssignableToIOrderItem()
        {
            var bar = new FriedMiraak();
            Assert.IsAssignableFrom<IOrderItem>(bar);
        }

        /// <summary>
        /// changes the size property
        /// </summary>
        /// <param name="size"></param>
        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void ChangingSizeNotifiesSizeProperty(Size size)
        {
            var fm = new FriedMiraak();
            Assert.PropertyChanged(fm, "Size", () => fm.Size = size);
        }

        /// <summary>
        /// changes the calories property
        /// </summary>
        /// <param name="size"></param>
        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void ChangingSizeNotifiesCaloriesProperty(Size size)
        {
            var fm = new FriedMiraak();
            Assert.PropertyChanged(fm, "Calories", () => fm.Size = size);
        }

        /// <summary>
        /// changes the price property
        /// </summary>
        /// <param name="size"></param>
        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void ChangingSizeNotifiesPriceProperty(Size size)
        {
            var fm = new FriedMiraak();
            Assert.PropertyChanged(fm, "Price", () => fm.Size = size);
        }

        /// <summary>
        /// Implements the INotify Property Change
        /// </summary>
        [Fact]
        public void ImplementsINotifyPropertyChange()
        {
            var fm = new FriedMiraak();
            Assert.IsAssignableFrom<System.ComponentModel.INotifyPropertyChanged>(fm);
        }

        [Fact]
        public void ShouldHaveCorrectDescription()
        {
            var fm = new FriedMiraak();
            Assert.Equal("Perfectly prepared hash brown pancakes.", fm.Description);
        }
    }
}