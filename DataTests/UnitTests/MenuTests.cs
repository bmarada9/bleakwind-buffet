/*
 * Author: Bhargav Marada
 * Class: MenuTests.cs
 * Purpose: Test the Menu.cs class in the Data library
 */
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using Xunit;

namespace BleakwindBuffet.DataTests.UnitTests
{
    public class MenuTests
    {
        [Fact]
        public void CheckThatAllEntreesAreReturned()
        {
            IEnumerable<IOrderItem> entree = Menu.Entrees();
            Assert.Collection(entree,
                item => Assert.Equal("Briarheart Burger", item.ToString()),
                item => Assert.Equal("Double Draugr", item.ToString()),
                item => Assert.Equal("Garden Orc Omelette", item.ToString()),
                item => Assert.Equal("Philly Poacher", item.ToString()),
                item => Assert.Equal("Smokehouse Skeleton", item.ToString()),
                item => Assert.Equal("Thalmor Triple", item.ToString()),
                item => Assert.Equal("Thugs T-Bone", item.ToString()));

        }

        [Fact]
        public void CheckThatAllDrinksAreReturned()
        {
            IEnumerable<IOrderItem> drink = Menu.Drinks();
            Assert.Collection(drink,
                item => Assert.Equal("Small Aretino Apple Juice", item.ToString()),
                item => Assert.Equal("Small Candlehearth Coffee", item.ToString()),
                item => Assert.Equal("Small Markarth Milk", item.ToString()),
                item => Assert.Equal("Small Blackberry Sailor Soda", item.ToString()),
                item => Assert.Equal("Small Cherry Sailor Soda", item.ToString()),
                item => Assert.Equal("Small Grapefruit Sailor Soda", item.ToString()),
                item => Assert.Equal("Small Lemon Sailor Soda", item.ToString()),
                item => Assert.Equal("Small Peach Sailor Soda", item.ToString()),
                item => Assert.Equal("Small Watermelon Sailor Soda", item.ToString()),
                item => Assert.Equal("Small Warrior Water", item.ToString()),

                item => Assert.Equal("Medium Aretino Apple Juice", item.ToString()),
                item => Assert.Equal("Medium Candlehearth Coffee", item.ToString()),
                item => Assert.Equal("Medium Markarth Milk", item.ToString()),
                item => Assert.Equal("Medium Blackberry Sailor Soda", item.ToString()),
                item => Assert.Equal("Medium Cherry Sailor Soda", item.ToString()),
                item => Assert.Equal("Medium Grapefruit Sailor Soda", item.ToString()),
                item => Assert.Equal("Medium Lemon Sailor Soda", item.ToString()),
                item => Assert.Equal("Medium Peach Sailor Soda", item.ToString()),
                item => Assert.Equal("Medium Watermelon Sailor Soda", item.ToString()),
                item => Assert.Equal("Medium Warrior Water", item.ToString()),

                item => Assert.Equal("Large Aretino Apple Juice", item.ToString()),
                item => Assert.Equal("Large Candlehearth Coffee", item.ToString()),
                item => Assert.Equal("Large Markarth Milk", item.ToString()),
                item => Assert.Equal("Large Blackberry Sailor Soda", item.ToString()),
                item => Assert.Equal("Large Cherry Sailor Soda", item.ToString()),
                item => Assert.Equal("Large Grapefruit Sailor Soda", item.ToString()),
                item => Assert.Equal("Large Lemon Sailor Soda", item.ToString()),
                item => Assert.Equal("Large Peach Sailor Soda", item.ToString()),
                item => Assert.Equal("Large Watermelon Sailor Soda", item.ToString()),
                item => Assert.Equal("Large Warrior Water", item.ToString()));
        }

