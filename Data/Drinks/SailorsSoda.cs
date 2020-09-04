/*
 * Author: Bhargav Marada
 * Class name: SailorsSoda.cs
 * Purpose: a class to represent the Sailors Soda
 */
using System;
using System.Collections.Generic;
using System.Text;
using SodaFlavor = BleakwindBuffet.Data.Enums.SodaFlavor;
using Size = BleakwindBuffet.Data.Enums.Size;

namespace Bleakwindbuffet.Data.Drinks
{
    class SailorsSoda
    {
        /// <summary>
        /// price of small 
        /// </summary>
        public double PriceSmall { get; } = 1.42;
        // <summary>
        /// price of medium 
        /// </summary>
        public double PriceMedium { get; } = 1.74;
        // <summary>
        /// price of large 
        /// </summary>
        public double PriceLarge { get; } = 2.07;

        // <summary>
        /// Calories of small 
        /// </summary>
        public uint CaloriesSmall { get; } = 117;
        // <summary>
        /// Calories of medium 
        /// </summary>
        public uint CaloriesMedium { get; } = 153;
        // <summary>
        /// Calories of large 
        /// </summary>
        public uint CaloriesLarge { get; } = 205;

        // <summary>
        /// ice in drink 
        /// </summary>
        public bool Ice { get; set; } = true;

        // <summary>
        /// drink flavor 
        /// </summary>
        public SodaFlavor Flavor { get; set; } = SodaFlavor.Cherry;
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
                if (!Ice) SpecialInstructions.Add("Hold Ice");

                return SpecialInstructions;
            }
        }

        // <summary>
        /// to string for drink 
        /// </summary>
        public override string ToString()
        {
            return Size + " " + Flavor +" Sailor Soda";
        }

    }
}
