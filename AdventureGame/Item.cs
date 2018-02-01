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
        string nameMultiple;
        float value;
        ItemType itemType;
        ArmourSlot armourSlot;

        public Item ( string name, string nameMultiple, float value, ItemType itemType = ItemType.Normal) {
            this.name = name;
            this.nameMultiple = nameMultiple;
            this.value = value;
            this.itemType = itemType;

            Items.itemNames.Add(name.ToLower(), this);
            Items.itemNames.Add(nameMultiple.ToLower(), this);
        }

        public Item ( string name, string nameMultiple, float value, ArmourSlot armourSlot, ItemType itemType = ItemType.Armour) {
            this.name = name;
            this.nameMultiple = nameMultiple;
            this.value = value;
            this.itemType = itemType;
            this.armourSlot = armourSlot;

            Items.itemNames.Add(name.ToLower(), this);
            Items.itemNames.Add(nameMultiple.ToLower(), this);
        }

        public string GetName () {
            return name;
        }

        public string GetMultipleName () {
            return nameMultiple;
        }

        public void DrawInformation () {
            Console.WriteLine("The item called {0} has a value of {1} gold.", name, value);
        }

    }
}