using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Sides;
using Size = BleakwindBuffet.Data.Enums.Size;

namespace BleakwindBuffet.Data.Sides
{
    public abstract class Side: IOrderItem
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
