/*
 * Author: Bhargav Marada
 * Class name: MadOtarGrits.cs
 * Purpose: a class to represent the Mad Otar Grits
 */
using System;
using System.Collections.Generic;
using System.Text;

using Size = BleakwindBuffet.Data.Enums.Size;

namespace Bleakwindbuffet.Data.Sides
{
    public class MadOtarGrits
    {
        /// <summary>
        /// price of small 
        /// </summary>
        public double PriceSmall { get; } = 1.22;
        // <summary>
        /// price of medium 
        /// </summary>
        public double PriceMedium { get; } = 1.58;
        // <summary>
        /// price of large 
        /// </summary>
        public double PriceLarge { get; } = 1.93;

        // <summary>
        /// Calories of small 
        /// </summary>
        public uint CaloriesSmall { get; } = 105;
        // <summary>
        /// Calories of medium 
        /// </summary>
        public uint CaloriesMedium { get; } = 142;
        // <summary>
        /// Calories of large 
        /// </summary>
        public uint CaloriesLarge { get; } = 179;

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
            return Size + " Mad Otar Grits";
        }
    }
}
