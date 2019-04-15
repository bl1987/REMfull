using System;
using System.Text;
using System.Collections.Generic;
using REM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace REM.BLTest
{
    /// <summary>
    /// RecipeControllerTest의 요약 설명
    /// </summary>
    [TestClass]
    public class RecipeControllerTest
    {
        [TestMethod]
        public void AddingNewRecipe()
        {
            RecipeList recipeList = new RecipeList();
            Recipe beefNoodle = new Recipe("Beef Noodle");
            beefNoodle.Ingredients.Add(new Ingredient("beef", 10));
            beefNoodle.Ingredients.Add(new Ingredient("noodle", 30));
            RecipeController.AddRecipe(beefNoodle, recipeList);
            var expected = "Beef Noodle";
            var actual = recipeList.Recipes[0].Name;
            Assert.AreEqual(expected, actual);
        }
    }
}
