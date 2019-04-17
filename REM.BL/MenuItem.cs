using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REM.BL
{
    public class MenuItem
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public Recipe Recipe { get; set; }
        public string Type { get; set; }
        public MenuItem(string name, decimal price, string type)
        {
            Name = name;
            Price = price;
            Type = type;
        }
    }
}
