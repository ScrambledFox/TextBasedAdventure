﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGame {
    public static class Inventory {


        static List<Item> inventory = new List<Item>();

        public enum ArmourSlots
        {
            Head, Chest, PauldronLeft, PauldronRight, Legs, BootsLeft, BootsRight, GlovesLeft, GlovesRight
        }


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
