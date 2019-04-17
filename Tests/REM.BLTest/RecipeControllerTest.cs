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
        RecipeList recipeList;
        Recipe beefNoodle;

        public RecipeControllerTest()
        {
            recipeList = new RecipeList();
            beefNoodle = new Recipe("Beef Noodle");
            beefNoodle.Ingredients.Add(new Ingredient("beef", 10));
            beefNoodle.Ingredients.Add(new Ingredient("noodle", 30));
            RecipeController.AddRecipe(beefNoodle, recipeList);
        }

        [TestMethod]
        public void AddingNewRecipe()
        {
            var expected = "Beef Noodle";
            var actual = recipeList.Recipes[0].Name;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void AddingExistingRecipe()
        {
            var expected = false;
            var actual = RecipeController.AddRecipe(beefNoodle, recipeList);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void DeletingRecipe()
        {
            var expected = true;
            var actual = RecipeController.DeleteRecipe("Beef Noodle", recipeList);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void EditingExistingRecipe()
        {
            Recipe newBeefNoodle = new Recipe("Beef Noodle");
            newBeefNoodle.Ingredients.Add(new Ingredient("beef", 5));
            newBeefNoodle.Ingredients.Add(new Ingredient("noodle", 35));
            RecipeController.EditRecipe(newBeefNoodle, recipeList);
            var expected = 5;
            var actual = recipeList.Recipes[0].Ingredients[0].Weight;
            Assert.AreEqual(expected, actual);
        }
    }
}
