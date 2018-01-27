/*
 * The Nine Scrolls (C)
 * by Joris (A.J.) Lodewijks, 05/09/2017
 *
 */
using System;

namespace AdventureGame {
    public class Item {

        public enum ItemType {
            Food, Armour, Weapon, Normal
        };

        public enum ArmourSlot {
            Head, Chest, PauldronLeft, PauldronRight, Legs, BootsLeft, BootsRight, GlovesLeft, GlovesRight
        }

        string name;
        float value;
        ItemType itemType;
        ArmourSlot armourSlot;

        public Item ( string name, float value, ItemType itemType = ItemType.Normal) {
            this.name = name;
            this.value = value;
            this.itemType = itemType;
        }

        public Item ( string name, float value, ItemType itemType = ItemType.Normal,  ArmourSlot armourSlot) {
            this.name = name;
            this.value = value;
            this.itemType = itemType;
            this.armourSlot = armourSlot;
        }

        public void DrawInformation () {
            Console.WriteLine("The item called {0} has a value of {1} gold.", name, value);
        }

        public string GetName () {
            return name;
        }

    }
}