using System;
using System.Text;
using System.Collections.Generic;
using REM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace REM.BLTest
{

    [TestClass]
    public class MenuControllerTest
    {
        Recipe steak;
        List<Ingredient> steakRecipe;
        Menu menu;
        public MenuControllerTest()
        {
            steak = new Recipe("steak");
            steakRecipe = new List<Ingredient> { new Ingredient("beef", 15) };
            steak.Ingredients = steakRecipe;
            menu = new Menu();
        }

        [TestMethod]
        public void AddingFirstMenu()
        {
            MenuController.AddMenu(menu, "steak", 50, steak);
            var expected = "Meal";
            var actual = menu.MenuList[0].Type;
            Assert.AreEqual(expected, actual);
        }
    }
}
