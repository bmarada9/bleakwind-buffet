/*
 * Author: Bhargav Marada
 * Class name: MarkarthMilk.cs
 * Purpose: a class to represent the MarkarthMilk
 */
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data;
using Size = BleakwindBuffet.Data.Enums.Size;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Enums;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Drinks
{
    public class FalmerFloat : Drink, IOrderItem, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public override double Price
        {
            get
            {
                if (this.Size == Size.Small) return 3.00;
                if (this.Size == Size.Medium) return 3.50;
                if (this.Size == Size.Large) return 4.00;
                throw new NotImplementedException($"Unknown Size {this.Size}");
            }
        }

        /// <summary>
        /// Calories for the Arentino Apple Juice
        /// </summary>
        public override uint Calories
        {
            get
            {
                if (this.Size == Size.Small) return 380;
                if (this.Size == Size.Medium) return 478;
                if (this.Size == Size.Large) return 565;
                throw new NotImplementedException($"Unknown Size{this.Size}");
            }
        }


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

        public Size size = Size.Small;
        // <summary>
        /// size of drink 
        /// </summary>
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
                description = "An old-fashioned jerked float, flavored syrup poured over a bed of crushed ice.";
                return description;
            }
        }

        // <summary>
        /// to string for drink 
        /// </summary>
        public override string ToString()
        {
            return Size + " " + Flavor + " Sailor Soda";
        }

    }
}