/*
 * The Nine Scrolls
 * by Joris (A.J.) Lodewijks, 05/09/2017
 *
 */
using System;

namespace AdventureGame {
    public class Item {

        public enum ItemType
        {
            Food, Armour, Weapon, Normal
        };

        string name;
        float value;
        ItemType itemType;

        public Item ( string name, float value, ItemType itemType = ItemType.Normal) {
            this.name = name;
            this.value = value;
            this.itemType = itemType;
        }

        public void DrawInformation () {
            Console.WriteLine("The item called {0} has a value of {1} gold.", name, value);
        }

        public string GetName () {
            return name;
        }

    }
}