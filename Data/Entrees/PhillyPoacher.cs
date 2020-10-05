/*
 * Author: Bhargav Marada
 * Class name: PhillyPoacher.cs
 * Purpose: a class to represent the PhillyPoacher
 */
 using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Entrees;
using System.ComponentModel;
namespace BleakwindBuffet.Data.Entrees
{
    public class PhillyPoacher: Entree, IOrderItem, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// price for  entree
        /// </summary>
        public override double Price { get; } = 7.23;
        /// <summary>
        /// Calories for  entree
        /// </summary>
        public override uint Calories { get; } = 784;
        /// <summary>
        /// Sirloing on  entree
        /// </summary>
        public bool Sirloin { get; set; } = true;
        public bool Sirloin1
        {
            get { return Sirloin; }
            set
            {
                Sirloin = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Sirloin"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }
        /// <summary>
        /// Onion on  entree
        /// </summary>
        public bool Onion { get; set; } = true;
        public bool Onion1
        {
            get { return Onion; }
            set
            {
                Onion = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Onion"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }
        /// <summary>
        /// Roll on  entree
        /// </summary>
        public bool Roll { get; set; } = true;
        public bool Roll1
        {
            get { return Roll; }
            set
            {
                Roll = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Roll"));
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
                if(!Sirloin) SpecialInstructions.Add("Hold sirloin");
                if(!Onion) SpecialInstructions.Add("Hold onion");
                if(!Roll) SpecialInstructions.Add("Hold roll");

                return SpecialInstructions;
            }
        }

        /// <summary>
        /// to string for  entree
        /// </summary>
        public override string ToString()
        {
            return "Philly Poacher";
        }
    }
}
