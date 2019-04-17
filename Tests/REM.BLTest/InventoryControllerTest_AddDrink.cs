using System;
using REM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace REM.BLTest
{
    [TestClass]
    public class InventoryControllerTest_AddDrink
    {
        DrinkInventory inventory;
        public InventoryControllerTest_AddDrink()
        {
            inventory = new DrinkInventory();
            InventoryController.AddInventory(new Drink("coke", 100, 100), inventory);
        }
        [TestMethod]
        public void AddFirstDrinkToInventoryName()
        {
            var expected = new Drink("coke", 100, 100).Name;
            var actual = inventory.DrinkList[0].Name;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void AddFirstDrinkToInventoryQuantity()
        {
            var expected = new Drink("coke", 100, 100).Quantity;
            var actual = inventory.DrinkList[0].Quantity;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void AddFirstDrinkToInventoryValue()
        {
            var expected = new Drink("coke", 100, 100).Value;
            var actual = inventory.DrinkList[0].Value;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void AddExsitingDrinkToInventoryQuantity()
        {
            InventoryController.AddInventory(new Drink("coke", 200, 100), inventory);
            var expected = 300;
            var actual = inventory.DrinkList[0].Quantity;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void AddExsitingDrinkToInventoryValue()
        {
            InventoryController.AddInventory(new Drink("coke", 100, 300), inventory);
            var expected = 2;
            var actual = inventory.DrinkList[0].Value;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void AddNewDrinkToInventory()
        {
            InventoryController.AddInventory(new Drink("sprite", 100, 50), inventory);
            var expected = 2;
            var actual = inventory.DrinkList.Count;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void AddNewDrinkToInventoryValue()
        {
            InventoryController.AddInventory(new Drink("sprite", 100, 50), inventory);
            InventoryController.AddInventory(new Drink("coke", 100, 300), inventory);
            var expected = 2;
            var actual = inventory.DrinkList[0].Value;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void AddMultipleDrinkToInventoryValue()
        {
            InventoryController.AddInventory(new Drink("sprite", 100, 50), inventory);
            InventoryController.AddInventory(new Drink("coke", 100, 300), inventory);
            InventoryController.AddInventory(new Drink("juice", 100, 300), inventory);
            InventoryController.AddInventory(new Drink("coke", 100, 200), inventory);
            var expected = 2;
            var actual = inventory.DrinkList[0].Value;
            Assert.AreEqual(expected, actual);
        }
    }
}
