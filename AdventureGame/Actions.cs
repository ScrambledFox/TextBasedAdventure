﻿/*
 * The Nine Scrolls (C)
 * by Joris (A.J.) Lodewijks, 05/09/2017
 *
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGame {
    public static class Actions {

        // First get the first keyword of the string, this is mostly the thing that a player wants to do.


        public static void Decoder (string action) {
            action = action.ToLower();
            string actionToDo = GetWordFromAction(action, 1);

            switch (actionToDo) {
                default:
                    Chat.Error("This action is not a valid action");
                    break;
                case "find":
                    FindAction(GetWordFromAction(action, 2));
                    break;
                case "search":
                    FindAction(GetWordFromAction(action, 2));
                    break;
                case "attack":
                    break;
                case "go":
                    break;
            }
        }

        static string GetWordFromAction ( string stringToCut, int word = 1 ) {
            string tempString = stringToCut + " ";
            int spaceIndex = 0;

            for (int i = 1; i < word; i++) {
                // Find apples
                spaceIndex = tempString.IndexOf(' ');
                tempString = tempString.Substring(spaceIndex + 1);
            }

            spaceIndex = tempString.IndexOf(' ');
            tempString = tempString.Substring(0, spaceIndex);

            Chat.Notification(tempString);
            return tempString;
        }

        static void FindAction (string objectToFind) {
            switch (objectToFind) {
                default:
                    Chat.Notification("You didn't find what you were searching for.");
                    break;
                case "apple":
                    Chat.Notification("You found 2 apples");
                    Inventory.AddItem(Items.apple);
                    Inventory.AddItem(Items.apple);
                    break;
                case "apples":
                    Chat.Notification("You found 2 apples");
                    Inventory.AddItem(Items.apple);
                    Inventory.AddItem(Items.apple);
                    break;
            }
        }

    }
}
