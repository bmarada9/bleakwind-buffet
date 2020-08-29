using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Entree
{
    class BriarheartBurger
    {
        double Price = 6.32;
        uint Calories = 743;
        bool Bun = true;
        bool Ketchup = true;
        bool Mustard = true;
        bool Pickle = true;
        bool Cheese = true;
        
        List<string> SpecialInstructions = new List<string>();
        SpecialInstructions.Add("Hold bun");
        SpecialInstructions.Add("Hold ketchup");
        SpecialInstructions.Add("Hold mustard");
        SpecialInstructions.Add("Hold pickle");
        SpecialInstructions.Add("Hold cheese");

        public override string ToString()
        {
            return "Briarheart Burger";
        }
    }
}
