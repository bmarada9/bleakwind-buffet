/*
 * Author: Bhargav Marada
 * Class name: BriarheartBurger.cs
 * Purpose: a class to represent the Briarheart Burger
 */

using BleakwindBuffet.Data.Entrees;
using System;
using System.Collections.Generic;
using System.Text;


namespace BleakwindBuffet.Data.Entrees
{
    public class BriarheartBurger: Entree
    {
        /// <summary>
        /// price for  entree
        /// </summary>
        public override double Price { get; } = 6.32; 

        /// <summary>
        /// calories for  entree
        /// </summary>
        public override uint Calories { get; } = 743;

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
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> SpecialInstructions = new List<string>();
                if (Bun) SpecialInstructions.Add("Hold bun");
                if (Ketchup) SpecialInstructions.Add("Hold ketchup");
                if (Mustard)SpecialInstructions.Add("Hold mustard");
                if (Pickle)SpecialInstructions.Add("Hold pickle");
                if (Cheese)SpecialInstructions.Add("Hold cheese");

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
