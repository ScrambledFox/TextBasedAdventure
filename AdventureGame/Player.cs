using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGame {
    public static class Player {

        // Fields
        private static string name;
        private static bool hasNameBeenSet = false;

        // Properties
        public static string Name {
            get {
                return name;
            }
            set {
                if (!hasNameBeenSet) {
                    name = value;
                    hasNameBeenSet = true;
                }
            }
        }

        // Methods
        public static void ResetName () {
            hasNameBeenSet = false;
        }

    }
}
