/*
 * The Nine Scrolls (C)
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
            Chat.Clear();

            // Title Screen
            //Chat.TitleScreen();

            // Ask for the player's name, confirm it, then start adventure.
            //AskForName();
            //Chat.Notification("Okay then, " + playerName + ". Your adventure will begin now!");

            //Chat.Wait();
            //Chat.Clear();

            // Chat test
            while (true) {
                Chat.Clear();
                Actions.Decoder(Chat.GetAction());
            }

            //Chat.GetAction();
            
            // Items test
            //Inventory.AddItem(Items.apple);

        }

        /// <summary>
        /// This method asks the player for his/her name in a white text, then asks for confirmation
        /// </summary>
        static void AskForName() {
            Chat.Notification("What is your name?", true);
            playerName = Console.ReadLine();
            Chat.DoSpace();

            CheckNameConfirmation();

        }

        /// <summary>
        /// This method lets the player confirm his/her name.
        /// </summary>
        static void CheckNameConfirmation()
        {
            if (playerName.Length > 40) {
                Chat.Notification("Your name is too long warrior, we would never remember you.");
                AskForName();
                return;
            }

            string answer;
            Chat.Notification("So your name is " + playerName + "? (Answer with Yes or No)", true);
            answer = Console.ReadLine().ToLower();

            Chat.DoSpace();

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
