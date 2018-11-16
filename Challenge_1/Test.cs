using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_1
{
   
    public class MenuItemTests
    {

        public int Combo { get; set; }
        public string ItemName { get; set; }
        public string Description { get; set; }
        public string IngList { get; set; }
        public string Price { get; set; }

        public MenuItem(int combo, string itemName, string description, string ingList, string price)
        {
            Combo = combo;
            ItemName = itemName;
            Description = description;
            IngList = ingList;
            Price = price;
        }
    }
}
