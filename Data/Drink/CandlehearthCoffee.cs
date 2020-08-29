﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Drink
{
    class CandlehearthCoffee
    {
    }
}


/*
 * Author: Bhargav Marada
 * Class name: MarkarthMilk.cs
 * Purpose: a class to represent the MarkarthMilk
 */
using System;
using System.Collections.Generic;
using System.Text;

using Size = BleakwindBuffet.Data.Enums.Size;

namespace Data.Drink
{
    class CandlehearthCoffe
    {
        /// <summary>
        /// price of small 
        /// </summary>
        public double PriceSmall { get; } = 1.05;
        // <summary>
        /// price of medium 
        /// </summary>
        public double PriceMedium { get; } = 1.11;
        // <summary>
        /// price of large 
        /// </summary>
        public double PriceLarge { get; } = 1.22;

        // <summary>
        /// Calories of small 
        /// </summary>
        public uint CaloriesSmall { get; } = 56;
        // <summary>
        /// Calories of medium 
        /// </summary>
        public uint CaloriesMedium { get; } = 72;
        // <summary>
        /// Calories of large 
        /// </summary>
        public uint CaloriesLarge { get; } = 93;

        // <summary>
        /// ice in drink 
        /// </summary>
        public bool Ice { get; set; } = false;

        // <summary>
        /// size of drink 
        /// </summary>
        public Size Size { get; set; } = Size.Small;

        // <summary>
        /// special instructions for drink 
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> SpecialInstructions = new List<string>();
                if (!Ice) SpecialInstructions.Add("Add Ice");

                return SpecialInstructions;
            }
        }

        // <summary>
        /// to string for drink 
        /// </summary>
        public override string ToString()
        {
            return Size + " Markarth Milk";
        }

    }