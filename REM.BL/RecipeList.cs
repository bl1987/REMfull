using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REM.BL
{
    public class RecipeList
    {
        public List<Recipe> Recipes { get; set; }

        public RecipeList()
        {
            Recipes = new List<Recipe>();
        }
    }
}
