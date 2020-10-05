/*
 * Author: Bhargav Marada
 * Class name: VokunSalad.cs
 * Purpose: a class to represent the Vokun Salad
 */
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Sides;
using Size = BleakwindBuffet.Data.Enums.Size;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Sides
{
    public class VokunSalad: Side, IOrderItem, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// Price for the Vokun Salad
        /// </summary>
        public override double Price
        {
            get
            {
                if (this.Size == Size.Small) return 0.93;
                if (this.Size == Size.Medium) return 1.28;
                if (this.Size == Size.Large) return 1.82;
                throw new NotImplementedException($"Unknown Size {this.Size}");
            }
        }
        /// <summary>
        /// Calories for the Vokun Salad
        /// </summary>
        public override uint Calories
        {
            get
            {
                if (this.Size == Size.Small) return 41;
                if (this.Size == Size.Medium) return 52;
                if (this.Size == Size.Large) return 73;
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

        // <summary>
        /// to string for side 
        /// </summary>
        public override string ToString()
        {
            return Size + " Vokun Salad";
        }
    }
}
