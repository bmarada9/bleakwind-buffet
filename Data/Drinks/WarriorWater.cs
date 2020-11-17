/*
 * Author: Bhargav Marada
 * Class name: WarriorWater.cs
 * Purpose: a class to represent the Warrior Water
 */
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Drinks;
using System.ComponentModel;
using Size = BleakwindBuffet.Data.Enums.Size;

namespace BleakwindBuffet.Data.Drinks
{
    public class WarriorWater: Drink, IOrderItem, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Price for the Warrior Water
        /// </summary>
        public override double Price
        {
            get
            {
                if (this.Size == Size.Small) return 0.00;
                if (this.Size == Size.Medium) return 0.00;
                if (this.Size == Size.Large) return 0.00;
                throw new NotImplementedException($"Unknown Size {this.Size}");
            }
        }

        /// <summary>
        /// Calories for the Warrior Water
        /// </summary>
        public override uint Calories
        {
            get
            {
                if (this.Size == Size.Small) return 0;
                if (this.Size == Size.Medium) return 0;
                if (this.Size == Size.Large) return 0;
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
        /// lemon in drink 
        /// </summary>
        public bool Lemon { get; set; } = false;
        public bool lemon
        {
            get { return Lemon; }
            set
            {
                Lemon = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Lemon"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Special Instructions"));
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
                if (Ice) SpecialInstructions.Add("Hold Ice");
                if (Lemon) SpecialInstructions.Add("Add Lemon");

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
                description = "It’s water. Just water.";
                return description;
            }
        }

        // <summary>
        /// to string for drink 
        /// </summary>
        public override string ToString()
        {
            return Size + " Warrior Water";
        }

    }
}