using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Entree
{
    class ThugsTBone
    {
        double Price = 6.44;
        uint Calories = 982;

        List<string> SpecialInstructions = new List<string>();
        public override string ToString()
        {
            return "Thugs T-Bone";
        }
    }
}
