/*
 * Author: Bhargav Marada
 * Class name: MarkarthMilk.cs
 * Purpose: a class to represent the MarkarthMilk
 */
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data;
using Size = BleakwindBuffet.Data.Enums.Size;

namespace Bleakwindbuffet.Data.Drinks
{
    public class AretinoAppleJuice
    {
        /// <summary>
        /// price of small 
        /// </summary>
        public double PriceSmall { get; } = 0.62;
        // <summary>
        /// price of medium 
        /// </summary>
        public double PriceMedium { get; } = 0.87;
        // <summary>
        /// price of large 
        /// </summary>
        public double PriceLarge { get; } = 1.01;

        // <summary>
        /// Calories of small 
        /// </summary>
        public uint CaloriesSmall { get; } = 44;
        // <summary>
        /// Calories of medium 
        /// </summary>
        public uint CaloriesMedium { get; } = 88;
        // <summary>
        /// Calories of large 
        /// </summary>
        public uint CaloriesLarge { get; } = 132;

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
            return Size + " Aretino Apple Juice";
        }

    }
}