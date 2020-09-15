/*
 * Author: Bhargav Marada
 * Class: SmokehouseSkeletonTests.cs
 * Purpose: Test the SmokehouseSkeleton.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class SmokehouseSkeletonTests
    {       
        /// <summary>
        /// default sausage
        /// </summary>
        [Fact]
        public void ShouldInlcudeSausageByDefault()
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            Assert.True(ss.SausageLink);
        }

        /// <summary>
        /// default egg
        /// </summary>
        [Fact]
        public void ShouldInlcudeEggByDefault()
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            Assert.True(ss.Egg);
        }

        /// <summary>
        /// default hash browns
        /// </summary>
        [Fact]
        public void ShouldInlcudeHashbrownsByDefault()
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            Assert.True(ss.HashBrowns);
        }

        /// <summary>
        /// default pancake
        /// </summary>
        [Fact]
        public void ShouldInlcudePancakeByDefault()
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            Assert.True(ss.Pancake);
        }

        /// <summary>
        /// choose if you want sausage
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetSausage()
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            ss.SausageLink = true;
            Assert.True(ss.SausageLink);
            ss.SausageLink = false;
            Assert.False(ss.SausageLink);
        }

        /// <summary>
        /// choose if you want egg
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetEgg()
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            ss.Egg = true;
            Assert.True(ss.Egg);
            ss.Egg = false;
            Assert.False(ss.Egg);
        }

        /// <summary>
        /// choose if you want hashbrowns
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetHashbrowns()
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            ss.HashBrowns = true;
            Assert.True(ss.HashBrowns);
            ss.HashBrowns = false;
            Assert.False(ss.HashBrowns);
        }

        /// <summary>
        /// choose if you want pancake
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetPancake()
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            ss.Pancake = true;
            Assert.True(ss.Pancake);
            ss.Pancake = false;
            Assert.False(ss.Pancake);
        }

        /// <summary>
        /// price
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            Assert.Equal(5.32, ss.Price);
        }

        /// <summary>
        /// calories
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            Assert.Equal(602u, ss.Calories);
        }

        /// <summary>
        /// special instructions
        /// </summary>
        /// <param name="includeSausage">hold sausage</param>
        /// <param name="includeEgg">hold egg</param>
        /// <param name="includeHashbrowns">hold hash browns</param>
        /// <param name="includePancake">hold pancake</param>
        [Theory]
        [InlineData(true, true, true, true)]
        [InlineData(false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeSausage, bool includeEgg,
                                                            bool includeHashbrowns, bool includePancake)
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton() { SausageLink = includeSausage, Egg = includeEgg, HashBrowns = includeHashbrowns, Pancake = includePancake};
            if (!includeSausage) Assert.Contains("Hold sausage", ss.SpecialInstructions);
            if (!includeEgg) Assert.Contains("Hold egg", ss.SpecialInstructions);
            if (!includeHashbrowns) Assert.Contains("Hold hash browns", ss.SpecialInstructions);
            if (!includePancake) Assert.Contains("Hold pancakes", ss.SpecialInstructions);
        }

        /// <summary>
        /// to string
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectToString()
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            Assert.NotNull(ss.ToString());
        }

        /// <summary>
        /// Checks if Entree class is abstract
        /// </summary>
        [Fact]
        public void ShouldBeAssignableToAbstractDrinkClass()
        {
            var bar = new SmokehouseSkeleton();
            Assert.IsAssignableFrom<Entree>(bar);
        }

        /// <summary>
        /// checks if all items can be cast to their base class
        /// </summary>
        [Fact]
        public void ShouldBeAssignableToIOrderItem()
        {
            var bar = new SmokehouseSkeleton();
            Assert.IsAssignableFrom<IOrderItem>(bar);
        }
    }
}