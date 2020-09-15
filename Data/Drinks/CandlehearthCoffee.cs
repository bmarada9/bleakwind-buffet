﻿/*
 * Author: Bhargav Marada
 * Class name: CandleHearthCoffee.cs
 * Purpose: a class to represent the Candle Hearth Coffee
 */
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data;
using Size = BleakwindBuffet.Data.Enums.Size;
using BleakwindBuffet.Data.Drinks;

namespace BleakwindBuffet.Data.Drinks
{
    public class CandlehearthCoffe: Drink, IOrderItem
    {
        /// <summary>
        /// Price for the Candlehearth Coffee
        /// </summary>
        public override double Price
        {
            get
            {
                if (this.Size == Size.Small) return 0.75;
                if (this.Size == Size.Medium) return 1.25;
                if (this.Size == Size.Large) return 1.75;
                throw new NotImplementedException($"Unknown Size {this.Size}");
            }
        }

        /// <summary>
        /// Calories for the Candlehearth Coffee
        /// </summary>
        public override uint Calories
        {
            get
            {
                if (this.Size == Size.Small) return 7;
                if (this.Size == Size.Medium) return 10;
                if (this.Size == Size.Large) return 20;
                throw new NotImplementedException($"Unknown Size{this.Size}");
            }
        }


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
        public override Size Size { get; set; } = Size.Small;

        // <summary>
        /// special instructions for drink 
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> SpecialInstructions = new List<string>();
                if (Ice) SpecialInstructions.Add("Add ice");
                if (RoomForCream) SpecialInstructions.Add("Add cream");
                return SpecialInstructions;
            }
        }

        // <summary>
        /// to string for drink 
        /// </summary>
        public override string ToString()
        {
            if (Decaf) return Size + " Decaf Candlehearth Coffee";
            else return Size + " Candlehearth Coffee";
        }

    }
}