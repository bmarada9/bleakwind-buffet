/*
 * Author: Bhargav Marada
 * Class name: Entree.cs
 * Purpose: an abstract sides class
 */
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Sides;
using Size = BleakwindBuffet.Data.Enums.Size;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Sides
{
    public abstract class Side: IOrderItem
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private Size size = Size.Small;
        /// <summary>
        /// The size of the side
        /// </summary>
        public virtual Size Size
        {
            get
            {
                return size;
            }
            set
            {
                size = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Small"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Medium"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Large"));
            }
        }

        /// <summary>
        /// a price getter
        /// </summary>
        public abstract double Price { get; }

        /// <summary>
        /// a calories getter
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// a special instructions getter
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }
    }
}
