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

namespace AdventureGame
{
    /// <summary>
    /// This class holds all items known in the game.
    /// </summary>
    public static class Items
    {

        /// Food Items
        public static Item apple = new Item(
            "Apple",
            1,
            Item.ItemType.Food);
        public static Item bread = new Item(
            "Loaf of Bread",
            2,
            Item.ItemType.Food
            );

        /// Weapons
        public static Item swordIron = new Item(
            "Iron Sword",
            35,
            Item.ItemType.Weapon
            );
        public static Item swordSteel = new Item(
            "Steel Sword",
            53,
            Item.ItemType.Weapon
            );

        /// Armours
        public static Item helmetIron = new Item(
            "Iron Helmet",
            25,
            Item.ItemType.Armour,
            Item.ArmourSlot.Head
            );

    }
}
