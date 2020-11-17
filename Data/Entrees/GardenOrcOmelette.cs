/*
 * Author: Bhargav Marada
 * Class name: GardenOrcOmelette.cs
 * Purpose: a class to represent the Garden Orc Omelette
 */
 using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Entrees;
using System.ComponentModel;
namespace BleakwindBuffet.Data.Entrees
{
    public class GardenOrcOmelette: Entree, IOrderItem, INotifyPropertyChanged
    {
    public event PropertyChangedEventHandler PropertyChanged;

    /// <summary>
    /// price for  entree
    /// </summary>
    public override double Price { get; } = 4.57;
        /// <summary>
        /// Calories for  entree
        /// </summary>
        public override uint Calories { get; } = 404;
        /// <summary>
        /// Broccoli on  entree
        /// </summary>
        public bool Broccoli { get; set; } = true;
        public bool Broccoli1
        {
            get { return Broccoli; }
            set
            {
                Broccoli = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Broccoli"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }
        /// <summary>
        /// Mushrooms on  entree
        /// </summary>
        public bool Mushrooms { get; set; } = true;
        public bool Mushroom
        {
            get { return Mushrooms; }
            set
            {
                Mushrooms = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Mushrooms"));
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
        /// cheddar on  entree
        /// </summary>
        public bool Cheddar { get; set; } = true;
        public bool Cheddar1
        {
            get { return Cheddar; }
            set
            {
                Cheddar = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Cheddar"));
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
                if(!Broccoli) SpecialInstructions.Add("Hold broccoli");
                if(!Mushrooms) SpecialInstructions.Add("Hold mushrooms");
                if(!Tomato) SpecialInstructions.Add("Hold tomato");
                if(!Cheddar) SpecialInstructions.Add("Hold cheddar");

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
                description = "Vegetarian. Two egg omelette packed with a mix of broccoli, mushrooms, and tomatoes. Topped with cheddar cheese.";
                return description;
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
