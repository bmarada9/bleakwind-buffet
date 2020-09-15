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
    public class SmokehouseSkeleton: Entree, IOrderItem
    {
        /// <summary>
        /// price for  entree
        /// </summary>
        public override double Price { get; } = 5.32;
        /// <summary>
        /// calories for  entree
        /// </summary>
        public override uint Calories { get; } = 602;
        /// <summary>
        /// sausage link on  entree
        /// </summary>
        public bool SausageLink { get; set; } = true;
        /// <summary>
        /// egg on  entree
        /// </summary>
        public bool Egg { get; set; } = true;
        /// <summary>
        /// hashbrowns on  entree
        /// </summary>
        public bool HashBrowns { get; set; } = true;
        /// <summary>
        /// pancakes on  entree
        /// </summary>
        public bool Pancake { get; set; } = true;

        /// <summary>
        /// special instructions for  entree
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> SpecialInstructions = new List<string>();
                if(! SausageLink) SpecialInstructions.Add("Hold sausage");
                if(!Egg) SpecialInstructions.Add("Hold egg");
                if(!HashBrowns) SpecialInstructions.Add("Hold hash browns");
                if(!Pancake) SpecialInstructions.Add("Hold pancakes");

                return SpecialInstructions;
            }
        }

        /// <summary>
        /// to string for  entree
        /// </summary>
        public override string ToString()
        {
            return "Smokehouse Skeleton";
        }
    }
}
