using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data;
using Size = BleakwindBuffet.Data.Enums.Size;


namespace BleakwindBuffet.Data.Drinks
{
    public abstract class Drink: IOrderItem
    {
        public abstract Size Size
        {
            get;
            set;
        }
        public abstract double Price { get; }

        public abstract uint Calories { get; }

        public abstract List<string> SpecialInstructions { get; }
    }
}
