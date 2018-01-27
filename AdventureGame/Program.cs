/*
 * The Nine Scrolls
 * by Joris (A.J.) Lodewijks, 05/09/2017
 *
 */
using System;

namespace AdventureGame
{
    class Program
    {

        static void Main()
        {

            Game.StartGame();
            Console.ReadKey();

        }

       

    }

    public static class Game
    {
        public static void StartGame()
        {
            // Title Screen
            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine("The Nine Scrolls");
            Console.WriteLine("Welcome to this Text-Based Adventure Game!");
            Console.WriteLine("-----------------------------------------------------");

            Console.WriteLine("Hello, brave warrior. Welcome to the world of The Nine Scrolls.");

            AskForName();

            Console.WriteLine("Okay then, " + Player.Name + ". Your adventure will begin now!");

            Item item = new Item("Sword of life", 245);
            Item item1 = new Item("Bread", 5);
            Item item2 = new Item("Apple", 2);
            Item item3 = new Item("Hide helmet", 245);
            Inventory.AddItem(item);
            Inventory.AddItem(item1);
            Inventory.AddItem(item2);
            Inventory.AddItem(item3);
            Inventory.DisplayItemsInInventory();

        }

        static void AskForName()
        {

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("What is your name?");
            Player.Name = Console.ReadLine();

            CheckNameConfirmation();

        }

        static void CheckNameConfirmation()
        {

            string answer;
            Console.WriteLine("So your name is " + Player.Name + "? (Answer with Yes or No)");
            answer = Console.ReadLine().ToLower();

            if (answer == "yes")
            {
                return;
            }
            else if (answer == "no")
            {
                Player.ResetName();
                AskForName();
            }
            else
            {
                Console.WriteLine("I don't understand...");
                CheckNameConfirmation();
            }

        }

    }
}
