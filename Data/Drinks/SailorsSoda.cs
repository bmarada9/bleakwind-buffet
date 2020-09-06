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

namespace BleakwindBuffet.Data.Drinks
{
    class SailorsSoda
    {
        
        /// <summary>
        /// Price for Sailor Soda
        /// </summary>
        public double Price
        {
            get
            {
                if (this.Size == Size.Small) return 1.42;
                if (this.Size == Size.Medium) return 1.74;
                if (this.Size == Size.Large) return 2.07;
                throw new NotImplementedException($"Unknown Size {this.Size}");
            }
        }

        /// <summary>
        /// Calories for the Sailors Soda
        /// </summary>
        public uint Calories
        {
            get
            {
                if (this.Size == Size.Small) return 117;
                if (this.Size == Size.Medium) return 153;
                if (this.Size == Size.Large) return 205;
                throw new NotImplementedException($"Unknown Size{this.Size}");
            }
        }

        
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
