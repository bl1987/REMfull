using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REM.BL
{
    public class Item:Expense
    {
        public int ItemId { get; set; }
        private string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value.ToLower();
            }
        }
        public Item()
        {
        }
        public Item(string name, decimal cost)
        {
            Name = name;
            Value = cost;
        }
    }
}
