using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Entree
{
    class SmokehouseSkeleton
    {
        double Price = 5.32;
        uint Calories = 602;
        bool SausageLink = true;
        bool Egg = true;
        bool HashBrowns = true;
        bool Pancake = true;

        List<string> SpecialInstructions = new List<string>();
        SpecialInstructions.Add("Hold sausage");
        SpecialInstructions.Add("Hold egss");
        SpecialInstructions.Add("Hold hash browns");
        SpecialInstructions.Add("Hold pancakes");

        public override string ToString()
        {
            return "Smokehouse Skeleton";
        }
    }
}
