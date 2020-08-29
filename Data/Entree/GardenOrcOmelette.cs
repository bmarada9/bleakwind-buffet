using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Entree
{
    class GardenOrcOmelette
    {
        double Price = 4.57;
        uint Calories = 404;
        bool Broccoli = true;
        bool Mushrooms = true;
        bool Tomato = true;
        bool Cheddar = true;

        List<string> SpecialInstructions = new List<string>();
        SpecialInstructions.Add("Hold broccoli");
        SpecialInstructions.Add("Hold mushrooms");
        SpecialInstructions.Add("Hold tomato");
        SpecialInstructions.Add("Hold cheddar");

        public override string ToString()
        {
            return "Garden Orc Omelette";
        }
    }
}
