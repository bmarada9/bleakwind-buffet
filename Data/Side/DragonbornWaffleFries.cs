/*
 * Author: Bhargav Marada
 * Class name: DragonbornWaffleFries.cs
 * Purpose: a class to represent the Dragonborn Waffle Fries
 */
using System;
using System.Collections.Generic;
using System.Text;

using Size = BleakwindBuffet.Data.Enums.Size;

namespace Data.Side
{
    class DragonBornWaffleFries
    {
        /// <summary>
        /// price of small 
        /// </summary>
        public double PriceSmall { get; } = 0.42;
        // <summary>
        /// price of medium 
        /// </summary>
        public double PriceMedium { get; } = 0.76;
        // <summary>
        /// price of large 
        /// </summary>
        public double PriceLarge { get; } = 0.96;

        // <summary>
        /// Calories of small 
        /// </summary>
        public uint CaloriesSmall { get; } = 77;
        // <summary>
        /// Calories of medium 
        /// </summary>
        public uint CaloriesMedium { get; } = 89;
        // <summary>
        /// Calories of large 
        /// </summary>
        public uint CaloriesLarge { get; } = 100;

        // <summary>
        /// size of side 
        /// </summary>
        public Size Size { get; set; } = Size.Small;

        // <summary>
        /// special instructions for side 
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                return new List<string>();
            }
        }

        // <summary>
        /// to string for side 
        /// </summary>
        public override string ToString()
        {
            return Size + " Dragonborn Waffle Fries";
        }
    }
}
