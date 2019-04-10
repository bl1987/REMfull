using System;
using System.Text;
using System.Collections.Generic;
using REM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace REM.BLTest
{
    [TestClass]
    public class ItemTest
    {
        [TestMethod]
        public void ItemNameLowerCase()
        {
            Item item = new Item("BEEF", 100m);
            string expected = "beef";
            string actual = item.Name;
            Assert.AreEqual(expected, actual);
        }
    }
}
