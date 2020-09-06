/*
 * Author: Bhargav Marada
 * Class name: MadOtarGrits.cs
 * Purpose: a class to represent the Mad Otar Grits
 */
using System;
using System.Collections.Generic;
using System.Text;

using Size = BleakwindBuffet.Data.Enums.Size;

namespace BleakwindBuffet.Data.Sides
{
    public class MadOtarGrits
    {
        /// <summary>
        /// Price for the Mad Otar Grits
        /// </summary>
        public double Price
        {
            get
            {
                if (this.Size == Size.Small) return 1.22;
                if (this.Size == Size.Medium) return 1.58;
                if (this.Size == Size.Large) return 1.93;
                throw new NotImplementedException($"Unknown Size {this.Size}");
            }
        }

        /// <summary>
        /// Calories for the Mad Otar Grits
        /// </summary>
        public uint Calories
        {
            get
            {
                if (this.Size == Size.Small) return 105;
                if (this.Size == Size.Medium) return 142;
                if (this.Size == Size.Large) return 179;
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
            return Size + " Mad Otar Grits";
        }
    }
}
