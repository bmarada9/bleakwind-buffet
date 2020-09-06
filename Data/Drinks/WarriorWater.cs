/*
 * Author: Bhargav Marada
 * Class name: WarriorWater.cs
 * Purpose: a class to represent the Warrior Water
 */
using System;
using System.Collections.Generic;
using System.Text;

using Size = BleakwindBuffet.Data.Enums.Size;

namespace BleakwindBuffet.Data.Drinks
{
    class WarriorWater
    {
        /// <summary>
        /// Price for the Warrior Water
        /// </summary>
        public double Price
        {
            get
            {
                if (this.Size == Size.Small) return 0.00;
                if (this.Size == Size.Medium) return 0.00;
                if (this.Size == Size.Large) return 0.00;
                throw new NotImplementedException($"Unknown Size {this.Size}");
            }
        }

        /// <summary>
        /// Calories for the Warrior Water
        /// </summary>
        public uint Calories
        {
            get
            {
                if (this.Size == Size.Small) return 0;
                if (this.Size == Size.Medium) return 0;
                if (this.Size == Size.Large) return 0;
                throw new NotImplementedException($"Unknown Size{this.Size}");
            }
        }

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