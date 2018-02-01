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

        public static Dictionary<string, Item> itemNames = new Dictionary<string, Item>();

        /// Food Items
        public static Item apple = new Item(
            "apple",
            "apples",
            1,
            Item.ItemType.Food);
        public static Item bread = new Item(
            "loaf of bread",
            "loafs of bread",
            2,
            Item.ItemType.Food
            );

        /// Weapons
        public static Item swordIron = new Item(
            "iron sword",
            "iron swords",
            35,
            Item.ItemType.Weapon
            );
        public static Item swordSteel = new Item(
            "steel sword",
            "steel swords",
            53,
            Item.ItemType.Weapon
            );

        /// Armours
        public static Item helmetIron = new Item(
            "iron helmet",
            "iron helmets",
            25,
            Item.ArmourSlot.Head
            );

    }
}
