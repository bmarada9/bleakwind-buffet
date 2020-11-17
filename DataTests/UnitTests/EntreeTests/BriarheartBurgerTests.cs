/*
 * Author: Bhargav Marada
 * Class: BriarheartBurgerTests.cs
 * Purpose: Test the BriarheartBurger.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class BriarheartBurgerTests
    {
        /// <summary>
        /// include bun
        /// </summary>
        [Fact]
        public void ShouldIncludeBunByDefault()
        {
            BriarheartBurger bb = new BriarheartBurger();
            Assert.True(bb.Bun);
        }

        /// <summary>
        /// include ketchup
        /// </summary>
        [Fact]
        public void ShouldIncludeKetchupByDefault()
        {
            BriarheartBurger bb = new BriarheartBurger();
            Assert.True(bb.Ketchup);
        }

        /// <summary>
        /// include mustard
        /// </summary>
        [Fact]
        public void ShouldIncludeMustardByDefault()
        {
            BriarheartBurger bb = new BriarheartBurger();
            Assert.True(bb.Mustard);
        }

        /// <summary>
        /// include pickle
        /// </summary>
        [Fact]
        public void ShouldIncludePickleByDefault()
        {
            BriarheartBurger bb = new BriarheartBurger();
            Assert.True(bb.Pickle);
        }

        /// <summary>
        /// include cheese
        /// </summary>
        [Fact]
        public void ShouldIncludeCheeseByDefault()
        {
            BriarheartBurger bb = new BriarheartBurger();
            Assert.True(bb.Cheese);
        }

        /// <summary>
        /// choose if you want a bun
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetBun()
        {
            BriarheartBurger bb = new BriarheartBurger();
            bb.Bun = true;
            Assert.True(bb.Bun);
            bb.Bun = false;
            Assert.False(bb.Bun);
        }

        /// <summary>
        /// choose if you want ketchup
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetKetchup()
        {
            BriarheartBurger bb = new BriarheartBurger();
            bb.Ketchup = true;
            Assert.True(bb.Ketchup);
            bb.Ketchup = false;
            Assert.False(bb.Ketchup);
        }

        /// <summary>
        /// choose if you want mustard
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetMustard()
        {
            BriarheartBurger bb = new BriarheartBurger();
            bb.Mustard = true;
            Assert.True(bb.Mustard);
            bb.Mustard = false;
            Assert.False(bb.Mustard);
        }

        /// <summary>
        /// choose if you want pickles
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetPickle()
        {
            BriarheartBurger bb = new BriarheartBurger();
            bb.Pickle = true;
            Assert.True(bb.Pickle);
            bb.Pickle = false;
            Assert.False(bb.Pickle);
        }

        /// <summary>
        /// choose if you want cheese
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetCheese()
        {
            BriarheartBurger bb = new BriarheartBurger();
            bb.Cheese = true;
            Assert.True(bb.Cheese);
            bb.Cheese = false;
            Assert.False(bb.Cheese);
        }

        /// <summary>
        /// price
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            BriarheartBurger bb = new BriarheartBurger();
            Assert.Equal(6.32, bb.Price);
        }

        /// <summary>
        /// calories
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            BriarheartBurger bb = new BriarheartBurger();
            Assert.Equal(743u, bb.Calories);
        }

        /// <summary>
        /// special instructions
        /// </summary>
        /// <param name="includeBun">include buns</param>
        /// <param name="includeKetchup">include ketchup</param>
        /// <param name="includeMustard">include mustard</param>
        /// <param name="includePickle">include pickles</param>
        /// <param name="includeCheese">include cheese</param>
        [Theory]
        [InlineData(true, true, true, true, true)]
        [InlineData(false, false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeBun, bool includeKetchup, bool includeMustard,
                                                                    bool includePickle, bool includeCheese)
        {
            BriarheartBurger bb = new BriarheartBurger();
            //int instructionCount = 0;
            if (!includeBun) 
            {
                Assert.Contains("Hold bun", bb.SpecialInstructions);
                //instructionCount++;
            }
            if (!includeKetchup)
            {
                Assert.Contains("Hold ketchup", bb.SpecialInstructions);
                //instructionCount++;
            }
            if (!includeMustard)
            {
                Assert.Contains("Hold mustard", bb.SpecialInstructions);
                //instructionCount++;
            }
            if (!includePickle)
            {
                Assert.Contains("Hold pickle", bb.SpecialInstructions);
                //instructionCount++;
            }
            if (!includeCheese)
            {
                Assert.Contains("Hold cheese", bb.SpecialInstructions);
                //instructionCount++;
            }
            //Assert.Equal(instructionCount, bb.SpecialInstructions.Count);
        }

        /// <summary>
        /// to string
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectToString()
        {
            BriarheartBurger bb = new BriarheartBurger();
            Assert.NotNull(bb.ToString());
        }

        /// <summary>
        /// Checks if Entree class is abstract
        /// </summary>
        [Fact]
        public void ShouldBeAssignableToAbstractDrinkClass()
        {
            var bar = new BriarheartBurger();
            Assert.IsAssignableFrom<Entree>(bar);
        }

        /// <summary>
        /// checks if all items can be cast to their base class
        /// </summary>
        [Fact]
        public void ShouldBeAssignableToIOrderItem()
        {
            var bar = new BriarheartBurger();
            Assert.IsAssignableFrom<IOrderItem>(bar);
        }

        /// <summary>
        /// Checks if bun property is notified
        /// </summary>
        [Fact]
        public void ChangingBunNotifiesBunProperty()
        {
            var bb = new BriarheartBurger();
            Assert.PropertyChanged(bb, "Bun", () =>
            {
                bb.Bun1 = true;
            });

            Assert.PropertyChanged(bb, "Bun", () =>
            {
                bb.Bun1 = false;
            });
        }
        /// <summary>
        /// Checks if ketchup property is notified
        /// </summary>
        [Fact]
        public void ChangingKetchupNotifiesKetchupProperty()
        {
            var bb = new BriarheartBurger();
            Assert.PropertyChanged(bb, "Ketchup", () =>
            {
                bb.Ketchup1 = true;
            });

            Assert.PropertyChanged(bb, "Ketchup", () =>
            {
                bb.Ketchup1 = false;
            });
        }

        /// <summary>
        /// Checks if Mustard property is notified
        /// </summary>
        [Fact]
        public void ChangingMustardNotifiesMustardProperty()
        {
            var bb = new BriarheartBurger();
            Assert.PropertyChanged(bb, "Mustard", () =>
            {
                bb.Mustard1 = true;
            });

            Assert.PropertyChanged(bb, "Mustard", () =>
            {
                bb.Mustard1 = false;
            });
        }

        /// <summary>
        /// Checks if Pickles property is notified
        /// </summary>
        [Fact]
        public void ChangingPicklesNotifiesPicklesProperty()
        {
            var bb = new BriarheartBurger();
            Assert.PropertyChanged(bb, "Pickle", () =>
            {
                bb.Pickle1 = true;
            });

            Assert.PropertyChanged(bb, "Pickle", () =>
            {
                bb.Pickle1 = false;
            });
        }

        /// <summary>
        /// Checks if cheese property is notified
        /// </summary>
        [Fact]
        public void ChangingCheeseNotifiesCheeseProperty()
        {
            var bb = new BriarheartBurger();
            Assert.PropertyChanged(bb, "Cheese", () =>
            {
                bb.Cheese1 = true;
            });

            Assert.PropertyChanged(bb, "Cheese", () =>
            {
                bb.Cheese1 = false;
            });
        }

        /// <summary>
        /// Implements the INotify Property Change
        /// </summary>
        [Fact]
        public void ImplementsINotifyPropertyChange()
        {
            var bb = new BriarheartBurger();
            Assert.IsAssignableFrom<System.ComponentModel.INotifyPropertyChanged>(bb);
        }

        [Fact]
        public void ShouldHaveCorrectDescription()
        {
            var bb = new BriarheartBurger();
            Assert.Equal("Single patty burger on a brioche bun. Comes with ketchup, mustard, pickle, and cheese.", bb.Description);
        }
    }
}