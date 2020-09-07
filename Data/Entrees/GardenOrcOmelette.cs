/*
 * Author: Bhargav Marada
 * Class name: GardenOrcOmelette.cs
 * Purpose: a class to represent the Garden Orc Omelette
 */
 using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    public class GardenOrcOmelette
    {
        /// <summary>
        /// price for  entree
        /// </summary>
        public double Price { get; } = 4.57;
        /// <summary>
        /// Calories for  entree
        /// </summary>
        public uint Calories { get; } = 404;
        /// <summary>
        /// Broccoli on  entree
        /// </summary>
        public bool Broccoli { get; set; } = true;
        /// <summary>
        /// Mushrooms on  entree
        /// </summary>
        public bool Mushrooms { get; set; } = true;
        /// <summary>
        /// tomato on  entree
        /// </summary>
        public bool Tomato { get; set; } = true;
        /// <summary>
        /// cheddar on  entree
        /// </summary>
        public bool Cheddar { get; set; } = true;

        /// <summary>
        /// special instructions for  entree
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> SpecialInstructions = new List<string>();
                if(!Broccoli) SpecialInstructions.Add("Hold broccoli");
                if(!Mushrooms) SpecialInstructions.Add("Hold mushrooms");
                if(!Tomato) SpecialInstructions.Add("Hold tomato");
                if(!Cheddar) SpecialInstructions.Add("Hold cheddar");

                return SpecialInstructions;
            }
        }

        /// <summary>
        /// to string for  entree
        /// </summary>
        public override string ToString()
        {
            return "Garden Orc Omelette";
        }
    }
}
