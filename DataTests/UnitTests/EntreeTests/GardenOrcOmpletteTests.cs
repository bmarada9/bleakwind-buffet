/*
 * Author: Zachery Brunner
 * Class: GardenOrcOmeletteTests.cs
 * Purpose: Test the GardenOrcOmelette.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class GardenOrcOmeletteTests
    {
        [Fact]
        public void ShouldInlcudeBroccoliByDefault()
        {
            GardenOrcOmelette go = new GardenOrcOmelette();
            Assert.True(go.Broccoli);
        }

        [Fact]
        public void ShouldInlcudeMushroomsByDefault()
        {
            GardenOrcOmelette go = new GardenOrcOmelette();
            Assert.True(go.Mushrooms);
        }

        [Fact]
        public void ShouldInlcudeTomatoByDefault()
        {
            GardenOrcOmelette go = new GardenOrcOmelette();
            Assert.True(go.Tomato);
        }

        [Fact]
        public void ShouldInlcudeCheddarByDefault()
        {
            GardenOrcOmelette go = new GardenOrcOmelette();
            Assert.True(go.Cheddar);
        }

        [Fact]
        public void ShouldBeAbleToSetBroccoli()
        {
            GardenOrcOmelette go = new GardenOrcOmelette();
            go.Broccoli = true;
            Assert.True(go.Broccoli);
            go.Broccoli = false;
            Assert.False(go.Broccoli);
        }

        [Fact]
        public void ShouldBeAbleToSetMushrooms()
        {
            GardenOrcOmelette go = new GardenOrcOmelette();
            go.Mushrooms = true;
            Assert.True(go.Mushrooms);
            go.Mushrooms = false;
            Assert.False(go.Mushrooms);
        }

        [Fact]
        public void ShouldBeAbleToSetTomato()
        {
            GardenOrcOmelette go = new GardenOrcOmelette();
            go.Tomato = true;
            Assert.True(go.Tomato);
            go.Tomato = false;
            Assert.False(go.Tomato);
        }

        [Fact]
        public void ShouldBeAbleToSetCheddar()
        {
            GardenOrcOmelette go = new GardenOrcOmelette();
            go.Cheddar = true;
            Assert.True(go.Cheddar);
            go.Cheddar = false;
            Assert.False(go.Cheddar);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            GardenOrcOmelette go = new GardenOrcOmelette();
            Assert.Equal(4.57, go.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            GardenOrcOmelette go = new GardenOrcOmelette();
            Assert.Equal(404u, go.Calories);
        }

        [Theory]
        [InlineData(true, true, true, true)]
        [InlineData(false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeBroccoli, bool includeMushrooms,
                                                            bool includeTomato, bool includeCheddar)
        {
            GardenOrcOmelette go = new GardenOrcOmelette();
            if (!includeBroccoli) Assert.Contains("Hold broccoli", go.SpecialInstructions);
            if (!includeMushrooms) Assert.Contains("Hold mushrooms", go.SpecialInstructions);
            if (!includeTomato) Assert.Contains("Hold tomato", go.SpecialInstructions);
            if (!includeCheddar) Assert.Contains("Hold cheddar", go.SpecialInstructions);
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            GardenOrcOmelette go = new GardenOrcOmelette();
            Assert.NotNull(go.ToString());
        }
    }
}