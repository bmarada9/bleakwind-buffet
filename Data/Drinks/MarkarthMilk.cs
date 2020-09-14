/*
 * Author: Bhargav Marada
 * Class name: MarkarthMilk.cs
 * Purpose: a class to represent the MarkarthMilk
 */
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Drinks;
using Size = BleakwindBuffet.Data.Enums.Size;

namespace BleakwindBuffet.Data.Drinks
{
    public class MarkarthMilk: IOrderItem
    {
        /// <summary>
        /// Price for the MarkarthMilk
        /// </summary>
        public double Price
        {
            get
            {
                if (this.Size == Size.Small) return 1.05;
                if (this.Size == Size.Medium) return 1.11;
                if (this.Size == Size.Large) return 1.22;
                throw new NotImplementedException($"Unknown Size {this.Size}");
            }
        }

        /// <summary>
        /// Calories for the MarkarthMilk
        /// </summary>
        public uint Calories
        {
            get
            {
                if (this.Size == Size.Small) return 56;
                if (this.Size == Size.Medium) return 72;
                if (this.Size == Size.Large) return 93;
                throw new NotImplementedException($"Unknown Size{this.Size}");
            }
        }

        

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
                if (Ice) SpecialInstructions.Add("Add Ice");

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
}