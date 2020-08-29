/*
 * Author: Bhargav Marada
 * Class name: WarriorWater.cs
 * Purpose: a class to represent the Warrior Water
 */
using System;
using System.Collections.Generic;
using System.Text;

using Size = BleakwindBuffet.Data.Enums.Size;

namespace Data.Drink
{
    class WarriorWater
    {
        /// <summary>
        /// price of small 
        /// </summary>
        public double PriceSmall { get; } = 0;
        // <summary>
        /// price of medium 
        /// </summary>
        public double PriceMedium { get; } = 0;
        // <summary>
        /// price of large 
        /// </summary>
        public double PriceLarge { get; } = 0;

        // <summary>
        /// Calories of small 
        /// </summary>
        public uint CaloriesSmall { get; } = 0;
        // <summary>
        /// Calories of medium 
        /// </summary>
        public uint CaloriesMedium { get; } = 0;
        // <summary>
        /// Calories of large 
        /// </summary>
        public uint CaloriesLarge { get; } = 0;

        // <summary>
        /// ice in drink 
        /// </summary>
        public bool Ice { get; set; } = true;
        // <summary>
        /// lemon in drink 
        /// </summary>
        public bool Lemon { get; set; } = false;

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
                if (!Lemon) SpecialInstructions.Add("Add Lemon");

                return SpecialInstructions;
            }
        }

        // <summary>
        /// to string for drink 
        /// </summary>
        public override string ToString()
        {
            return Size + " Warrior Water";
        }

    }
}