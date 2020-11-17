/*
 * Author: Bhargav Marada
 * Class name: SmokehouseSkeleton.cs
 * Purpose: a class to represent the Smokehouse Skelton
 */
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Entrees;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Entrees
{
    public class SmokehouseSkeleton: Entree, IOrderItem, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// price for  entree
        /// </summary>
        public override double Price { get; } = 5.32;
        /// <summary>
        /// calories for  entree
        /// </summary>
        public override uint Calories { get; } = 602;
        /// <summary>
        /// sausage link on  entree
        /// </summary>
        public bool SausageLink { get; set; } = true;
        public bool SausageLink1
        {
            get { return SausageLink; }
            set
            {
                SausageLink = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Sausage Link"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }
        /// <summary>
        /// egg on  entree
        /// </summary>
        public bool Egg { get; set; } = true;
        public bool Egg1
        {
            get { return Egg; }
            set
            {
                Egg = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Egg"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }
        /// <summary>
        /// hashbrowns on  entree
        /// </summary>
        public bool HashBrowns { get; set; } = true;
        public bool HashBrowns1
        {
            get { return HashBrowns; }
            set
            {
                HashBrowns = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("HashBrowns"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }
        /// <summary>
        /// pancakes on  entree
        /// </summary>
        public bool Pancake { get; set; } = true;
        public bool Pancake1
        {
            get { return Pancake; }
            set
            {
                Pancake = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Pancake"));
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
                if(! SausageLink) SpecialInstructions.Add("Hold sausage");
                if(!Egg) SpecialInstructions.Add("Hold egg");
                if(!HashBrowns) SpecialInstructions.Add("Hold hash browns");
                if(!Pancake) SpecialInstructions.Add("Hold pancakes");

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
                description = "Put some meat on those bones with a small stack of pancakes. Includes sausage links, eggs, and hash browns on the side. Topped with the syrup of your choice.";
                return description;
            }
        }

        /// <summary>
        /// to string for  entree
        /// </summary>
        public override string ToString()
        {
            return "Smokehouse Skeleton";
        }
    }
}
