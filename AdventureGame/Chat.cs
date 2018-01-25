using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGame
{
    public static class Chat
    {

        public enum ChatStance {
            Normal, Offensive, Defensive
        };

        public static void Say (string nameOfSource, string message, ChatStance reaction) {
            Console.WriteLine(nameOfSource + " says: " + message);
        }

    }
}
