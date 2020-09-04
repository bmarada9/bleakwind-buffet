/*
 * Author: Bhargav Marada
 * Class name: DoubleDraugr.cs
 * Purpose: a class to represent the Double Draugr
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace Bleakwindbuffet.Data.Entrees
{
    public class DoubleDraugr
    {
        /// <summary>
        /// price for  entree
        /// </summary>
        public double Price { get; } = 7.32;
        /// <summary>
        /// calories for  entree
        /// </summary>
        public uint Calories { get; } = 843;
        /// <summary>
        /// Bun on  entree
        /// </summary>
        public bool Bun { get; set; } = true;
        /// <summary>
        /// Ketchup on  entree
        /// </summary>
        public bool Ketchup { get; set; } = true;
        /// <summary>
        /// Mustard on  entree
        /// </summary>
        public bool Mustard { get; set; } = true;
        /// <summary>
        /// Pickle on  entree
        /// </summary>
        public bool Pickle { get; set; } = true;
        /// <summary>
        /// cheese on  entree
        /// </summary>
        public bool Cheese { get; set; } = true;
        /// <summary>
        /// tomato on  entree
        /// </summary>
        public bool Tomato { get; set; }  = true;
        /// <summary>
        /// lettuce on  entree
        /// </summary>
        public bool Lettuce { get; set; } = true;
        /// <summary>
        /// mayo on  entree
        /// </summary>
        public bool Mayo { get; set; } = true;

        /// <summary>
        /// special instructions for  entree
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> SpecialInstructions = new List<string>();
                if (!Bun) SpecialInstructions.Add("Hold bun");
                if (!Ketchup) SpecialInstructions.Add("Hold ketchup");
                if (!Mustard) SpecialInstructions.Add("Hold mustard");
                if (!Pickle) SpecialInstructions.Add("Hold pickle");
                if (!Cheese) SpecialInstructions.Add("Hold cheese");
                if (!Tomato) SpecialInstructions.Add("Hold tomato");
                if (!Lettuce) SpecialInstructions.Add("Hold lettuce");
                if (!Mayo) SpecialInstructions.Add("Hold mayo");

                return SpecialInstructions;
            }
        }

        /// <summary>
        /// to string for  entree
        /// </summary>
        public override string ToString()
        {
            return "Double Draugr";
        }
    }
}
