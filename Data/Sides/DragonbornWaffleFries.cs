/*
 * Author: Bhargav Marada
 * Class name: DragonbornWaffleFries.cs
 * Purpose: a class to represent the Dragonborn Waffle Fries
 */
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Sides;
using Size = BleakwindBuffet.Data.Enums.Size;

namespace BleakwindBuffet.Data.Sides
{
    public class DragonBornWaffleFries: IOrderItem
    {
        /// <summary>
        /// Price for the DragonBorn Waffle Fries
        /// </summary>
        public double Price
        {
            get
            {
                if (this.Size == Size.Small) return 0.42;
                if (this.Size == Size.Medium) return 0.76;
                if (this.Size == Size.Large) return 0.96;
                throw new NotImplementedException($"Unknown Size {this.Size}");
            }
        }

        /// <summary>
        /// Calories for the Dragonborn Waffle fries
        /// </summary>
        public uint Calories
        {
            get
            {
                if (this.Size == Size.Small) return 77;
                if (this.Size == Size.Medium) return 89;
                if (this.Size == Size.Large) return 100;
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
            return Size + " Dragonborn Waffle Fries";
        }
    }
}
