using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGame {
    public static class Inventory {


        static List<Item> inventory = new List<Item>();

        public static void AddItem (Item item) {
            inventory.Add(item);
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("Added {0} to backpack.", item.GetName());
        }

        public static void DisplayItemsInInventory () {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("You are currently carrying:");
            foreach (var item in inventory) {
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine(item.GetName());
            }
        }

    }
}
