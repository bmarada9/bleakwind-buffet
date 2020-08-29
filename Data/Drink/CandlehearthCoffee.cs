/*
 * Author: Bhargav Marada
 * Class name: CandleHearthCoffee.cs
 * Purpose: a class to represent the Candle Hearth Coffee
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
        public double PriceSmall { get; } = 0.75;
        // <summary>
        /// price of medium 
        /// </summary>
        public double PriceMedium { get; } = 1.25;
        // <summary>
        /// price of large 
        /// </summary>
        public double PriceLarge { get; } = 1.75;

        // <summary>
        /// Calories of small 
        /// </summary>
        public uint CaloriesSmall { get; } = 7;
        // <summary>
        /// Calories of medium 
        /// </summary>
        public uint CaloriesMedium { get; } = 10;
        // <summary>
        /// Calories of large 
        /// </summary>
        public uint CaloriesLarge { get; } = 20;

        // <summary>
        /// ice in drink 
        /// </summary>
        public bool Ice { get; set; } = false;
        // <summary>
        /// cream in drink 
        /// </summary>
        public bool RoomForCream { get; set; } = false;
        // <summary>
        /// decaf drink 
        /// </summary>
        public bool Decaf { get; set; } = false;

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
                if (!RoomForCream) SpecialInstructions.Add("Add Cream");
                return SpecialInstructions;
            }
        }

        // <summary>
        /// to string for drink 
        /// </summary>
        public override string ToString()
        {
            if (!Decaf) return Size + "  Decaf Candlehearth Coffee";
            else return Size + " Candlehearth Coffee";
        }

    }
}