/*
 * Author: Bhargav Marada
 * Class name: BriarheartBurger.cs
 * Purpose: a class to represent the Briarheart Burger
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Entree
{
    public class BriarheartBurger
    {
        /// <summary>
        /// price for  entree
        /// </summary>
        public double Price { get; } = 6.32;

        /// <summary>
        /// calories for  entree
        /// </summary>
        public uint Calories { get; } = 743;

        /// <summary>
        /// Bun on  entree
        /// </summary>
        public bool Bun { get; set; } = true;
        /// <summary>
        /// ketchup on  entree
        /// </summary>
        public bool Ketchup { get; set; } = true;
        /// <summary>
        /// mustard on  entree
        /// </summary>
        public bool Mustard { get; set; } = true;
        /// <summary>
        /// pickle on  entree
        /// </summary>
        public bool Pickle { get; set; } = true;
        /// <summary>
        /// cheese on  entree
        /// </summary>
        public bool Cheese { get; set; } = true;

        /// <summary>
        /// special instructions for  entree
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> SpecialInstructions = new List<string>();
                if (Bun == false)
                {
                    SpecialInstructions.Add("Hold bun");
                }
                if (Ketchup == false)
                {
                    SpecialInstructions.Add("Hold ketchup");
                }
                if(!Mustard)SpecialInstructions.Add("Hold mustard");
                if(!Pickle)SpecialInstructions.Add("Hold pickle");
                if(!Cheese)SpecialInstructions.Add("Hold cheese");

                return SpecialInstructions;
            }
        }

        /// <summary>
        /// to string for  entree
        /// </summary>
        public override string ToString()
        {
            return "Briarheart Burger";
        }
    }
}
