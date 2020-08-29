/*
 * Author: Bhargav Marada
 * Class name: ThalmorTriple.cs
 * Purpose: a class to represent the ThalmorTriple
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Entree
{
    public class ThalmorTriple
    {
        /// <summary>
        /// price for  entree
        /// </summary>
        public double Price { get; } = 8.32;
        /// <summary>
        /// calories for  entree
        /// </summary>
        public uint Calories { get; } = 943;
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
        public bool Tomato { get; set; } = true;
        /// <summary>
        /// lettuce on  entree
        /// </summary>
        public bool Lettuce { get; set; } = true;
        /// <summary>
        /// mayo on  entree
        /// </summary>
        public bool Mayo { get; set; } = true;
        /// <summary>
        /// bacon on  entree
        /// </summary>
        public bool Bacon { get; set; } = true;
        /// <summary>
        /// egg on  entree
        /// </summary>
        public bool Egg { get; set; } = true;

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
                if (!Bacon) SpecialInstructions.Add("Hold bacon");
                if (!Egg) SpecialInstructions.Add("Hold egg");

                return SpecialInstructions;
            }
        }

        /// <summary>
        /// to string for  entree
        /// </summary>
        public override string ToString()
        {
            return "Thalmor Triple";
        }
    }
}
