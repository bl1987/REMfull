using System;
using REM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace REM.BLTest
{
    [TestClass]
    public class InventoryControllerTest_AddIngredient
    {
        IngredientInventory inventory;
        public InventoryControllerTest_AddIngredient()
        {
            inventory = new IngredientInventory();
            InventoryController.AddInventory(new Ingredient("beef", 100, 100), inventory);
        }
        [TestMethod]
        public void AddFirstIngredientToInventoryName()
        {
            var expected = new Ingredient("beef", 100, 100).Name;
            var actual = inventory.IngredientList[0].Name;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void AddFirstIngredientToInventoryWeight()
        {
            var expected = new Ingredient("beef", 100, 100).Weight;
            var actual = inventory.IngredientList[0].Weight;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void AddFirstIngredientToInventoryValue()
        {
            var expected = new Ingredient("beef", 100, 100).Value;
            var actual = inventory.IngredientList[0].Value;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void AddExsitingIngredientToInventoryWeight()
        {
            InventoryController.AddInventory(new Ingredient("beef", 200, 100), inventory);
            var expected = 300;
            var actual = inventory.IngredientList[0].Weight;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void AddExsitingIngredientToInventoryValue()
        {
            InventoryController.AddInventory(new Ingredient("beef", 100, 300), inventory);
            var expected = 2;
            var actual = inventory.IngredientList[0].Value;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void AddNewIngredientToInventory()
        {
            InventoryController.AddInventory(new Ingredient("pork", 100, 50), inventory);
            var expected = 2;
            var actual = inventory.IngredientList.Count;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void AddNewIngredientToInventoryValue()
        {
            InventoryController.AddInventory(new Ingredient("pork", 100, 50), inventory);
            InventoryController.AddInventory(new Ingredient("beef", 100, 300), inventory);
            var expected = 2;
            var actual = inventory.IngredientList[0].Value;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void AddMultipleIngredientToInventoryValue()
        {
            InventoryController.AddInventory(new Ingredient("pork", 100, 50), inventory);
            InventoryController.AddInventory(new Ingredient("beef", 100, 300), inventory);
            InventoryController.AddInventory(new Ingredient("chicken", 100, 300), inventory);
            InventoryController.AddInventory(new Ingredient("beef", 100, 200), inventory);
            var expected = 2;
            var actual = inventory.IngredientList[0].Value;
            Assert.AreEqual(expected, actual);
        }
    }
}
