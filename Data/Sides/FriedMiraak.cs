/*
 * Author: Bhargav Marada
 * Class name: FriedMiraak.cs
 * Purpose: a class to represent the Fried Miraak
 */
using System;
using System.Collections.Generic;
using System.Text;

using Size = BleakwindBuffet.Data.Enums.Size;

namespace BleakwindBuffet.Data.Sides
{
    public class FriedMiraak
    {

        /// <summary>
        /// Price for the Fried Miraak
        /// </summary>
        public double Price
        {
            get
            {
                if (this.Size == Size.Small) return 0.93;
                if (this.Size == Size.Medium) return 1.28;
                if (this.Size == Size.Large) return 1.82;
                throw new NotImplementedException($"Unknown Size {this.Size}");
            }
        }

        /// <summary>
        /// Calories for the Fried Miraak
        /// </summary>
        public uint Calories
        {
            get
            {
                if (this.Size == Size.Small) return 41;
                if (this.Size == Size.Medium) return 52;
                if (this.Size == Size.Large) return 73;
                throw new NotImplementedException($"Unknown Size{this.Size}");
            }
        }

        

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
