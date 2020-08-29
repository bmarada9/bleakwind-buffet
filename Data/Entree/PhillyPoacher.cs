using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Entree
{
    class PhillyPoacher
    {
        double Price = 7.23;
        uint Calories = 784;
        bool Sirloin = true;
        bool Onion = true;
        bool Roll = true;

        List<string> SpecialInstructions = new List<string>();
        SpecialInstructions.Add("Hold sirloin");
        SpecialInstructions.Add("Hold onions");
        SpecialInstructions.Add("Hold roll");

        public override string ToString()
        {
            return "Philly Poacher";
        }
    }
}
