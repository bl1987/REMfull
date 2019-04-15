using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REM.BL
{
    public class Recipe
    {
        public string Name { get; set; }
        public List<Ingredient> Ingredients;

        public Recipe(string name)
        {
            Name = name;
            Ingredients = new List<Ingredient>();
        }
    }
}
