using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Entree
{
    class ThalmorTriple
    {
        double Price = 8.32;
        uint Calories = 943;
        bool Bun = true;
        bool Ketchup = true;
        bool Mustard = true;
        bool Pickle = true;
        bool Cheese = true;
        bool Bacon = true;
        bool Egg = true;

        List<string> SpecialInstructions = new List<string>();
        SpecialInstructions.Add("Hold bacon");
        SpecialInstructions.Add("Hold egg");

        public override string ToString()
        {
            return "Thalmor Triple";
        }
    }
}
