using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REM.BL
{
    public class Ingredient:Item
    {
        public float Weight { get; set; }
        public Ingredient(string name, float weight)
        {
            Name = name;
            Weight = weight;
            Type = "Ingredient";
        }
        public Ingredient(string name, float weight, decimal cost)
        {
            Name = name;
            Weight = weight;
            Type = "Ingredient";
            if (weight <= 0)
            {
                Value = 0;
            }
            else
            {
                Value = cost / (decimal)weight;
            }
        }
    }
}
