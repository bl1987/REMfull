using System;
using REM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace REM.BLTest
{
    [TestClass]
    public class DrinkTest
    {
        [TestMethod]
        public void DrinkType()
        {
            Drink drink = new Drink("Beer", 10, 20);
            string expected = "Drink";
            string actual = drink.Type;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ZeroWeight()
        {
            Drink drink = new Drink("Beer", 0, 20);
            var expected = 0;
            var actual = drink.Value;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void LessThanZeroWeight()
        {
            Drink drink = new Drink("Beer", -10, 20);
            var expected = 0;
            var actual = drink.Value;
            Assert.AreEqual(expected, actual);
        }
    }
}
