using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REM.BL
{
    public class RecipeController
    {
        static public bool AddRecipe(Recipe recipe, RecipeList recipes)
        {
            var match = recipes.Recipes.Where(r => r.Name == recipe.Name).Count();
            if (match > 0)
            {
                return false;
            }
            else
            {
                recipes.Recipes.Add(recipe);
                return true;
            }
        }
        static public bool DeleteRecipe(string name, RecipeList recipes)
        {
            var index = recipes.Recipes.IndexOf(recipes.Recipes.Where(r => r.Name == name).FirstOrDefault());
            if (index <= 0)
            {
                recipes.Recipes.RemoveAt(index);
                return true;
            }
            else
            {
                return false;
            }
        }
        static public bool EditRecipe(string name, Recipe recipe, RecipeList recipes)
        {
            var index = recipes.Recipes.IndexOf(recipes.Recipes.Where(r => r.Name == name).FirstOrDefault());
            if (index <= 0)
            {
                recipes.Recipes[index] = recipe;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
