/*
 * Author: Bhargav Marada
 * Class name: BriarheartBurger.cs
 * Purpose: a class to represent the Briarheart Burger
 */

using BleakwindBuffet.Data.Entrees;
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;


namespace BleakwindBuffet.Data.Entrees
{
    public class BriarheartBurger: Entree, IOrderItem, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
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
        public bool Bun1
        {
            get { return Bun; }
            set
            {
                Bun = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Bun"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }
        /// <summary>
        /// ketchup on  entree
        /// </summary>
        public bool Ketchup { get; set; } = true;
        public bool Ketchup1
        {
            get { return Ketchup; }
            set
            {
                Ketchup = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Ketchup"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }
        /// <summary>
        /// mustard on  entree
        /// </summary>
        public bool Mustard { get; set; } = true;
        public bool Mustard1
        {
            get { return Mustard; }
            set
            {
                Mustard = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Mustard"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }
        /// <summary>
        /// pickle on  entree
        /// </summary>
        public bool Pickle { get; set; } = true;
        public bool Pickle1
        {
            get { return Pickle; }
            set
            {
                Pickle = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Pickle"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }
        /// <summary>
        /// cheese on  entree
        /// </summary>
        public bool Cheese { get; set; } = true;
        public bool Cheese1
        {
            get { return Cheese; }
            set
            {
                Cheese = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Cheese"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

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
        /// returns the description of the item
        /// </summary>
        private string description;
        public string Description
        {
            get
            {
                description = "Single patty burger on a brioche bun. Comes with ketchup, mustard, pickle, and cheese.";
                return description;
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
