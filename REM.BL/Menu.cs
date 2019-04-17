using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REM.BL
{
    public class Menu
    {
        public List<MenuItem> MenuList { get; set; }
        public Menu()
        {
            MenuList = new List<MenuItem>();
        }
    }
}
