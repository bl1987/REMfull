using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REM.BL
{
    public class MenuController
    {
        static public void AddMenu(Menu menu, string name, decimal price)
        {
            menu.MenuList.Add(new MenuItem(name, price, "Drink"));
        }
        static public void AddMenu(Menu menu, string name, decimal price, Recipe recipe)
        {
            menu.MenuList.Add(new MenuItem(name, price, "Meal"));
            menu.MenuList[0].Recipe = recipe;
        }
    }
}