        [Fact]
        public void CheckThatAllSidesAreReturned()
        {
            IEnumerable<IOrderItem> sides = Menu.Sides();
            Assert.Collection(sides,
                item => Assert.Equal("Small Dragonborn Waffle Fries", item.ToString()),
                item => Assert.Equal("Small Fried Miraak", item.ToString()),
                item => Assert.Equal("Small Mad Otar Grits", item.ToString()),
                item => Assert.Equal("Small Vokun Salad", item.ToString()),

                item => Assert.Equal("Medium Dragonborn Waffle Fries", item.ToString()),
                item => Assert.Equal("Medium Fried Miraak", item.ToString()),
                item => Assert.Equal("Medium Mad Otar Grits", item.ToString()),
                item => Assert.Equal("Medium Vokun Salad", item.ToString()),

                item => Assert.Equal("Large Dragonborn Waffle Fries", item.ToString()),
                item => Assert.Equal("Large Fried Miraak", item.ToString()),
                item => Assert.Equal("Large Mad Otar Grits", item.ToString()),
                item => Assert.Equal("Large Vokun Salad", item.ToString()));

        }

        [Fact]
        public void CheckThatFullMenuIsReturned()
        {
            IEnumerable<IOrderItem> menu = Menu.FullMenu();
            Assert.Collection(menu,
                item => Assert.Equal("Briarheart Burger", item.ToString()),
                item => Assert.Equal("Double Draugr", item.ToString()),
                item => Assert.Equal("Garden Orc Omelette", item.ToString()),
                item => Assert.Equal("Philly Poacher", item.ToString()),
                item => Assert.Equal("Smokehouse Skeleton", item.ToString()),
                item => Assert.Equal("Thalmor Triple", item.ToString()),
                item => Assert.Equal("Thugs T-Bone", item.ToString()),

                item => Assert.Equal("Small Aretino Apple Juice", item.ToString()),
                item => Assert.Equal("Small Candlehearth Coffee", item.ToString()),
                item => Assert.Equal("Small Markarth Milk", item.ToString()),
                item => Assert.Equal("Small Blackberry Sailor Soda", item.ToString()),
                item => Assert.Equal("Small Cherry Sailor Soda", item.ToString()),
                item => Assert.Equal("Small Grapefruit Sailor Soda", item.ToString()),
                item => Assert.Equal("Small Lemon Sailor Soda", item.ToString()),
                item => Assert.Equal("Small Peach Sailor Soda", item.ToString()),
                item => Assert.Equal("Small Watermelon Sailor Soda", item.ToString()),
                item => Assert.Equal("Small Warrior Water", item.ToString()),

                item => Assert.Equal("Medium Aretino Apple Juice", item.ToString()),
                item => Assert.Equal("Medium Candlehearth Coffee", item.ToString()),
                item => Assert.Equal("Medium Markarth Milk", item.ToString()),
                item => Assert.Equal("Medium Blackberry Sailor Soda", item.ToString()),
                item => Assert.Equal("Medium Cherry Sailor Soda", item.ToString()),
                item => Assert.Equal("Medium Grapefruit Sailor Soda", item.ToString()),
                item => Assert.Equal("Medium Lemon Sailor Soda", item.ToString()),
                item => Assert.Equal("Medium Peach Sailor Soda", item.ToString()),
                item => Assert.Equal("Medium Watermelon Sailor Soda", item.ToString()),
                item => Assert.Equal("Medium Warrior Water", item.ToString()),

                item => Assert.Equal("Large Aretino Apple Juice", item.ToString()),
                item => Assert.Equal("Large Candlehearth Coffee", item.ToString()),
                item => Assert.Equal("Large Markarth Milk", item.ToString()),
                item => Assert.Equal("Large Blackberry Sailor Soda", item.ToString()),
                item => Assert.Equal("Large Cherry Sailor Soda", item.ToString()),
                item => Assert.Equal("Large Grapefruit Sailor Soda", item.ToString()),
                item => Assert.Equal("Large Lemon Sailor Soda", item.ToString()),
                item => Assert.Equal("Large Peach Sailor Soda", item.ToString()),
                item => Assert.Equal("Large Watermelon Sailor Soda", item.ToString()),
                item => Assert.Equal("Large Warrior Water", item.ToString()),

                item => Assert.Equal("Small Dragonborn Waffle Fries", item.ToString()),
                item => Assert.Equal("Small Fried Miraak", item.ToString()),
                item => Assert.Equal("Small Mad Otar Grits", item.ToString()),
                item => Assert.Equal("Small Vokun Salad", item.ToString()),

                item => Assert.Equal("Medium Dragonborn Waffle Fries", item.ToString()),
                item => Assert.Equal("Medium Fried Miraak", item.ToString()),
                item => Assert.Equal("Medium Mad Otar Grits", item.ToString()),
                item => Assert.Equal("Medium Vokun Salad", item.ToString()),

                item => Assert.Equal("Large Dragonborn Waffle Fries", item.ToString()),
                item => Assert.Equal("Large Fried Miraak", item.ToString()),
                item => Assert.Equal("Large Mad Otar Grits", item.ToString()),
                item => Assert.Equal("Large Vokun Salad", item.ToString()));

        }

