/*
 * Author: Bhargav Marada
 * Class name: FriedMiraak.cs
 * Purpose: a class to represent the Fried Miraak
 */
using System;
using System.Collections.Generic;
using System.Text;

using Size = BleakwindBuffet.Data.Enums.Size;

namespace Data.Side
{
    class FriedMiraak
    {
        /// <summary>
        /// price of small 
        /// </summary>
        public double PriceSmall { get; } = 0.93;
        // <summary>
        /// price of medium 
        /// </summary>
        public double PriceMedium { get; } = 1.28;
        // <summary>
        /// price of large 
        /// </summary>
        public double PriceLarge { get; } = 1.82;

        // <summary>
        /// Calories of small 
        /// </summary>
        public uint CaloriesSmall { get; } = 41;
        // <summary>
        /// Calories of medium 
        /// </summary>
        public uint CaloriesMedium { get; } = 52;
        // <summary>
        /// Calories of large 
        /// </summary>
        public uint CaloriesLarge { get; } = 73;

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
            return Size + " Vokun Salad";
        }
    }
}
