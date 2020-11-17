/*
 * Author: Bhargav Marada
 * Class name: SailorsSoda.cs
 * Purpose: a class to represent the Sailors Soda
 */
using System;
using System.Collections.Generic;
using System.Text;
using SodaFlavor = BleakwindBuffet.Data.Enums.SodaFlavor;
using Size = BleakwindBuffet.Data.Enums.Size;
using BleakwindBuffet.Data.Drinks;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Drinks
{
    public class SailorsSoda: Drink, IOrderItem, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Price for Sailor Soda
        /// </summary>
        public override double Price
        {
            get
            {
                if (this.Size == Size.Small) return 1.42;
                if (this.Size == Size.Medium) return 1.74;
                if (this.Size == Size.Large) return 2.07;
                throw new NotImplementedException($"Unknown Size {this.Size}");
            }
        }

        /// <summary>
        /// Calories for the Sailors Soda
        /// </summary>
        public override uint Calories
        {
            get
            {
                if (this.Size == Size.Small) return 117;
                if (this.Size == Size.Medium) return 153;
                if (this.Size == Size.Large) return 205;
                throw new NotImplementedException($"Unknown Size{this.Size}");
            }
        }

        
        // <summary>
        /// ice in drink 
        /// </summary>
        public bool Ice { get; set; } = true;
        public bool ice
        {
            get { return Ice; }
            set
            {
                Ice = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Ice"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Special Instructions"));
            }
        }

        // <summary>
        /// drink flavor 
        /// </summary>
        public SodaFlavor Flavor { get; set; } = SodaFlavor.Cherry;
        public SodaFlavor SodaFlavor
        {
            get { return Flavor; }
            set
            {
                Flavor = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Flavor"));
            }
        }
        // <summary>
        /// size of drink 
        /// </summary>
        public Size size { get; set; } = Size.Small;
        public override Size Size
        {
            get { return size; }
            set
            {
                size = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Size"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
            }
        }
        // <summary>
        /// special instructions for drink 
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> SpecialInstructions = new List<string>();
                if (!Ice) SpecialInstructions.Add("Hold Ice");

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
                description = "An old-fashioned jerked soda, carbonated water and flavored syrup poured over a bed of crushed ice.";
                return description;
            }
        }

        // <summary>
        /// to string for drink 
        /// </summary>
        public override string ToString()
        {
            return Size + " " + Flavor +" Sailor Soda";
        }

    }
}
