/*
 * Author: Bhargav Marada
 * Class name: MarkarthMilk.cs
 * Purpose: a class to represent the MarkarthMilk
 */
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Drinks;
using Size = BleakwindBuffet.Data.Enums.Size;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Drinks
{
    public class MarkarthMilk: Drink, IOrderItem, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Price for the MarkarthMilk
        /// </summary>
        public override double Price
        {
            get
            {
                if (this.Size == Size.Small) return 1.05;
                if (this.Size == Size.Medium) return 1.11;
                if (this.Size == Size.Large) return 1.22;
                throw new NotImplementedException($"Unknown Size {this.Size}");
            }
        }

        /// <summary>
        /// Calories for the MarkarthMilk
        /// </summary>
        public override uint Calories
        {
            get
            {
                if (this.Size == Size.Small) return 56;
                if (this.Size == Size.Medium) return 72;
                if (this.Size == Size.Large) return 93;
                throw new NotImplementedException($"Unknown Size{this.Size}");
            }
        }

        

        // <summary>
        /// ice in drink 
        /// </summary>
        public bool Ice { get; set; } = false;
        public bool ice
        {
            get { return Ice; }
            set
            {
                Ice = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Ice"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
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
                if (Ice) SpecialInstructions.Add("Add Ice");

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
                description = "Hormone-free organic 2% milk.";
                return description;
            }
        }

        // <summary>
        /// to string for drink 
        /// </summary>
        public override string ToString()
        {
            return Size + " Markarth Milk";
        }

    }
}