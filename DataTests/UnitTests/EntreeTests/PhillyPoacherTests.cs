/*
 * Author: Bhargav Marada
 * Class: PhillyPoacherTests.cs
 * Purpose: Test the PhillyPoacher.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class PhillyPoacherTests
    {
        /// <summary>
        /// default sirloing
        /// </summary>
        [Fact]
        public void ShouldInlcudeSirloinByDefault()
        {
            PhillyPoacher pp = new PhillyPoacher();
            Assert.True(pp.Sirloin);
        }

        /// <summary>
        /// default onion
        /// </summary>
        [Fact]
        public void ShouldInlcudeOnionByDefault()
        {
            PhillyPoacher pp = new PhillyPoacher();
            Assert.True(pp.Onion);
        }

        /// <summary>
        /// default roll
        /// </summary>
        [Fact]
        public void ShouldInlcudeRollByDefault()
        {
            PhillyPoacher pp = new PhillyPoacher();
            Assert.True(pp.Roll);
        }

        /// <summary>
        /// choose not to have sirloin
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetSirloin()
        {
            PhillyPoacher pp = new PhillyPoacher();
            pp.Sirloin = true;
            Assert.True(pp.Sirloin);
            pp.Sirloin = false;
            Assert.False(pp.Sirloin);
        }

        /// <summary>
        /// choose not to have onions
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetOnions()
        {
            PhillyPoacher pp = new PhillyPoacher();
            pp.Onion = true;
            Assert.True(pp.Onion);
            pp.Onion = false;
            Assert.False(pp.Onion);
        }

        /// <summary>
        /// choose not to have rolls
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetRoll()
        {
            PhillyPoacher pp = new PhillyPoacher();
            pp.Roll = true;
            Assert.True(pp.Roll);
            pp.Roll = false;
            Assert.False(pp.Roll);
        }

        /// <summary>
        /// price
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            PhillyPoacher pp = new PhillyPoacher();
            Assert.Equal(7.23, pp.Price);
        }

        /// <summary>
        /// calories
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            PhillyPoacher pp = new PhillyPoacher();
            Assert.Equal(784u, pp.Calories);
        }

        /// <summary>
        /// special instrictions
        /// </summary>
        /// <param name="includeSirloin">hold sirloin</param>
        /// <param name="includeOnion">hold onion</param>
        /// <param name="includeRoll">hold roll</param>
        [Theory]
        [InlineData(true, true, true)]
        [InlineData(false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeSirloin, bool includeOnion,
                                                            bool includeRoll)
        {
            PhillyPoacher pp = new PhillyPoacher() { Sirloin = includeSirloin, Onion = includeOnion, Roll = includeRoll};
            if (!includeSirloin) Assert.Contains("Hold sirloin", pp.SpecialInstructions);
            if (!includeOnion) Assert.Contains("Hold onion", pp.SpecialInstructions);
            if (!includeRoll) Assert.Contains("Hold roll", pp.SpecialInstructions);
        }

        /// <summary>
        /// to string
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectToString()
        {
            PhillyPoacher pp = new PhillyPoacher();
            Assert.NotNull(pp.ToString());
        }

        /// <summary>
        /// Checks if Entree class is abstract
        /// </summary>
        [Fact]
        public void ShouldBeAssignableToAbstractDrinkClass()
        {
            var bar = new PhillyPoacher();
            Assert.IsAssignableFrom<Entree>(bar);
        }

        /// <summary>
        /// checks if all items can be cast to their base class
        /// </summary>
        [Fact]
        public void ShouldBeAssignableToIOrderItem()
        {
            var bar = new PhillyPoacher();
            Assert.IsAssignableFrom<IOrderItem>(bar);
        }

        /// <summary>
        /// Checks if sirloin property is notified
        /// </summary>
        [Fact]
        public void ChangingSirloinNotifiesSirloinProperty()
        {
            var pp = new PhillyPoacher();
            Assert.PropertyChanged(pp, "Sirloin", () =>
            {
                pp.Sirloin1 = true;
            });

            Assert.PropertyChanged(pp, "Sirloin", () =>
            {
                pp.Sirloin1 = false;
            });
        }

        /// <summary>
        /// Checks if onion property is notified
        /// </summary>
        [Fact]
        public void ChangingOnionNotifiesOnionProperty()
        {
            var pp = new PhillyPoacher();
            Assert.PropertyChanged(pp, "Onion", () =>
            {
                pp.Onion1 = true;
            });

            Assert.PropertyChanged(pp, "Onion", () =>
            {
                pp.Onion1 = false;
            });
        }

        /// <summary>
        /// Checks if roll property is notified
        /// </summary>
        [Fact]
        public void ChangingRollNotifiesRollProperty()
        {
            var pp = new PhillyPoacher();
            Assert.PropertyChanged(pp, "Roll", () =>
            {
                pp.Roll1 = true;
            });

            Assert.PropertyChanged(pp, "Roll", () =>
            {
                pp.Roll1 = false;
            });
        }

        /// <summary>
        /// Implements the INotify Property Change
        /// </summary>
        [Fact]
        public void ImplementsINotifyPropertyChange()
        {
            var pp = new PhillyPoacher();
            Assert.IsAssignableFrom<System.ComponentModel.INotifyPropertyChanged>(pp);
        }
    }
}