/*
 * Author: Bhargav Marada
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
        /// <summary>
        /// default brocoli
        /// </summary>
        [Fact]
        public void ShouldInlcudeBroccoliByDefault()
        {
            GardenOrcOmelette go = new GardenOrcOmelette();
            Assert.True(go.Broccoli);
        }

        /// <summary>
        /// default mushrooms
        /// </summary>
        [Fact]
        public void ShouldInlcudeMushroomsByDefault()
        {
            GardenOrcOmelette go = new GardenOrcOmelette();
            Assert.True(go.Mushrooms);
        }

        /// <summary>
        /// default tomato
        /// </summary>
        [Fact]
        public void ShouldInlcudeTomatoByDefault()
        {
            GardenOrcOmelette go = new GardenOrcOmelette();
            Assert.True(go.Tomato);
        }

        /// <summary>
        /// default cheddar
        /// </summary>
        [Fact]
        public void ShouldInlcudeCheddarByDefault()
        {
            GardenOrcOmelette go = new GardenOrcOmelette();
            Assert.True(go.Cheddar);
        }

        /// <summary>
        /// choose to have broccoli
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetBroccoli()
        {
            GardenOrcOmelette go = new GardenOrcOmelette();
            go.Broccoli = true;
            Assert.True(go.Broccoli);
            go.Broccoli = false;
            Assert.False(go.Broccoli);
        }

        /// <summary>
        /// choose to have mushrooms
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetMushrooms()
        {
            GardenOrcOmelette go = new GardenOrcOmelette();
            go.Mushrooms = true;
            Assert.True(go.Mushrooms);
            go.Mushrooms = false;
            Assert.False(go.Mushrooms);
        }

        /// <summary>
        /// choose to have tomato
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetTomato()
        {
            GardenOrcOmelette go = new GardenOrcOmelette();
            go.Tomato = true;
            Assert.True(go.Tomato);
            go.Tomato = false;
            Assert.False(go.Tomato);
        }

        /// <summary>
        /// choose to have cheddar
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetCheddar()
        {
            GardenOrcOmelette go = new GardenOrcOmelette();
            go.Cheddar = true;
            Assert.True(go.Cheddar);
            go.Cheddar = false;
            Assert.False(go.Cheddar);
        }

        /// <summary>
        /// price
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            GardenOrcOmelette go = new GardenOrcOmelette();
            Assert.Equal(4.57, go.Price);
        }

        /// <summary>
        /// calories
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            GardenOrcOmelette go = new GardenOrcOmelette();
            Assert.Equal(404u, go.Calories);
        }

        /// <summary>
        /// special instructions
        /// </summary>
        /// <param name="includeBroccoli">hold broccoli</param>
        /// <param name="includeMushrooms">hold mushrooms</param>
        /// <param name="includeTomato">hold tomato</param>
        /// <param name="includeCheddar">hold cheddar</param>
        [Theory]
        [InlineData(true, true, true, true)]
        [InlineData(false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeBroccoli, bool includeMushrooms,
                                                            bool includeTomato, bool includeCheddar)
        {
            GardenOrcOmelette go = new GardenOrcOmelette() { Broccoli = includeBroccoli, Mushrooms = includeMushrooms, Tomato = includeTomato, Cheddar = includeCheddar};
            if (!includeBroccoli) Assert.Contains("Hold broccoli", go.SpecialInstructions);
            if (!includeMushrooms) Assert.Contains("Hold mushrooms", go.SpecialInstructions);
            if (!includeTomato) Assert.Contains("Hold tomato", go.SpecialInstructions);
            if (!includeCheddar) Assert.Contains("Hold cheddar", go.SpecialInstructions);
        }

        /// <summary>
        /// to string
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectToString()
        {
            GardenOrcOmelette go = new GardenOrcOmelette();
            Assert.NotNull(go.ToString());
        }

        /// <summary>
        /// Checks if Entree class is abstract
        /// </summary>
        [Fact]
        public void ShouldBeAssignableToAbstractDrinkClass()
        {
            var bar = new GardenOrcOmelette();
            Assert.IsAssignableFrom<Entree>(bar);
        }

        /// <summary>
        /// checks if all items can be cast to their base class
        /// </summary>
        [Fact]
        public void ShouldBeAssignableToIOrderItem()
        {
            var bar = new GardenOrcOmelette();
            Assert.IsAssignableFrom<IOrderItem>(bar);
        }

        /// <summary>
        /// Checks if broccoli property is notified
        /// </summary>
        [Fact]
        public void ChangingBroccoliNotifiesBroccoliProperty()
        {
            var go = new GardenOrcOmelette();
            Assert.PropertyChanged(go, "Broccoli", () =>
            {
                go.Broccoli1 = true;
            });

            Assert.PropertyChanged(go, "Broccoli", () =>
            {
                go.Broccoli1 = false;
            });
        }

        /// <summary>
        /// Checks if mushrooms property is notified
        /// </summary>
        [Fact]
        public void ChangingMushroomsNotifiesMushroomsProperty()
        {
            var go = new GardenOrcOmelette();
            Assert.PropertyChanged(go, "Mushrooms", () =>
            {
                go.Mushroom = true;
            });

            Assert.PropertyChanged(go, "Mushrooms", () =>
            {
                go.Mushroom = false;
            });
        }

        /// <summary>
        /// Checks if tomato property is notified
        /// </summary>
        [Fact]
        public void ChangingTomatoNotifiesTomatoProperty()
        {
            var go = new GardenOrcOmelette();
            Assert.PropertyChanged(go, "Tomato", () =>
            {
                go.Tomato1 = true;
            });

            Assert.PropertyChanged(go, "Tomato", () =>
            {
                go.Tomato1 = false;
            });
        }

        /// <summary>
        /// Checks if cheddar property is notified
        /// </summary>
        [Fact]
        public void ChangingCheddarNotifiesCheedarProperty()
        {
            var go = new GardenOrcOmelette();
            Assert.PropertyChanged(go, "Cheddar", () =>
            {
                go.Cheddar1 = true;
            });

            Assert.PropertyChanged(go, "Cheddar", () =>
            {
                go.Cheddar1 = false;
            });
        }

        /// <summary>
        /// Implements the INotify Property Change
        /// </summary>
        [Fact]
        public void ImplementsINotifyPropertyChange()
        {
            var go = new GardenOrcOmelette();
            Assert.IsAssignableFrom<System.ComponentModel.INotifyPropertyChanged>(go);
        }
    }
}