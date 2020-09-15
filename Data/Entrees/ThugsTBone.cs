/*
 * Author: Bhargav Marada
 * Class name: SmokehouseSkeleton.cs
 * Purpose: a class to represent the Smokehouse Skelton
 */
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Entrees;

namespace BleakwindBuffet.Data.Entrees
{
    public class ThugsTBone: Entree, IOrderItem
    {
        /// <summary>
        /// price for  entree
        /// </summary>
        public override double Price { get; } = 6.44;
        /// <summary>
        /// Calories for  entree
        /// </summary>
        public override uint Calories { get; } = 982;

        /// <summary>
        /// special instructions for  entree
        /// </summary>
        public override List<String> SpecialInstructions
        {
            get
            {
                return new List<string>();
                //SpecialInstructions.Add("No Special Instructions");
                //return SpecialInstructions;
            }
        }

        /// <summary>
        /// to string for  entree
        /// </summary>
        public override string ToString()
        {
            return "Thugs T-Bone";
        }
    }
}
