/*
 * Author: Bhargav Marada
 * Class name: MarkarthMilk.cs
 * Purpose: a class to represent the MarkarthMilk
 */
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data;
using Size = BleakwindBuffet.Data.Enums.Size;
using BleakwindBuffet.Data.Drinks;

namespace BleakwindBuffet.Data.Drinks
{
    public class AretinoAppleJuice: Drink, IOrderItem
    {
        

        /// <summary>
        /// Price for the Arentino Apple Juice
        /// </summary>
        public override double Price
        {
            get
            {
                if (this.Size == Size.Small) return 0.62;
                if (this.Size == Size.Medium) return 0.87;
                if (this.Size == Size.Large) return 1.01;
                throw new NotImplementedException($"Unknown Size {this.Size}");
            }
        }

        /// <summary>
        /// Calories for the Arentino Apple Juice
        /// </summary>
        public override uint Calories
        {
            get
            {
                if (this.Size == Size.Small) return 44;
                if (this.Size == Size.Medium) return 88;
                if (this.Size == Size.Large) return 132;
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
        public override Size Size { get; set; } = Size.Small;

        // <summary>
        /// special instructions for drink 
        /// </summary>
        public override List<string> SpecialInstructions
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
            return Size + " Aretino Apple Juice";
        }

    }
}