/*
 * Author: Bhargav Marada
 * Class name: DragonbornWaffleFries.cs
 * Purpose: a class to represent the Dragonborn Waffle Fries
 */
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Sides;
using Size = BleakwindBuffet.Data.Enums.Size;
using System.ComponentModel;
namespace BleakwindBuffet.Data.Sides
{
    public class DragonBornWaffleFries: Side, IOrderItem, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Price for the DragonBorn Waffle Fries
        /// </summary>
        public override double Price
        {
            get
            {
                if (this.Size == Size.Small) return 0.42;
                if (this.Size == Size.Medium) return 0.76;
                if (this.Size == Size.Large) return 0.96;
                throw new NotImplementedException($"Unknown Size {this.Size}");
            }
        }

        /// <summary>
        /// Calories for the Dragonborn Waffle fries
        /// </summary>
        public override uint Calories
        {
            get
            {
                if (this.Size == Size.Small) return 77;
                if (this.Size == Size.Medium) return 89;
                if (this.Size == Size.Large) return 100;
                throw new NotImplementedException($"Unknown Size{this.Size}");
            }
        }



        // <summary>
        /// size of side 
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
        /// special instructions for side 
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                return new List<string>();
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
                description = "Crispy fried potato waffle fries.";
                return description;
            }
        }

        // <summary>
        /// to string for side 
        /// </summary>
        public override string ToString()
        {
            return Size + " Dragonborn Waffle Fries";
        }
    }
}
