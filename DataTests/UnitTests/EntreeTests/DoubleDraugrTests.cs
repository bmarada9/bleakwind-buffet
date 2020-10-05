/*
 * Author: Bhargav Marada
 * Class: DoubleDraugrTests.cs
 * Purpose: Test the DoubleDraugr.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class DoubleDraugrTests
    {   
        /// <summary>
        /// default bun
        /// </summary>
        [Fact]
        public void ShouldIncludeBunByDefault()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.True(dd.Bun);
        }

        /// <summary>
        /// default ketchup
        /// </summary>
        [Fact]
        public void ShouldIncludeKetchupByDefault()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.True(dd.Ketchup);
        }

        /// <summary>
        /// default mustard
        /// </summary>
        [Fact]
        public void ShouldIncludeMustardByDefault()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.True(dd.Mustard);
        }

        /// <summary>
        /// default pickle
        /// </summary>
        [Fact]
        public void ShouldIncludePickleByDefault()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.True(dd.Pickle);
        }

        /// <summary>
        /// default cheese
        /// </summary>
        [Fact]
        public void ShouldIncludeCheeseByDefault()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.True(dd.Cheese);
        }

        /// <summary>
        /// default tomato
        /// </summary>
        [Fact]
        public void ShouldIncludeTomatoByDefault()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.True(dd.Tomato);
        }

        /// <summary>
        /// default lettuce
        /// </summary>
        [Fact]
        public void ShouldIncludeLettuceByDefault()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.True(dd.Lettuce);
        }

        /// <summary>
        /// default mayo
        /// </summary>
        [Fact]
        public void ShouldIncludeMayoByDefault()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.True(dd.Mayo);
        }

        /// <summary>
        /// choose to not have bun
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetBun()
        {
            DoubleDraugr dd = new DoubleDraugr();
            dd.Bun = true;
            Assert.True(dd.Bun);
            dd.Bun = false;
            Assert.False(dd.Bun);
        }
        /// <summary>
        /// choose to not have ketchup
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetKetchup()
        {
            DoubleDraugr dd = new DoubleDraugr();
            dd.Ketchup = true;
            Assert.True(dd.Ketchup);
            dd.Ketchup = false;
            Assert.False(dd.Ketchup);
        }

        /// <summary>
        /// choose to not have mustard
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetMustard()
        {
            DoubleDraugr dd = new DoubleDraugr();
            dd.Mustard = true;
            Assert.True(dd.Mustard);
            dd.Mustard = false;
            Assert.False(dd.Mustard);
        }

        /// <summary>
        /// choose to not have pickles
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetPickle()
        {
            DoubleDraugr dd = new DoubleDraugr();
            dd.Pickle = true;
            Assert.True(dd.Pickle);
            dd.Pickle = false;
            Assert.False(dd.Pickle);
        }

        /// <summary>
        /// choose to not have cheese
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetCheese()
        {
            DoubleDraugr dd = new DoubleDraugr();
            dd.Cheese = true;
            Assert.True(dd.Cheese);
            dd.Cheese = false;
            Assert.False(dd.Cheese);
        }

        /// <summary>
        /// choose to not have tomato
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetTomato()
        {
            DoubleDraugr dd = new DoubleDraugr();
            dd.Tomato = true;
            Assert.True(dd.Tomato);
            dd.Tomato = false;
            Assert.False(dd.Tomato);
        }

        /// <summary>
        /// choose to not have lettuce
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetLettuce()
        {
            DoubleDraugr dd = new DoubleDraugr();
            dd.Lettuce = true;
            Assert.True(dd.Lettuce);
            dd.Lettuce = false;
            Assert.False(dd.Lettuce);
        }

        /// <summary>
        /// choose to not have mayo
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetMayo()
        {
            DoubleDraugr dd = new DoubleDraugr();
            dd.Mayo = true;
            Assert.True(dd.Mayo);
            dd.Mayo = false;
            Assert.False(dd.Mayo);
        }

        /// <summary>
        /// price
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.Equal(7.32, dd.Price);
        }

        /// <summary>
        /// calories
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.Equal(843u, dd.Calories);
        }

        /// <summary>
        /// special instructions
        /// </summary>
        /// <param name="includeBun">hold bun</param>
        /// <param name="includeKetchup">hold ketchup</param>
        /// <param name="includeMustard">hold mustard</param>
        /// <param name="includePickle">hold pickle</param>
        /// <param name="includeCheese">hold cheese</param>
        /// <param name="includeTomato">hold tomato</param>
        /// <param name="includeLettuce">hold lettuce</param>
        /// <param name="includeMayo">hold mayo</param>
        [Theory]
        [InlineData(true, true, true, true, true, true, true, true)]
        [InlineData(false, false, false, false, false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeBun, bool includeKetchup, bool includeMustard,
                                                                    bool includePickle, bool includeCheese, bool includeTomato,
                                                                    bool includeLettuce, bool includeMayo)
        {
            DoubleDraugr dd = new DoubleDraugr() { Bun = includeBun, Ketchup = includeKetchup, Mustard = includeMustard, Pickle = includePickle, Cheese = includeCheese, Tomato = includeTomato, Lettuce = includeLettuce, Mayo = includeMayo };
            if (!includeBun) Assert.Contains("Hold bun", dd.SpecialInstructions);
            if (!includeKetchup) Assert.Contains("Hold ketchup", dd.SpecialInstructions);
            if (!includeMustard) Assert.Contains("Hold mustard", dd.SpecialInstructions);
            if (!includePickle) Assert.Contains("Hold pickle", dd.SpecialInstructions);
            if (!includeCheese) Assert.Contains("Hold cheese", dd.SpecialInstructions);
            if (!includeTomato) Assert.Contains("Hold tomato", dd.SpecialInstructions);
            if (!includeLettuce) Assert.Contains("Hold lettuce", dd.SpecialInstructions);
            if (!includeMayo) Assert.Contains("Hold mayo", dd.SpecialInstructions);
        }

        /// <summary>
        /// to string
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectToString()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.NotNull(dd.ToString());
        }

        /// <summary>
        /// Checks if Entree class is abstract
        /// </summary>
        [Fact]
        public void ShouldBeAssignableToAbstractDrinkClass()
        {
            var bar = new DoubleDraugr();
            Assert.IsAssignableFrom<Entree>(bar);
        }

        /// <summary>
        /// checks if all items can be cast to their base class
        /// </summary>
        [Fact]
        public void ShouldBeAssignableToIOrderItem()
        {
            var bar = new DoubleDraugr();
            Assert.IsAssignableFrom<IOrderItem>(bar);
        }

        /// <summary>
        /// Checks if bun property is notified
        /// </summary>
        [Fact]
        public void ChangingBunNotifiesBunProperty()
        {
            var dd = new DoubleDraugr();
            Assert.PropertyChanged(dd, "Bun", () =>
            {
                dd.Bun1 = true;
            });

            Assert.PropertyChanged(dd, "Bun", () =>
            {
                dd.Bun1 = false;
            });
        }

        /// <summary>
        /// Checks if ketchup property is notified
        /// </summary>
        [Fact]
        public void ChangingKetchupNotifiesKetchupProperty()
        {
            var dd = new DoubleDraugr();
            Assert.PropertyChanged(dd, "Ketchup", () =>
            {
                dd.Ketchup1 = true;
            });

            Assert.PropertyChanged(dd, "Ketchup", () =>
            {
                dd.Ketchup1 = false;
            });
        }

        /// <summary>
        /// Checks if Mustard property is notified
        /// </summary>
        [Fact]
        public void ChangingMustardNotifiesMustardProperty()
        {
            var dd = new DoubleDraugr();
            Assert.PropertyChanged(dd, "Mustard", () =>
            {
                dd.Mustard1 = true;
            });

            Assert.PropertyChanged(dd, "Mustard", () =>
            {
                dd.Mustard1 = false;
            });
        }

        /// <summary>
        /// Checks if Pickles property is notified
        /// </summary>
        [Fact]
        public void ChangingPicklesNotifiesPicklesProperty()
        {
            var dd = new DoubleDraugr();
            Assert.PropertyChanged(dd, "Pickle", () =>
            {
                dd.Pickle1 = true;
            });

            Assert.PropertyChanged(dd, "Pickle", () =>
            {
                dd.Pickle1 = false;
            });
        }

        /// <summary>
        /// Checks if cheese property is notified
        /// </summary>
        [Fact]
        public void ChangingCheeseNotifiesCheeseProperty()
        {
            var dd = new DoubleDraugr();
            Assert.PropertyChanged(dd, "Cheese", () =>
            {
                dd.Cheese1 = true;
            });

            Assert.PropertyChanged(dd, "Cheese", () =>
            {
                dd.Cheese1 = false;
            });
        }

        /// <summary>
        /// Checks if tomato property is notified
        /// </summary>
        [Fact]
        public void ChangingTomatoNotifiesTomatoProperty()
        {
            var dd = new DoubleDraugr();
            Assert.PropertyChanged(dd, "Tomato", () =>
            {
                dd.Tomato1 = true;
            });

            Assert.PropertyChanged(dd, "Tomato", () =>
            {
                dd.Tomato1 = false;
            });
        }

        /// <summary>
        /// Checks if lettuce property is notified
        /// </summary>
        [Fact]
        public void ChangingLettuceNotifiesLettuceProperty()
        {
            var dd = new DoubleDraugr();
            Assert.PropertyChanged(dd, "Lettuce", () =>
            {
                dd.Lettuce1 = true;
            });

            Assert.PropertyChanged(dd, "Lettuce", () =>
            {
                dd.Lettuce1 = false;
            });
        }

        /// <summary>
        /// Checks if mayo property is notified
        /// </summary>
        [Fact]
        public void ChangingMayoNotifiesMayoProperty()
        {
            var dd = new DoubleDraugr();
            Assert.PropertyChanged(dd, "Mayo", () =>
            {
                dd.Mayo1 = true;
            });

            Assert.PropertyChanged(dd, "Mayo", () =>
            {
                dd.Mayo1 = false;
            });
        }

        /// <summary>
        /// Implements the INotify Property Change
        /// </summary>
        [Fact]
        public void ImplementsINotifyPropertyChange()
        {
            var dd = new DoubleDraugr();
            Assert.IsAssignableFrom<System.ComponentModel.INotifyPropertyChanged>(dd);
        }
    }
}