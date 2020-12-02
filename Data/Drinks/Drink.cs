/*
 * Author: Bhargav Marada
 * Class name: Entree.cs
 * Purpose: an abstract drinks class
 */
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data;
using Size = BleakwindBuffet.Data.Enums.Size;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Drinks
{
    public abstract class Drink
    {
        public event PropertyChangedEventHandler PropertyChanged;

        
        private Size size = Size.Small;
        /// <summary>
        /// The size of the drink
        /// </summary>
        public virtual Size Size
        {
            get
            {
                return size;

            }
            set
            {
                size = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Small"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Medium"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Large"));

            }
        }
        /// <summary>
        /// a price getter
        /// </summary>
        public abstract double Price { get; }

        /// <summary>
        /// a calories getter
        /// </summary>
        public abstract uint Calories { get; }

        public string Description
        {
            get
            {
                return "It's a drink";
            }
        }

        /// <summary>
        /// a special instructions getter
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }


    }
}
