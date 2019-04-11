using System;
using REM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace REM.BLTest
{
    [TestClass]
    public class InventoryControllerTest_AddDrink
    {
        [TestMethod]
        public void AddFirstDrinkToInventoryName()
        {
            DrinkInventory inventory = new DrinkInventory();
            InventoryController.AddInventory(new Drink("coke", 100, 100), inventory);
            var expected = new Drink("coke", 100, 100).Name;
            var actual = inventory.DrinkList[0].Name;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void AddFirstDrinkToInventoryQuantity()
        {
            DrinkInventory inventory = new DrinkInventory();
            InventoryController.AddInventory(new Drink("coke", 100, 100), inventory);
            var expected = new Drink("coke", 100, 100).Quantity;
            var actual = inventory.DrinkList[0].Quantity;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void AddFirstDrinkToInventoryValue()
        {
            DrinkInventory inventory = new DrinkInventory();
            InventoryController.AddInventory(new Drink("coke", 100, 100), inventory);
            var expected = new Drink("coke", 100, 100).Value;
            var actual = inventory.DrinkList[0].Value;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void AddExsitingDrinkToInventoryQuantity()
        {
            DrinkInventory inventory = new DrinkInventory();
            InventoryController.AddInventory(new Drink("coke", 100, 100), inventory);
            InventoryController.AddInventory(new Drink("coke", 200, 100), inventory);
            var expected = 300;
            var actual = inventory.DrinkList[0].Quantity;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void AddExsitingDrinkToInventoryValue()
        {
            DrinkInventory inventory = new DrinkInventory();
            InventoryController.AddInventory(new Drink("coke", 100, 100), inventory);
            InventoryController.AddInventory(new Drink("coke", 100, 300), inventory);
            var expected = 2;
            var actual = inventory.DrinkList[0].Value;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void AddNewDrinkToInventory()
        {
            DrinkInventory inventory = new DrinkInventory();
            InventoryController.AddInventory(new Drink("coke", 100, 100), inventory);
            InventoryController.AddInventory(new Drink("sprite", 100, 50), inventory);
            var expected = 2;
            var actual = inventory.DrinkList.Count;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void AddNewDrinkToInventoryValue()
        {
            DrinkInventory inventory = new DrinkInventory();
            InventoryController.AddInventory(new Drink("coke", 100, 100), inventory);
            InventoryController.AddInventory(new Drink("sprite", 100, 50), inventory);
            InventoryController.AddInventory(new Drink("coke", 100, 300), inventory);
            var expected = 2;
            var actual = inventory.DrinkList[0].Value;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void AddMultipleDrinkToInventoryValue()
        {
            DrinkInventory inventory = new DrinkInventory();
            InventoryController.AddInventory(new Drink("coke", 100, 100), inventory);
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
