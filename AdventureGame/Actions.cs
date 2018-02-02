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

namespace AdventureGame {
    public static class Actions {

        // First get the first keyword of the string, this is mostly the thing that a player wants to do.

        static string[] keywordsToIgnore = new string[] { "for", "some", "few", "a", "an" };


        public static void Decoder (string action) {
            action = action.ToLower();
            string actionToDo = GetWordFromString(action, 1);

            switch (actionToDo) {
                default:
                    Chat.Error("This action is not a valid action");
                    break;
                case "answer":
                    // text to someone
                    break;
                case "ask":
                    // for or about
                    break;
                case "attack":
                    // who
                    break;
                case "buy":
                    // something
                    break;
                case "climb":
                    // something
                    break;
                case "close":
                    // object
                    break;
                case "cut":
                    // something
                    break;
                case "dig":
                    // something
                    break;
                case "drink":
                    // something
                    break;
                case "drop":
                    // amount objects
                    break;
                case "eat":
                    // item
                    break;
                case "enter":
                    // something
                    break;
                case "examine":
                    // something
                    break;
                case "exit":
                    break;
                case "fill":
                    // something
                    break;
                case "get":
                    // off something
                    break;
                case "give":
                    // something to someone
                    break;
                case "go":
                    // N, S, E, W
                    // to place
                    break;
                case "help":
                    // me with something
                    break;
                case "inventory":
                    // or just i
                    break;
                case "i":
                    break;
                case "jump":
                    // or jump over
                    break;
                case "kiss":
                    // someone
                    break;
                case "listen":
                    // to someone
                    // for something
                    break;
                case "lock":
                    // object
                    // object with something
                    break;
                case "look":
                    // inside something
                    // under something
                    // up text in something
                    break;
                case "no":
                    break;
                case "open":
                    // something
                    break;
                case "pull":
                    // something
                    break;
                case "push":
                    // something
                    // something direction
                    break;
                case "put":
                    // something on something
                    // something in something
                    break;
                case "pray":
                    // to someone
                    // for something
                    // for something to someone
                    // to someone for something
                    break;
                case "quit":

                    break;
                case "q":
                    break;
                case "restart":
                    break;
                case "rub":
                    // something
                    break;
                case "run":
                    // away
                    // to somewhere
                    break;
                case "save":
                    break;
                case "say":
                    // text
                    // text to someone
                    break;
                case "set":
                    // something to something
                    break;
                case "show":
                    // something to something
                    break;
                case "sing":
                    break;
                case "sit":
                    // on something
                    break;
                case "sleep":
                    // for x hours
                    break;
                case "smell":
                    // something
                    break;
                case "sorry":
                    break;
                case "swim":
                    // to somewhere
                    break;
                case "swing":
                    // something
                    break;
                case "switch":
                    // something on/off
                    break;
                case "talk":
                    // to someone
                    break;
                case "take":
                    // things
                    // off something
                    break;
                case "taste":
                    // something
                    break;
                case "tell":
                    // someone about something
                    break;
                case "think":
                    // about something
                    break;
                case "touch":
                    // something
                    break;
                case "turn":
                    // something
                    break;
                case "unlock":
                    // something with something
                    break;
                case "wait":
                    // for x hours
                    break;
                case "wake":
                    // up
                    // someone
                    break;
                case "wave":
                    // something
                    // to someone
                    break;
                case "wear":
                    // something
                    break;
                case "yes":
                    break;
                case "find":
                    // something
                    Find(action);
                    break;
                case "search":
                    // something
                    // somewhere
                    Find(action);
                    break;
            }

            Chat.Wait();
        }

        static string GetWordFromString ( string stringToCut, int word = 1 ) {
            string tempString = stringToCut + " ";
            int spaceIndex = 0;

            for (int i = 1; i < word; i++) {
                spaceIndex = tempString.IndexOf(' ');
                tempString = tempString.Substring(spaceIndex + 1);
            }

            spaceIndex = tempString.IndexOf(' ');
            tempString = tempString.Substring(0, spaceIndex);

            Chat.Notification("Found an keyword: " + tempString);
            return tempString;
        }

        static void Find (string action) {
            int wordIndex = 2;
            string stringToTest = "";

            bool foundObject = false;
            while (!foundObject) {
                stringToTest = GetWordFromString(action, wordIndex);
                if (keywordsToIgnore.Contains(stringToTest)) {
                    wordIndex++;
                } else {
                    foundObject = true;
                }
            }

            if (Items.itemNames.ContainsKey(stringToTest)) {
                Item item;
                Items.itemNames.TryGetValue(stringToTest, out item);
                Inventory.AddItem(item);
            } else {
                Chat.Notification("I don't know what a " + stringToTest + " is.");
            }

            Chat.Notification(Items.itemNames["loaf of bread"].GetMultipleName());

        }

    }
}
