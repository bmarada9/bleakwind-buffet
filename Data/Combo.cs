using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;

namespace BleakwindBuffet.Data
{
    public class Combo: INotifyPropertyChanged, IOrderItem
    {
        /// <summary>
        /// Event handler for property change
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// price, calories, special instructions
        /// 
        /// <summary>
        /// notifies when a property has changed
        /// </summary>
        private Drink drink;
        public Drink Drink
        {
            get { return drink; }
            set
            {
                drink = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Size"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        /// <summary>
        /// notifies when a property has changed
        /// </summary>
        public Entree entree;
        public Entree Entree
        {
            get { return entree; }
            set
            {
                entree = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        /// <summary>
        /// notifies when a property has changed
        /// </summary>
        public Side side;
        public Side Side
        {
            get { return side; }
            set
            {
                side = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Size"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        /// <summary>
        /// total price 
        /// </summary>
        public double Price
        {
            get { return Entree.Price + Side.Price + Drink.Price; }
        }

        /// <summary>
        /// total calories
        /// </summary>
        public uint Calories 
        {
            get { return Entree.Calories + Side.Calories + Drink.Calories; } 
        }

        /// <summary>
        /// displays the name of each part in the combo, and then its special instructions
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> si = new List<string>();
                si.Add(Entree.ToString());
                si.AddRange(Entree.SpecialInstructions);
                si.Add(Side.ToString());
                si.AddRange(Side.SpecialInstructions);
                si.Add(Drink.ToString());
                si.AddRange(Drink.SpecialInstructions);
                return si;
            }
        }
    }
}
