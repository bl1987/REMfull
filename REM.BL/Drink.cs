using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REM.BL
{
    public class Drink:Item
    {
        public int Quantity { get; set; }
        public Drink(string name, int quantity)
        {
            Name = name;
            Quantity = quantity;
            Type = "Drink";
        }
        public Drink(string name, int quantity, decimal cost)
        {
            Name = name;
            Quantity = quantity;
            Type = "Drink";
            if (quantity <= 0)
            {
                Value = 0;
            }
            else
            {
                Value = cost / (decimal)quantity;
            }
        }
    }
}
