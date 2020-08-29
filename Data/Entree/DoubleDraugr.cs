using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Entree
{
    class DoubleDraugr
    {
        double Price = 7.32;
        uint Calories = 843;
        bool Bun = true;
        bool Ketchup = true;
        bool Mustard = true;
        bool Pickle = true;
        bool Cheese = true;
        bool Tamato = true;
        bool Lettuce = true;
        bool Mayo = true;

        List<string> SpecialInstructions = new List<string>();
        SpecialInstructions.Add("Hold tomato");
        SpecialInstructions.Add("Hold lettuce");
        SpecialInstructions.Add("Hold mayo");

        public override string ToString()
        {
            return "Double Draugr";
        }
    }
}
