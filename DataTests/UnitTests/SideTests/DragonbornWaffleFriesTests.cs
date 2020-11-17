/*
 * Author: Bhargav Marada
 * Class: DragonbornWaffleFriesTests.cs
 * Purpose: Test the DragonbornWaffleFries.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Sides;

namespace BleakwindBuffet.DataTests.UnitTests.SideTests
{
    public class DragonbornWaffleFriesTests
    {
        /// <summary>
        /// size small
        /// </summary>
        [Fact]
        public void ShouldBeSmallByDefault()
        {
            DragonBornWaffleFries wf = new DragonBornWaffleFries();
            Assert.Equal(Size.Small, wf.Size);
        }

        /// <summary>
        /// change size
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            DragonBornWaffleFries wf = new DragonBornWaffleFries();
            wf.Size = Size.Large;
            Assert.Equal(Size.Large, wf.Size);
            wf.Size = Size.Medium;
            Assert.Equal(Size.Medium, wf.Size);
            wf.Size = Size.Small;
            Assert.Equal(Size.Small, wf.Size);
        }

        /// <summary>
        /// special instructions
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectSpecialInstructions()
        {
            DragonBornWaffleFries wf = new DragonBornWaffleFries();
            Assert.Empty(wf.SpecialInstructions);
        }

        /// <summary>
        /// price
        /// </summary>
        /// <param name="size">size of side</param>
        /// <param name="price">name of side</param>
        [Theory]
        [InlineData(Size.Small, 0.42)]
        [InlineData(Size.Medium, 0.76)]
        [InlineData(Size.Large, 0.96)]
        public void ShouldReturnCorrectPriceBasedOnSize(Size size, double price)
        {
            DragonBornWaffleFries wf = new DragonBornWaffleFries();
            wf.Size = size;
            Assert.Equal(price, wf.Price);
        }

        /// <summary>
        /// calories
        /// </summary>
        /// <param name="size">size of side</param>
        /// <param name="calories">calories in side</param>
        [Theory]
        [InlineData(Size.Small, 77)]
        [InlineData(Size.Medium, 89)]
        [InlineData(Size.Large, 100)]
        public void ShouldReturnCorrectCaloriesBasedOnSize(Size size, uint calories)
        {
            DragonBornWaffleFries wf = new DragonBornWaffleFries();
            wf.Size = size;
            Assert.Equal(calories, wf.Calories);
        }

        /// <summary>
        /// to string
        /// </summary>
        /// <param name="size">size of side</param>
        /// <param name="name">name ofside</param>
        [Theory]
        [InlineData(Size.Small, "Small Dragonborn Waffle Fries")]
        [InlineData(Size.Medium, "Medium Dragonborn Waffle Fries")]
        [InlineData(Size.Large, "Large Dragonborn Waffle Fries")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            DragonBornWaffleFries wf = new DragonBornWaffleFries();
            wf.Size = size;
            Assert.Equal(name, wf.ToString());
        }

        /// <summary>
        /// Checks if Side class is abstract
        /// </summary>
        [Fact]
        public void ShouldBeAssignableToAbstractDrinkClass()
        {
            var bar = new DragonBornWaffleFries();
            Assert.IsAssignableFrom<Side>(bar);
        }

        /// <summary>
        /// checks if all items can be cast to their base class
        /// </summary>
        [Fact]
        public void ShouldBeAssignableToIOrderItem()
        {
            var bar = new DragonBornWaffleFries();
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
            var wf = new DragonBornWaffleFries();
            Assert.PropertyChanged(wf, "Size", () => wf.Size = size);
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
            var wf = new DragonBornWaffleFries();
            Assert.PropertyChanged(wf, "Calories", () => wf.Size = size);
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
            var wf = new DragonBornWaffleFries();
            Assert.PropertyChanged(wf, "Price", () => wf.Size = size);
        }

        /// <summary>
        /// Implements the INotify Property Change
        /// </summary>
        [Fact]
        public void ImplementsINotifyPropertyChange()
        {
            var wf = new DragonBornWaffleFries();
            Assert.IsAssignableFrom<System.ComponentModel.INotifyPropertyChanged>(wf);
        }

        [Fact]
        public void ShouldHaveCorrectDescription()
        {
            var wf = new DragonBornWaffleFries();
            Assert.Equal("Crispy fried potato waffle fries.", wf.Description);
        }
    }
}