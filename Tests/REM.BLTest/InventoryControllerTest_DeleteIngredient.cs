using System;
using REM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace REM.BLTest
{
    [TestClass]
    public class InventoryControllerTest_DeleteIngredient
    {
        IngredientInventory inventory;
        public InventoryControllerTest_DeleteIngredient()
        {
            inventory = new IngredientInventory();
            InventoryController.AddInventory(new Ingredient("beef", 100, 100), inventory);
            InventoryController.AddInventory(new Ingredient("pork", 100, 50), inventory);
            InventoryController.AddInventory(new Ingredient("beef", 100, 300), inventory);
            InventoryController.AddInventory(new Ingredient("chicken", 100, 300), inventory);
            InventoryController.AddInventory(new Ingredient("beef", 100, 200), inventory);
        }
        [TestMethod]
        public void DeleteIngredient()
        {
            InventoryController.DeleteInventory(new Ingredient("chicken", 10), inventory);
            var expected = 90;
            var actual = inventory.IngredientList[2].Weight;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void UsingAllIngredient()
        {
            InventoryController.DeleteInventory(new Ingredient("pork", 100), inventory);
            var expected = "chicken";
            var actual = inventory.IngredientList[1].Name;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void UsingMoreThanInventory()
        {
            var expected = false;
            var actual = InventoryController.DeleteInventory(new Ingredient("beef", 400), inventory);
            Assert.AreEqual(expected, actual);
        }
    }
}
