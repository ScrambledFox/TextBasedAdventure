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
        public static Item helmetLeather = new Item(
            "leather helmet",
            "leather helmets",
            5,
            Item.ArmourSlot.Head);
        public static Item chestPlateLeather = new Item(
            "leather chestplate",
            "leather chestplates",
            7,
            Item.ArmourSlot.Chest
            );
        public static Item shoulderPadsLeather = new Item(
            "leather shoulderplate",
            "leather shoulderplates",
            3,
            Item.ArmourSlot.PauldronLeft
            );
        public static Item helmetRoseGlass = new Item(
            "rose glass helmet",
            "rose glass helmets",
            15,
            Item.ArmourSlot.Head
            );
        public static Item chestPlateRoseGlass = new Item(
            "rose glass chestplate", 
            "rose glass chestplates", 
            17, 
            Item.ArmourSlot.Chest);
        public static Item shoulderPadsRoseGlass = new Item(
            "rose glass shoulderpad", 
            "rose glass shoulderpads", 
            13, 
            Item.ArmourSlot.PauldronLeft
            );
        public static Item helmetIron = new Item(
            "iron helmet",
            "iron helmets",
            25,
            Item.ArmourSlot.Head
            );
        public static Item chestPlateIron = new Item(
            "iron chestplate", 
            "iron chestplates", 
            27, 
            Item.ArmourSlot.Chest
            );
        public static Item shouldePadsIron = new Item(
            "iron shoulderpad", 
            "iron shoulderpads", 
            23, 
            Item.ArmourSlot.PauldronLeft
            );

    }
}
