/*
 * The Nine Scrolls (C)
 * by Joris (A.J.) Lodewijks, 05/09/2017
 *
 */
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
            Chat.Notification("Added " + item.GetName() + " to backpack.");
        }

        public static void DisplayItemsInInventory () {
            Chat.Notification("You are currently carrying:", false, false);
            foreach (var item in inventory) {
                Chat.Notification(item.GetName(), false, false);
            }
            Chat.DoSpace();
        }

    }
}
