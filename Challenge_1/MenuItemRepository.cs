using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_1
{
    class MenuItemRepository
    {
        List<MenuItem> _listOfItems = new List<MenuItem>();

        public void AddItemToList(MenuItem item)
        {
            _listOfItems.Add(item);
        }

        public void RemoveItemFromList(MenuItem item)
        {
            _listOfItems.Remove(item);
        }

        public List<MenuItem> GetItemList()
        {
            return _listOfItems;
        }
    }
}
