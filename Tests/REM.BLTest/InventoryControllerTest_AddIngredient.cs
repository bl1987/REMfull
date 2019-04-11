using System;
using REM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace REM.BLTest
{
    [TestClass]
    public class InventoryControllerTest_AddIngredient
    {
        [TestMethod]
        public void AddFirstIngredientToInventoryName()
        {
            IngredientInventory inventory = new IngredientInventory();
            InventoryController.AddInventory(new Ingredient("beef", 100, 100), inventory);
            var expected = new Ingredient("beef", 100, 100).Name;
            var actual = inventory.IngredientList[0].Name;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void AddFirstIngredientToInventoryWeight()
        {
            IngredientInventory inventory = new IngredientInventory();
            InventoryController.AddInventory(new Ingredient("beef", 100, 100), inventory);
            var expected = new Ingredient("beef", 100, 100).Weight;
            var actual = inventory.IngredientList[0].Weight;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void AddFirstIngredientToInventoryValue()
        {
            IngredientInventory inventory = new IngredientInventory();
            InventoryController.AddInventory(new Ingredient("beef", 100, 100), inventory);
            var expected = new Ingredient("beef", 100, 100).Value;
            var actual = inventory.IngredientList[0].Value;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void AddExsitingIngredientToInventoryWeight()
        {
            IngredientInventory inventory = new IngredientInventory();
            InventoryController.AddInventory(new Ingredient("beef", 100, 100), inventory);
            InventoryController.AddInventory(new Ingredient("beef", 200, 100), inventory);
            var expected = 300;
            var actual = inventory.IngredientList[0].Weight;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void AddExsitingIngredientToInventoryValue()
        {
            IngredientInventory inventory = new IngredientInventory();
            InventoryController.AddInventory(new Ingredient("beef", 100, 100), inventory);
            InventoryController.AddInventory(new Ingredient("beef", 100, 300), inventory);
            var expected = 2;
            var actual = inventory.IngredientList[0].Value;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void AddNewIngredientToInventory()
        {
            IngredientInventory inventory = new IngredientInventory();
            InventoryController.AddInventory(new Ingredient("beef", 100, 100), inventory);
            InventoryController.AddInventory(new Ingredient("pork", 100, 50), inventory);
            var expected = 2;
            var actual = inventory.IngredientList.Count;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void AddNewIngredientToInventoryValue()
        {
            IngredientInventory inventory = new IngredientInventory();
            InventoryController.AddInventory(new Ingredient("beef", 100, 100), inventory);
            InventoryController.AddInventory(new Ingredient("pork", 100, 50), inventory);
            InventoryController.AddInventory(new Ingredient("beef", 100, 300), inventory);
            var expected = 2;
            var actual = inventory.IngredientList[0].Value;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void AddMultipleIngredientToInventoryValue()
        {
            IngredientInventory inventory = new IngredientInventory();
            InventoryController.AddInventory(new Ingredient("beef", 100, 100), inventory);
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
