using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REM.BL
{
    public class DrinkInventory
    {
        public List<Drink> DrinkList { get; set; }
        public DrinkInventory()
        {
            DrinkList = new List<Drink>();
        }
    }
}
