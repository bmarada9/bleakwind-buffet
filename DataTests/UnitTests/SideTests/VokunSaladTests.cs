/*
 * Author: Bhargav Marada
 * Class: VokunSaladTests.cs
 * Purpose: Test the VokunSalad.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Sides;

namespace BleakwindBuffet.DataTests.UnitTests.SideTests
{
    public class VokunSaladTests
    {
        /// <summary>
        /// size is small
        /// </summary>
        [Fact]
        public void ShouldBeSmallByDefault()
        {
            VokunSalad vs = new VokunSalad();
            Assert.Equal(Size.Small, vs.Size);
        }
        /// <summary>
        /// change size
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            VokunSalad vs = new VokunSalad();
            vs.Size = Size.Large;
            Assert.Equal(Size.Large, vs.Size);
            vs.Size = Size.Medium;
            Assert.Equal(Size.Medium, vs.Size);
            vs.Size = Size.Small;
            Assert.Equal(Size.Small, vs.Size);
        }
        /// <summary>
        /// special instructions
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectSpecialInstructions()
        {
            VokunSalad vs = new VokunSalad();
            Assert.Empty(vs.SpecialInstructions);
        }
        /// <summary>
        /// price
        /// </summary>
        /// <param name="size">size of side</param>
        /// <param name="price">price of side</param>
        [Theory]
        [InlineData(Size.Small, 0.93)]
        [InlineData(Size.Medium, 1.28)]
        [InlineData(Size.Large, 1.82)]
        public void ShouldReturnCorrectPriceBasedOnSize(Size size, double price)
        {
            VokunSalad vs = new VokunSalad();
            vs.Size = size;
            Assert.Equal(price, vs.Price);
        }
        /// <summary>
        /// calories in side
        /// </summary>
        /// <param name="size">size of side</param>
        /// <param name="calories">calories in side</param>
        [Theory]
        [InlineData(Size.Small, 41)]
        [InlineData(Size.Medium, 52)]
        [InlineData(Size.Large, 73)]
        public void ShouldReturnCorrectCaloriesBasedOnSize(Size size, uint calories)
        {
            VokunSalad vs = new VokunSalad();
            vs.Size = size;
            Assert.Equal(calories, vs.Calories);
        }
        /// <summary>
        /// to string
        /// </summary>
        /// <param name="size">size of side</param>
        /// <param name="name">name of side</param>
        [Theory]
        [InlineData(Size.Small, "Small Vokun Salad")]
        [InlineData(Size.Medium, "Medium Vokun Salad")]
        [InlineData(Size.Large, "Large Vokun Salad")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            VokunSalad vs = new VokunSalad();
            vs.Size = size;
            Assert.Equal(name, vs.ToString());
        }

        /// <summary>
        /// Checks if Side class is abstract
        /// </summary>
        [Fact]
        public void ShouldBeAssignableToAbstractDrinkClass()
        {
            var bar = new VokunSalad();
            Assert.IsAssignableFrom<Side>(bar);
        }

        /// <summary>
        /// checks if all items can be cast to their base class
        /// </summary>
        [Fact]
        public void ShouldBeAssignableToIOrderItem()
        {
            var bar = new VokunSalad();
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
            var vs = new MadOtarGrits();
            Assert.PropertyChanged(vs, "Size", () => vs.Size = size);
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
            var vs = new MadOtarGrits();
            Assert.PropertyChanged(vs, "Calories", () => vs.Size = size);
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
            var vs = new MadOtarGrits();
            Assert.PropertyChanged(vs, "Price", () => vs.Size = size);
        }

        /// <summary>
        /// Implements the INotify Property Change
        /// </summary>
        [Fact]
        public void ImplementsINotifyPropertyChange()
        {
            var vs = new MadOtarGrits();
            Assert.IsAssignableFrom<System.ComponentModel.INotifyPropertyChanged>(vs);
        }

        [Fact]
        public void ShouldHaveCorrectDescription()
        {
            var vs = new VokunSalad();
            Assert.Equal("A seasonal fruit salad of mellons, berries, mango, grape, apple, and oranges.", vs.Description);
        }
    }
}