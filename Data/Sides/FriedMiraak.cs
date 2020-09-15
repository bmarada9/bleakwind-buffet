/*
 * Author: Bhargav Marada
 * Class name: FriedMiraak.cs
 * Purpose: a class to represent the Fried Miraak
 */
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Sides;
using Size = BleakwindBuffet.Data.Enums.Size;

namespace BleakwindBuffet.Data.Sides
{
    public class FriedMiraak: Side, IOrderItem
    {

        /// <summary>
        /// Price for the Fried Miraak
        /// </summary>
        public override double Price
        {
            get
            {
                if (this.Size == Size.Small) return 1.78;
                if (this.Size == Size.Medium) return 2.01;
                if (this.Size == Size.Large) return 2.88;
                throw new NotImplementedException($"Unknown Size {this.Size}");
            }
        }

        /// <summary>
        /// Calories for the Fried Miraak
        /// </summary>
        public override uint Calories
        {
            get
            {
                if (this.Size == Size.Small) return 151;
                if (this.Size == Size.Medium) return 236;
                if (this.Size == Size.Large) return 306;
                throw new NotImplementedException($"Unknown Size{this.Size}");
            }
        }

        

        // <summary>
        /// size of side 
        /// </summary>
        public override Size Size { get; set; } = Size.Small;

        // <summary>
        /// special instructions for side 
        /// </summary>
        public override List<string> SpecialInstructions
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
            return Size + " Fried Miraak";
        }
    }
}
