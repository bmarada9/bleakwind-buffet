/*
 * Author: Bhargav Marada
 * Class: ThalmorTripleTests.cs
 * Purpose: Test the ThalmorTriple.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class ThalmorTripleTests
    {
        /// <summary>
        /// default bun
        /// </summary>
        [Fact]
        public void ShouldIncludeBunByDefault()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.True(tt.Bun);
        }

        /// <summary>
        /// default ketchup
        /// </summary>
        [Fact]
        public void ShouldIncludeKetchupByDefault()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.True(tt.Ketchup);
        }

        /// <summary>
        /// default mustard
        /// </summary>
        [Fact]
        public void ShouldIncludeMustardByDefault()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.True(tt.Mustard);
        }

        /// <summary>
        /// default pickle
        /// </summary>
        [Fact]
        public void ShouldIncludePickleByDefault()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.True(tt.Pickle);
        }

        /// <summary>
        /// default cheese
        /// </summary>
        [Fact]
        public void ShouldIncludeCheeseByDefault()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.True(tt.Cheese);
        }

        /// <summary>
        /// default tomato
        /// </summary>
        [Fact]
        public void ShouldIncludeTomatoByDefault()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.True(tt.Tomato);
        }

        /// <summary>
        /// default lettuce
        /// </summary>
        [Fact]
        public void ShouldIncludeLettuceByDefault()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.True(tt.Lettuce);
        }

        /// <summary>
        /// default mayo
        /// </summary>
        [Fact]
        public void ShouldIncludeMayoByDefault()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.True(tt.Mayo);
        }

        /// <summary>
        /// default bacon
        /// </summary>
        [Fact]
        public void ShouldIncludeBaconByDefault()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.True(tt.Bacon);
        }

        /// <summary>
        /// default egg
        /// </summary>
        [Fact]
        public void ShouldIncludeEggByDefault()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.True(tt.Egg);
        }

        /// <summary>
        /// choose if you want a bun
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetBun()
        {
            ThalmorTriple tt = new ThalmorTriple();
            tt.Bun = true;
            Assert.True(tt.Bun);
            tt.Bun = false;
            Assert.False(tt.Bun);
        }

        /// <summary>
        /// choose if you want ketchup
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetKetchup()
        {
            ThalmorTriple tt = new ThalmorTriple();
            tt.Ketchup = true;
            Assert.True(tt.Ketchup);
            tt.Ketchup = false;
            Assert.False(tt.Ketchup);
        }

        /// <summary>
        /// choose if you want mustard
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetMustard()
        {
            ThalmorTriple tt = new ThalmorTriple();
            tt.Mustard = true;
            Assert.True(tt.Mustard);
            tt.Mustard = false;
            Assert.False(tt.Mustard);
        }

        /// <summary>
        /// choose if you want a pickle
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetPickle()
        {
            ThalmorTriple tt = new ThalmorTriple();
            tt.Pickle = true;
            Assert.True(tt.Pickle);
            tt.Pickle = false;
            Assert.False(tt.Pickle);
        }

        /// <summary>
        /// choose if you want cheese
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetCheese()
        {
            ThalmorTriple tt = new ThalmorTriple();
            tt.Cheese = true;
            Assert.True(tt.Cheese);
            tt.Cheese = false;
            Assert.False(tt.Cheese);
        }

        /// <summary>
        /// choose if you want a tomato
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetTomato()
        {
            ThalmorTriple tt = new ThalmorTriple();
            tt.Tomato = true;
            Assert.True(tt.Tomato);
            tt.Tomato = false;
            Assert.False(tt.Tomato);
        }

        /// <summary>
        /// choose if you want lettuce
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetLettuce()
        {
            ThalmorTriple tt = new ThalmorTriple();
            tt.Lettuce = true;
            Assert.True(tt.Lettuce);
            tt.Lettuce = false;
            Assert.False(tt.Lettuce);
        }

        /// <summary>
        /// choose if you want mayo
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetMayo()
        {
            ThalmorTriple tt = new ThalmorTriple();
            tt.Mayo = true;
            Assert.True(tt.Mayo);
            tt.Mayo = false;
            Assert.False(tt.Mayo);
        }

        /// <summary>
        /// choose if you want bacon
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetBacon()
        {
            ThalmorTriple tt = new ThalmorTriple();
            tt.Bacon = true;
            Assert.True(tt.Bacon);
            tt.Bacon = false;
            Assert.False(tt.Bacon);
        }

        /// <summary>
        /// choose if you want egg
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetEgg()
        {
            ThalmorTriple tt = new ThalmorTriple();
            tt.Egg = true;
            Assert.True(tt.Egg);
            tt.Egg = false;
            Assert.False(tt.Egg);
        }

        /// <summary>
        /// creturns the price
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.Equal(8.32, tt.Price);
        }

        /// <summary>
        /// calories
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.Equal(943u, tt.Calories);
        }

        /// <summary>
        /// special instrutions
        /// </summary>
        /// <param name="includeBun">bun</param>
        /// <param name="includeKetchup">ketchup</param>
        /// <param name="includeMustard">mustard</param>
        /// <param name="includePickle">pickles</param>
        /// <param name="includeCheese"cheese></param>
        /// <param name="includeTomato">tomato</param>
        /// <param name="includeLettuce">lettuce</param>
        /// <param name="includeMayo">mayo</param>
        /// <param name="includeBacon">bacon</param>
        /// <param name="includeEgg">egg</param>
        [Theory]
        [InlineData(true, true, true, true, true, true, true, true, true, true)]
        [InlineData(false, false, false, false, false, false, false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeBun, bool includeKetchup, bool includeMustard,
                                                                    bool includePickle, bool includeCheese, bool includeTomato,
                                                                    bool includeLettuce, bool includeMayo,
                                                                    bool includeBacon, bool includeEgg)
        {
            ThalmorTriple tt = new ThalmorTriple() { Bun = includeBun, Ketchup = includeKetchup, Mustard = includeMustard, Pickle = includePickle, Cheese = includeCheese, Tomato = includeTomato, Lettuce = includeLettuce, Mayo = includeMayo, Bacon = includeBacon, Egg = includeEgg };
            //int instructionCount = 0;
            if (!includeBun)
            {
                Assert.Contains("Hold bun", tt.SpecialInstructions);
                //instructionCount++;
            }
            if (!includeKetchup)
            {
                Assert.Contains("Hold ketchup", tt.SpecialInstructions);
                //instructionCount++;
            }
            if (!includeMustard)
            {
                Assert.Contains("Hold mustard", tt.SpecialInstructions);
                //instructionCount++;
            }
            if (!includePickle)
            {
                Assert.Contains("Hold pickle", tt.SpecialInstructions);
                //instructionCount++;
            }
            if (!includeCheese)
            {
                Assert.Contains("Hold cheese", tt.SpecialInstructions);
                //instructionCount++;
            }
            if (!includeTomato)
            {
                Assert.Contains("Hold tomato", tt.SpecialInstructions);
                //instructionCount++;
            }
            if (!includeLettuce)
            {
                Assert.Contains("Hold lettuce", tt.SpecialInstructions);
                //instructionCount++;
            }
            if (!includeMayo)
            {
                Assert.Contains("Hold mayo", tt.SpecialInstructions);
                //instructionCount++;
            }
            if (!includeBacon)
            {
                Assert.Contains("Hold bacon", tt.SpecialInstructions);
                //instructionCount++;
            }
            if (!includeEgg)
            {
                Assert.Contains("Hold egg", tt.SpecialInstructions);
                //instructionCount++;
            }
        }

        /// <summary>
        /// to string
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectToString()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.NotNull(tt.ToString());
        }
    }
}