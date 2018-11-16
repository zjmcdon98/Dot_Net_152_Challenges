using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_1
{
    class ProgramUI
    {
        MenuItemRepository _menuRepo = new MenuItemRepository();

        public void Run()
        {
            RunMenu();
        }

        private void RunMenu()
        {
            bool isRunning = true;
            while (isRunning)
            {
                Console.WriteLine("Choose an Option:" +
                    "\n1. Add Menu Item" +
                    "\n2. Remove Menu Item" +
                    "\n3. See All Items" +
                    "\n4. Exit");

                int input = int.Parse(Console.ReadLine());
                switch (input)
                {
                    case 1: //Add Menu Item
                        CreateMenuItem();
                        break;

                    case 2: //Remove Menu Item
                        RemoveMenuItem();
                        break;

                    case 3: //See all Items
                        PrintItemList();
                        break;

                    case 4: //Exit
                        isRunning = false;
                        Console.WriteLine("Thank you come again!");
                        Console.ReadLine();
                        break;

                    default:
                        Console.WriteLine("Invalid Response");
                        Console.ReadLine();
                        break;
                }
            }
        }

        private void CreateMenuItem()
        {
            MenuItem newItem = new MenuItem();
            Console.WriteLine("What is the Combo number?\n");
            newItem.Combo = int.Parse(Console.ReadLine());

            Console.WriteLine("What is the Item Name?");
            newItem.ItemName = Console.ReadLine();

            Console.WriteLine("What is the Item Description?");
            newItem.Description = Console.ReadLine();

            Console.WriteLine("What are the Ingredients?");
            newItem.IngList = Console.ReadLine();

            Console.WriteLine("What is the Price?");
            newItem.Price = Console.ReadLine();


            _menuRepo.AddItemToList(newItem);
        }

        private void RemoveMenuItem()
        {
            Console.WriteLine("What Combo # would you like to remove?");
            string choice = Console.ReadLine();
            int input = int.Parse(choice);
            MenuItem menuItem = new MenuItem();
            foreach (MenuItem item in _menuRepo.GetItemList())
            {
                if(input == item.Combo)
                {
                    _menuRepo.RemoveItemFromList(item);
                    break;
                }
            }

             
        }

        private void PrintItemList()
        {
            List<MenuItem> itemList = _menuRepo.GetItemList();
            foreach (MenuItem item in _menuRepo.GetItemList())
            {
                Console.WriteLine(item.ItemName);
            }
        }
    }
}

            

        


       
