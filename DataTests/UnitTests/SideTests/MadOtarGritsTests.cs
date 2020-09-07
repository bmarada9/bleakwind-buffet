/*
 * Author: Bhargav Marada
 * Class: MadOtarGritsTests.cs
 * Purpose: Test the MadOtarGrits.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Sides;

namespace BleakwindBuffet.DataTests.UnitTests.SideTests
{
    public class MadOtarGritsTests
    {
        /// <summary>
        /// size small
        /// </summary>
        [Fact]
        public void ShouldBeSmallByDefault()
        {
            MadOtarGrits mog = new MadOtarGrits();
            Assert.Equal(Size.Small, mog.Size);
        }

        /// <summary>
        /// change size
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            MadOtarGrits mog = new MadOtarGrits();
            mog.Size = Size.Large;
            Assert.Equal(Size.Large, mog.Size);
            mog.Size = Size.Medium;
            Assert.Equal(Size.Medium, mog.Size);
            mog.Size = Size.Small;
            Assert.Equal(Size.Small, mog.Size);
        }
        /// <summary>
        /// special instructions
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectStringOnSpecialInstructions()
        {
            MadOtarGrits mog = new MadOtarGrits();
            Assert.Empty(mog.SpecialInstructions);
        }
        /// <summary>
        /// price
        /// </summary>
        /// <param name="size">size of side</param>
        /// <param name="price">price of stride</param>
        [Theory]
        [InlineData(Size.Small, 1.22)]
        [InlineData(Size.Medium, 1.58)]
        [InlineData(Size.Large, 1.93)]
        public void ShouldReturnCorrectPriceBasedOnSize(Size size, double price)
        {
            MadOtarGrits mog = new MadOtarGrits();
            mog.Size = size;
            Assert.Equal(price, mog.Price);
        }

        /// <summary>
        /// calories
        /// </summary>
        /// <param name="size">size of side</param>
        /// <param name="calories">calories in side</param>
        [Theory]
        [InlineData(Size.Small, 105)]
        [InlineData(Size.Medium, 142)]
        [InlineData(Size.Large, 179)]
        public void ShouldReturnCorrectCaloriesBasedOnSize(Size size, uint calories)
        {
            MadOtarGrits mog = new MadOtarGrits();
            mog.Size = size;
            Assert.Equal(calories, mog.Calories);
        }

        /// <summary>
        /// to string
        /// </summary>
        /// <param name="size"size of side></param>
        /// <param name="name">name of side</param>
        [Theory]
        [InlineData(Size.Small, "Small Mad Otar Grits")]
        [InlineData(Size.Medium, "Medium Mad Otar Grits")]
        [InlineData(Size.Large, "Large Mad Otar Grits")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            MadOtarGrits mog = new MadOtarGrits();
            mog.Size = size;
            Assert.Equal(name, mog.ToString());
        }
    }
}