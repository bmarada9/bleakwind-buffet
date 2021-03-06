﻿/*
 * Author: Bhargav Marada
 * Class name: Order.cs
 * Purpose: A class to represent the customers order
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using System.Collections.Specialized;
using System.Collections;
namespace BleakwindBuffet.Data
{
    public class Order: ICollection<IOrderItem>, INotifyCollectionChanged, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public event NotifyCollectionChangedEventHandler CollectionChanged;
        private void ItemEventChange(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "Price")
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Tax"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Total"));
            }
            if (e.PropertyName == "Calories")
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
            }
        }
        List<IOrderItem> items = new List<IOrderItem>();

        /// <summary>
        /// add item to order
        /// </summary>
        /// <param name="order"></param>
        public void Add(IOrderItem order)
        {
            items.Add(order);
            CollectionChanged?.Invoke(this, new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Add, order));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Tax"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Total"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
            order.PropertyChanged += ItemEventChange;
        }

        /// <summary>
        /// remove item from order
        /// </summary>
        /// <param name="order"></param>
        /// <returns></returns>
        public bool Remove(IOrderItem order)
        {
            bool removeCheck = items.Remove(order);
            CollectionChanged?.Invoke(this, new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Remove, order));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Tax"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Total"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
            order.PropertyChanged -= ItemEventChange;
            return removeCheck;
        }

        /// <summary>
        /// the sales tax rate
        /// </summary>
        public double SalesTaxRate { get; set; } = 0.12;

        public double subTotal;
        public double SubTotal
        {
            get
            {
                foreach (IOrderItem io in items)
                {
                    subTotal += io.Price;
                }
                return subTotal;
            }
        }

        /// <summary>
        /// the tax on the order
        /// </summary>
        public double tax;
        public double Tax
        {
            get
            {
                tax = SubTotal * SalesTaxRate;
                return tax;
            }
        }

        /// <summary>
        /// the total price of the order
        /// </summary>
        public double total;
        public double Total
        {
            get
            {
                total = SubTotal + Tax;
                return total;
            }
        }

        /// <summary>
        /// the price of the total order
        /// </summary>
        public uint Calories
        {
            get
            {
                uint calories = 0;
                foreach (IOrderItem io in items)
                {
                    calories += io.Calories;
                }
                return calories;
            }
        }

        /// <summary>
        /// the order number
        /// </summary>
        private static int nextOrderNumber = 1;
        public int Number { get; set; } = nextOrderNumber;

        /// <summary>
        /// clears the order
        /// </summary>
        public void Clear()
        {
            ((ICollection<IOrderItem>)items).Clear();
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Tax"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Total"));
            CollectionChanged?.Invoke(this, new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Reset));
        }


        public bool Contains(IOrderItem item)
        {
            return ((ICollection<IOrderItem>)items).Contains(item);
        }

        public void CopyTo(IOrderItem[] array, int arrayIndex)
        {
            ((ICollection<IOrderItem>)items).CopyTo(array, arrayIndex);
        }

        public IEnumerator<IOrderItem> GetEnumerator()
        {
            return ((IEnumerable<IOrderItem>)items).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)items).GetEnumerator();
        }

        public int Count => ((ICollection<IOrderItem>)items).Count;

        public bool IsReadOnly => ((ICollection<IOrderItem>)items).IsReadOnly;
    }
}
