using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercises
{
    public class Exercise003
    {
        private readonly Dictionary<string, int> iceCreamFlavoursCodes = new Dictionary<string, int>
        {
            { "Pistachio", 0 },
            { "Raspberry Ripple", 1 },
            { "Vanilla", 2 },
            { "Mint Chocolate Chip", 3 },
            { "Chocolate", 4 },
            { "Mango Sorbet", 5 }
        };

        public string[] IceCreamFlavours => iceCreamFlavoursCodes.Keys.ToArray();

        public int IceCreamCode(string iceCreamFlavour) => iceCreamFlavoursCodes[iceCreamFlavour];

        // Initially I was tempted to store the ice cream flavours in a string array, 
        // and let the ice cream code just be the index of the favour at the array.
        // But then I wasn't sure if Pip the cat will always be encoding ice cream flavours by following 
        // this 0,1,2,3,4,5 pattern. So I decided to use a dictionary to store the { flavour, code }
        // to have more flexibility.
        //
        // The commented out code below is the "simpler" implementation (works as long as Pip encodes their 
        // ice cream flavours based on the 0,1,2,3,4,5 pattern)

        //public string[] IceCreamFlavours = {
        //    "Pistachio",
        //    "Raspberry Ripple",
        //    "Vanilla",
        //    "Mint Chocolate Chip",
        //    "Chocolate",
        //    "Mango Sorbet"
        //};

        //public int IceCreamCode(string iceCreamFlavour) => Array.IndexOf(IceCreamFlavours, iceCreamFlavour);

    }
}
