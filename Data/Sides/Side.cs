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

namespace BleakwindBuffet.Data.Sides
{
    public abstract class Side: IOrderItem
    {
        /// <summary>
        /// a size getter and setter
        /// </summary>
        public abstract Size Size
        {
            get;
            set;
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
