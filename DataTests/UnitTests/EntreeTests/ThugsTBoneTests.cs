/*
 * Author: Bhargav Marada
 * Class: ThugsTBoneTests.cs
 * Purpose: Test the ThugsTBone.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class ThugsTBoneTests
    {
        /// <summary>
        /// price
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            ThugsTBone tb = new ThugsTBone();
            Assert.Equal(6.44, tb.Price);
        }

        /// <summary>
        /// calories
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            ThugsTBone tb = new ThugsTBone();
            Assert.Equal(982u, tb.Calories);
        }

        /// <summary>
        /// special instructions
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectSpecialInstructions()
        {
            ThugsTBone tb = new ThugsTBone();
            Assert.Empty(tb.SpecialInstructions);
        }

        /// <summary>
        /// to string
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectToString()
        {
            ThugsTBone tb = new ThugsTBone();
            Assert.NotNull(tb.ToString());
        }

        /// <summary>
        /// Checks if Entree class is abstract
        /// </summary>
        [Fact]
        public void ShouldBeAssignableToAbstractDrinkClass()
        {
            var bar = new ThugsTBone();
            Assert.IsAssignableFrom<Entree>(bar);
        }

        /// <summary>
        /// checks if all items can be cast to their base class
        /// </summary>
        [Fact]
        public void ShouldBeAssignableToIOrderItem()
        {
            var bar = new ThugsTBone();
            Assert.IsAssignableFrom<IOrderItem>(bar);
        }

        /// <summary>
        /// Implements the INotify Property Change
        /// </summary>
        [Fact]
        public void ImplementsINotifyPropertyChange()
        {
            var tb = new ThugsTBone();
            Assert.IsAssignableFrom<System.ComponentModel.INotifyPropertyChanged>(tb);
        }

        [Fact]
        public void ShouldHaveCorrectDescription()
        {
            var tb = new ThugsTBone();
            Assert.Equal("Juicy T-Bone, not much else to say.", tb.Description);
        }
    }
}