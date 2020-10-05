/*
 * Author: Bhargav Marada
 * Class name: MadOtarGrits.cs
 * Purpose: a class to represent the Mad Otar Grits
 */
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Sides;
using Size = BleakwindBuffet.Data.Enums.Size;
using System.ComponentModel;
namespace BleakwindBuffet.Data.Sides
{
    public class MadOtarGrits: Side, IOrderItem, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Price for the Mad Otar Grits
        /// </summary>
        public override double Price
        {
            get
            {
                if (this.Size == Size.Small) return 1.22;
                if (this.Size == Size.Medium) return 1.58;
                if (this.Size == Size.Large) return 1.93;
                throw new NotImplementedException($"Unknown Size {this.Size}");
            }
        }

        /// <summary>
        /// Calories for the Mad Otar Grits
        /// </summary>
        public override uint Calories
        {
            get
            {
                if (this.Size == Size.Small) return 105;
                if (this.Size == Size.Medium) return 142;
                if (this.Size == Size.Large) return 179;
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
            return Size + " Mad Otar Grits";
        }
    }
}
