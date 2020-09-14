/*
 * Author: Bhargav Marada
 * Class name: PhillyPoacher.cs
 * Purpose: a class to represent the PhillyPoacher
 */
 using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Entrees;

namespace BleakwindBuffet.Data.Entrees
{
    public class PhillyPoacher: IOrderItem
    {
        /// <summary>
        /// price for  entree
        /// </summary>
        public double Price { get; } = 7.23;
        /// <summary>
        /// Calories for  entree
        /// </summary>
        public uint Calories { get; } = 784;
        /// <summary>
        /// Sirloing on  entree
        /// </summary>
        public bool Sirloin { get; set; } = true;
        /// <summary>
        /// Onion on  entree
        /// </summary>
        public bool Onion { get; set; } = true;
        /// <summary>
        /// Roll on  entree
        /// </summary>
        public bool Roll { get; set; } = true;

        /// <summary>
        /// special instructions for  entree
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> SpecialInstructions = new List<string>();
                if(!Sirloin) SpecialInstructions.Add("Hold sirloin");
                if(!Onion) SpecialInstructions.Add("Hold onion");
                if(!Roll) SpecialInstructions.Add("Hold roll");

                return SpecialInstructions;
            }
        }

        /// <summary>
        /// to string for  entree
        /// </summary>
        public override string ToString()
        {
            return "Philly Poacher";
        }
    }
}
