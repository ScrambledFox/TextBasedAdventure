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
        public static string playerName;

        public static void StartGame()
        {
            // Title Screen
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("The Nine Scrolls");
            Console.WriteLine("Welcome to this Text-Based Adventure Game!");
            Console.WriteLine("-----------------------------------------------------");

            Console.WriteLine("Hello, brave warrior. Welcome to the world of The Nine Scrolls.");
            // Title screen End

            // Ask for the player's name, confirm it, then start adventure.
            AskForName();
            Console.WriteLine("Okay then, " + playerName + ". Your adventure will begin now!");

            // Chat test
            Chat.Say("Gekke Henk", "Ik ga je moeder vermoorden!", Chat.ChatStance.Offensive);

            // Item tests
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

        /// <summary>
        /// This method asks the player for his/her name in a white text, then asks for confirmation
        /// </summary>
        static void AskForName()
        {

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("What is your name?");
            playerName = Console.ReadLine();

            CheckNameConfirmation();

        }

        /// <summary>
        /// This method lets the player confirm his/her name.
        /// </summary>
        static void CheckNameConfirmation()
        {

            string answer;
            Console.WriteLine("So your name is " + playerName + "? (Answer with Yes or No)");
            answer = Console.ReadLine().ToLower();

            if (answer == "yes")
            {
                return;
            }
            else if (answer == "no")
            {
                AskForName();
            }
            else
            {
                Console.WriteLine("I don't understand...");
                CheckNameConfirmation();
            }

        }

        static int amountScrolls = 0;

        static void WonGame() {
            if (amountScrolls == 9)
            {
                Console.WriteLine("Congratulations you have collected all nine scrolls, now you can go eat the cake!");
            }
            else {
                 
            }
        }

    }
}
