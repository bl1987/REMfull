using System;
using REM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace REM.BLTest
{
    [TestClass]
    public class IngredientTest
    {
        [TestMethod]
        public void IngredientType()
        {
            Ingredient ingredient = new Ingredient("beef", 100f, 100);
            var expected = "Ingredient";
            var actual = ingredient.Type;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ZeroWeight()
        {
            Ingredient ingredient = new Ingredient("beef", 0, 100);
            var expected = 0;
            var actual = ingredient.Value;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void LessThanZeroWeight()
        {
            Ingredient ingredient = new Ingredient("beef", -100, 100);
            var expected = 0;
            var actual = ingredient.Value;
            Assert.AreEqual(expected, actual);
        }
    }
}
