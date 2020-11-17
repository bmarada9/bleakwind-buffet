/*
 * Author: Bhargav Marada
 * Class: MarkarthMilkTests.cs
 * Purpose: Test the MarkarthMilk.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Drinks;

namespace BleakwindBuffet.DataTests.UnitTests.DrinkTests
{
    public class MarkarthMilkTests
    {
        /// <summary>
        /// not ice by defualt
        /// </summary>
        [Fact]
        public void ShouldNotIncludeIceByDefault()
        {
            MarkarthMilk mm = new MarkarthMilk();
            Assert.False(mm.Ice);
        }

        /// <summary>
        /// size small 
        /// </summary>
        [Fact]
        public void ShouldBySmallByDefault()
        {
            MarkarthMilk mm = new MarkarthMilk();
            Assert.Equal(Size.Small, mm.Size);
        }

        /// <summary>
        /// add ice
        /// </summary>
        [Fact]
        public void ShouldByAbleToSetIce()
        {
            MarkarthMilk mm = new MarkarthMilk();
            mm.Ice = true;
            Assert.True(mm.Ice);
            mm.Ice = false;
            Assert.False(mm.Ice);
        }

        /// <summary>
        /// choose size
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            MarkarthMilk mm = new MarkarthMilk();
            mm.Size = Size.Large;
            Assert.Equal(Size.Large, mm.Size);
            mm.Size = Size.Medium;
            Assert.Equal(Size.Medium, mm.Size);
            mm.Size = Size.Small;
            Assert.Equal(Size.Small, mm.Size);
        }

        /// <summary>
        /// price of drink
        /// </summary>
        /// <param name="size"></param>
        /// <param name="price"></param>
        [Theory]
        [InlineData(Size.Small, 1.05)]
        [InlineData(Size.Medium, 1.11)]
        [InlineData(Size.Large, 1.22)]
        public void ShouldHaveCorrectPriceForSize(Size size, double price)
        {
            MarkarthMilk mm = new MarkarthMilk();
            mm.Size = size;
            Assert.Equal(price, mm.Price);
        }

        /// <summary>
        /// calories in drink
        /// </summary>
        /// <param name="size"></param>
        /// <param name="cal"></param>
        [Theory]
        [InlineData(Size.Small, 56)]
        [InlineData(Size.Medium, 72)]
        [InlineData(Size.Large, 93)]
        public void ShouldHaveCorrectCaloriesForSize(Size size, uint cal)
        {
            MarkarthMilk mm = new MarkarthMilk();
            mm.Size = size;
            Assert.Equal(cal, mm.Calories);
        }

        /// <summary>
        /// special instructions
        /// </summary>
        /// <param name="includeIce">add ice ordont add ice</param>
        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void ShouldHaveCorrectSpecialInstructions(bool includeIce)
        {
            MarkarthMilk mm = new MarkarthMilk();
            mm.Ice = includeIce;
            if (includeIce) Assert.Contains("Add Ice", mm.SpecialInstructions);
            else Assert.Empty(mm.SpecialInstructions);
        }

        /// <summary>
        /// to string
        /// </summary>
        /// <param name="size">size of drink</param>
        /// <param name="name">name of drink</param>
        [Theory]
        [InlineData(Size.Small, "Small Markarth Milk")]
        [InlineData(Size.Medium, "Medium Markarth Milk")]
        [InlineData(Size.Large, "Large Markarth Milk")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            MarkarthMilk mm = new MarkarthMilk();
            mm.Size = size;
            Assert.Equal(name, mm.ToString());
        }

        /// <summary>
        /// Checks if the Drink class is abstract
        /// </summary>
        [Fact]
        public void ShouldBeAssignableToAbstractDrinkClass()
        {
            MarkarthMilk mm = new MarkarthMilk();
            Assert.IsAssignableFrom<Drink>(mm);
        }

        /// <summary>
        /// checks if all items can be cast to their base class
        /// </summary>
        [Fact]
        public void ShouldBeAssignableToIOrderItem()
        {
            MarkarthMilk mm = new MarkarthMilk();
            Assert.IsAssignableFrom<IOrderItem>(mm);
        }

        /// <summary>
        /// Checks if ice property is notified
        /// </summary>
        [Fact]
        public void ChangingIceNotifiesIceProperty()
        {
            MarkarthMilk mm = new MarkarthMilk();

            Assert.PropertyChanged(mm, "Ice", () =>
            {
                mm.ice = true;
            });

            Assert.PropertyChanged(mm, "Ice", () =>
            {
                mm.ice = false;
            });
        }

        /// <summary>
        /// Checks if lesizemon property is notified
        /// </summary>
        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void ChangingSizeNotifiesSizeProperty(Size size)
        {
            MarkarthMilk mm = new MarkarthMilk();
            Assert.PropertyChanged(mm, "Size", () => mm.Size = size);
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
            MarkarthMilk mm = new MarkarthMilk();
            Assert.PropertyChanged(mm, "Calories", () => mm.Size = size);
        }

        /// <summary>
        /// Checks if prcie property is notified
        /// </summary>
        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void ChangingSizeNotifiesPriceProperty(Size size)
        {
            MarkarthMilk mm = new MarkarthMilk();
            Assert.PropertyChanged(mm, "Price", () => mm.Size = size);
        }

        /// <summary>
        /// Implements the INotify Property Change
        /// </summary>
        [Fact]
        public void ImplementsINotifyPropertyChange()
        {
            MarkarthMilk mm = new MarkarthMilk();
            Assert.IsAssignableFrom<System.ComponentModel.INotifyPropertyChanged>(mm);
        }

        [Fact]
        public void ShouldHaveCorrectDescription()
        {
            var mm = new MarkarthMilk();
            Assert.Equal("Hormone-free organic 2% milk.", mm.Description);
        }
    }
}