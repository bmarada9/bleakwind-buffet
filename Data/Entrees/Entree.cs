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
using System.ComponentModel;

namespace BleakwindBuffet.Data.Entrees
{
    public abstract class Entree : IOrderItem
    {
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// a price getter
        /// </summary>
        public abstract double Price { get; }

        /// <summary>
        /// a calories getter
        /// </summary>
        public abstract uint Calories { get; }

        public string Description
        {
            get
            {
                return "It's an Entree";
            }
        }

        /// <summary>
        /// a special instructions getter
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }
    }
}
