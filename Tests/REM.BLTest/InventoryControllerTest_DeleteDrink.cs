using System;
using REM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace REM.BLTest
{
    [TestClass]
    public class InventoryControllerTest_DeleteDrink
    {
        DrinkInventory inventory;
        public InventoryControllerTest_DeleteDrink()
        {
            inventory = new DrinkInventory();
            InventoryController.AddInventory(new Drink("coke", 100, 100), inventory);
            InventoryController.AddInventory(new Drink("sprite", 100, 50), inventory);
            InventoryController.AddInventory(new Drink("coke", 100, 300), inventory);
            InventoryController.AddInventory(new Drink("juice", 100, 300), inventory);
            InventoryController.AddInventory(new Drink("coke", 100, 200), inventory);
        }
        [TestMethod]
        public void DeleteDrink()
        {
            InventoryController.DeleteInventory(new Drink("juice", 10), inventory);
            var expected = 90;
            var actual = inventory.DrinkList[2].Quantity;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void UsingAllDrink()
        {
            InventoryController.DeleteInventory(new Drink("sprite", 100), inventory);
            var expected = "juice";
            var actual = inventory.DrinkList[1].Name;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void UsingMoreThanInventory()
        {
            var expected = false;
            var actual = InventoryController.DeleteInventory(new Drink("coke", 400), inventory);
            Assert.AreEqual(expected, actual);
        }
    }
}
