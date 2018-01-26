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

            Console.SetWindowSize(150, 32);
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
            Chat.TitleScreen();

            // Ask for the player's name, confirm it, then start adventure.
            AskForName();
            Chat.Notification("Okay then, " + playerName + ". Your adventure will begin now!");

            // Chat test
            Chat.Say("Gekke Henk", "Ik ga je moeder vermoorden!");

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
        static void AskForName() {
            Chat.Notification("What is your name?", true);
            playerName = Console.ReadLine();

            CheckNameConfirmation();

        }

        /// <summary>
        /// This method lets the player confirm his/her name.
        /// </summary>
        static void CheckNameConfirmation()
        {
            if (playerName.Length > 20) {
                Chat.Notification("Your name is too long warrior, we would never remember you.");
                AskForName();
                return;
            }

            string answer;
            Chat.Notification("So your name is " + playerName + "? (Answer with Yes or No)");
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
                Chat.Notification("I don't understand...");
                CheckNameConfirmation();
            }

        }

        static int amountScrolls = 0;

        static void WonGame() {
            if (amountScrolls == 9)
            {
                Chat.Notification("Congratulations you have collected all nine scrolls, now you can go eat the cake!");
            }
            else {
                 
            }
        }

    }
}
