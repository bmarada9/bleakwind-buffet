/*
 * Author: Bhargav Marada
 * Class name: Entree.cs
 * Purpose: an abstract entree class
 */
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data;

namespace BleakwindBuffet.Data.Entrees
{
    public abstract class Entree : IOrderItem
    {
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
