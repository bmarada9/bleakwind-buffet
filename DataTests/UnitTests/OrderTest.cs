/*Author: Katayoun Katy Davoudi
 * Class: OrderTest.cs
 * Purpose: has tests that relate to the order class
 */
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace BleakwindBuffet.DataTests
{
    public class OrderTest
    {

        /// <summary>
        /// checks for subtotal 
        /// </summary>
        [Fact]
        public void CheckOrderSubtotal()
        {
            Order order = new Order();
            Assert.Equal(0, order.SubTotal);

        }
        /// <summary>
        /// checks for total
        /// </summary>
        [Fact]
        public void CheckOrderTotal()
        {
            Order order = new Order();
            Assert.Equal(0, order.Total);

        }
        /// <summary>
        /// checks for calories
        /// </summary>
        [Fact]
        public void CheckOrderCalories()
        {
            Order order = new Order();
            Assert.Equal(0, (int)order.Calories);

        }
        /// <summary>
        /// checks for sales tax
        /// </summary>
        [Fact]
        public void CheckOrderSalesTax()
        {
            Order order = new Order();
            Assert.Equal(0.12, order.SalesTaxRate);

        }
        /// <summary>
        /// checking the items being added on to the list has correct subtotal
        /// </summary>
        [Fact]
        public void CheckThatCorrectItemsAreOnList()
        {
            BriarheartBurger bb = new BriarheartBurger();
            Order order = new Order();
            order.Add(bb);
            Assert.Equal(bb.Price, order.SubTotal);

        }
        /// <summary>
        /// checking I notify property changed
        /// </summary>
        [Fact]
        public void CheckingINotifyPropertyChange()
        {
            Order order = new Order();
            BriarheartBurger bb = new BriarheartBurger();

            order.Add(bb);
            Assert.PropertyChanged(order, "Calories", () => { order.Add(bb); });
        }

    }
}