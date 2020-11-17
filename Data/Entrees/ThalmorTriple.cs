/*
 * Author: Bhargav Marada
 * Class name: ThalmorTriple.cs
 * Purpose: a class to represent the ThalmorTriple
 */
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Entrees;
using System.ComponentModel;
namespace BleakwindBuffet.Data.Entrees
{
    public class ThalmorTriple: Entree, IOrderItem, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// price for  entree
        /// </summary>
        public override double Price { get; } = 8.32;
        /// <summary>
        /// calories for  entree
        /// </summary>
        public override uint Calories { get; } = 943;
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
        /// Ketchup on  entree
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
        /// Mustard on  entree
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
        /// Pickle on  entree
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
        /// tomato on  entree
        /// </summary>
        public bool Tomato { get; set; } = true;
        public bool Tomato1
        {
            get { return Tomato; }
            set
            {
                Tomato = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Tomato"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }
        /// <summary>
        /// lettuce on  entree
        /// </summary>
        public bool Lettuce { get; set; } = true;
        public bool Lettuce1
        {
            get { return Lettuce; }
            set
            {
                Lettuce = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Lettuce"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }
        /// <summary>
        /// mayo on  entree
        /// </summary>
        public bool Mayo { get; set; } = true;
        public bool Mayo1
        {
            get { return Mayo; }
            set
            {
                Mayo = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Mayo"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }
        /// <summary>
        /// bacon on  entree
        /// </summary>
        public bool Bacon { get; set; } = true;
        public bool Bacon1
        {
            get { return Bacon; }
            set
            {
                Bacon = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Bacon"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }
        /// <summary>
        /// egg on  entree
        /// </summary>
        public bool Egg { get; set; } = true;
        public bool Egg1
        {
            get { return Egg; }
            set
            {
                Egg = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Egg"));
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
        /// returns the description of the item
        /// </summary>
        private string description;
        public string Description
        {
            get
            {
                description = "Think you are strong enough to take on the Thalmor? Inlcudes two 1/4lb patties with a 1/2lb patty inbetween with ketchup, mustard, pickle, cheese, tomato, lettuce, mayo, bacon, and an egg.";
                return description;
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