        [Theory]
        [InlineData("Entree")]
        [InlineData("Side")]
        [InlineData("Drink")]
        public void ShouldHaveEachDifferentCategory(string type)
        {
            Assert.Contains(type, Menu.Category);
        }

        [Theory]
        [InlineData(null)]
        [InlineData("Burger")]
        [InlineData("Apple")]
        [InlineData("Small")]

        public void SearchReturnsAllItemsContainingSearchString(string searchItem)
        {
            IEnumerable<IOrderItem> fullMenu = Menu.FullMenu();
            IEnumerable<IOrderItem> results = Menu.Search(fullMenu, searchItem);
            if (searchItem == null)
            {
                Assert.Equal(fullMenu, results);
            }
            foreach (IOrderItem i in fullMenu)
            {
                if (i.ToString().Contains(searchItem))
                {
                    Assert.Contains(i, results);
                }
            }
        }

        [Fact]
        public void FilterByCategoryTest()
        {
            IEnumerable<IOrderItem> fullMenu = Menu.FullMenu();
            IEnumerable<string> category = new List<string>() { "Entree" };

            fullMenu = Menu.FilterByCategory(fullMenu, category);

            foreach (IOrderItem item in fullMenu)
            {
                Assert.Contains(item, Menu.Entrees());
            }

            category = new List<string>() { "Drink" };
            fullMenu = Menu.FilterByCategory(fullMenu, category);

            foreach (IOrderItem item in fullMenu)
            {
                Assert.Contains(item, Menu.Drinks());
            }

            category = new List<string>() { "Side" };
            fullMenu = Menu.FilterByCategory(fullMenu, category);

            foreach (IOrderItem item in fullMenu)
            {
                Assert.Contains(item, Menu.Sides());
            }
        }

        [Theory]
        [InlineData(null, null)]
        [InlineData(0, 50)]
        [InlineData(50, 150)]
        [InlineData(0, 500)]
        public void FilterByCaloriesTest(int? min, int? max)
        {
            IEnumerable<IOrderItem> fullMenu = Menu.FullMenu();
            IEnumerable<IOrderItem> results = Menu.FilterByCalories(fullMenu, min, max);

            if (min == null && max == null)
            {
                Assert.Equal(fullMenu, results);
            }
            else
            {
                foreach (IOrderItem item in fullMenu)
                {
                    if (item.Calories <= max && item.Calories >= min)
                    {
                        Assert.Contains(item, results);
                    }
                }
            }
        }

        [Theory]
        [InlineData(null, null)]
        [InlineData(0, 5.00)]
        [InlineData(5.00, 8.50)]
        [InlineData(0, 2.50)]
        public void FilterByPriceTest(double? min, double? max)
        {
            IEnumerable<IOrderItem> fullMenu = Menu.FullMenu();
            IEnumerable<IOrderItem> results = Menu.FilterByPrice(fullMenu, min, max);

            if (min == null && max == null)
            {
                Assert.Equal(fullMenu, results);
            }
            else
            {
                foreach (IOrderItem item in fullMenu)
                {
                    if (item.Price <= max && item.Price >= min)
                    {
                        Assert.Contains(item, results);
                    }
                }
            }
        }
    }
}
