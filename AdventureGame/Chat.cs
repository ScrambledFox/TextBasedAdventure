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
    public static class Chat
    {

        /// <summary>
        /// The stance of the chat dynamics
        /// </summary>
        public enum ChatStance {
            Friendly, Neutral, Enemy
        };

        /// <summary>
        /// Beginning Title Screen
        /// </summary>
        public static void TitleScreen () {
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.ForegroundColor = ConsoleColor.White;

            string[] text = new string[5];
            text[0] = "The Nine Scrolls";
            text[1] = "Welcome to this Text-Based Adventure Game!";
            text[2] = "---------------------------------------------------------------";
            text[3] = "Hello, brave warrior. Welcome to the world of The Nine Scrolls.";
            text[4] = "";

            for (int i = 0; i < text.Length; i++) {
                Console.SetCursorPosition((Console.WindowWidth - text[i].Length) / 2, Console.CursorTop);
                Console.WriteLine(text[i]);
            }

        }

        /// <summary>
        /// Say something from the perspective of a AI.
        /// </summary>
        /// <param name="nameOfSource">The name of the talking source.</param>
        /// <param name="message">The message that will be displayed.</param>
        public static void Say ( string nameOfSource, string message ) {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;

            Console.SetCursorPosition(10, Console.CursorTop);
            Console.WriteLine(nameOfSource + " says: " + message);
        }

        /// <summary>
        /// Show a notification to the player
        /// </summary>
        /// <param name="text">The message that will be displayed.</param>
        /// <param name="sameLine">Will the next chat element be displayed on the same line?</param>>
        public static void Notification ( string text, bool sameLine = false, bool doSpace = true ) {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;

            Console.SetCursorPosition(10, Console.CursorTop);
            if (sameLine) {
                Console.Write(text + "       ");
            } else {
                Console.WriteLine(text);
                if (doSpace) {
                    Console.WriteLine("");
                }
            }
        }

        public static void Clear () {
            Console.Clear();
        }

        public static void Wait () {
            Console.ReadKey();
        }

        public static void DoSpace () {
            Console.WriteLine("");
        }

        public static string GetAction () {
            Chat.Notification("What do you want to do?", true);

            string answer = Console.ReadLine();
            Chat.Clear();
            return answer;
        }



    }
}
