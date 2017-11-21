/*
 * The Nine Scrolls
 * by Joris (A.J.) Lodewijks, 05/09/2017
 *
 */
using System;

namespace AdventureGame {
    public class Item {

        string name;
        float value;

        public Item ( string name, float value ) {
            this.name = name;
            this.value = value;
        }

        public void DrawInformation () {
            Console.WriteLine("The item called {0} has a value of {1} gold.", name, value);
        }

        public string GetName () {
            return name;
        }

    }
}