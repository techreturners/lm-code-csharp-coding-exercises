using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercises
{
    public class Exercise003
    {
        private readonly KeyValuePair<string, int>[] iceCreamFlavoursCodes = new KeyValuePair<string, int>[]
        {
            new KeyValuePair<string, int>("Pistachio", 0 ),
            new KeyValuePair<string, int>("Raspberry Ripple", 1 ),
            new KeyValuePair<string, int>("Vanilla", 2 ),
            new KeyValuePair<string, int>("Mint Chocolate Chip", 3 ),
            new KeyValuePair<string, int>("Chocolate", 4 ),
            new KeyValuePair<string, int>("Mango Sorbet", 5 )
        };

        public string[] IceCreamFlavours => iceCreamFlavoursCodes
            .Select(item => item.Key)
            .ToArray();

        public int IceCreamCode(string iceCreamFlavour) => iceCreamFlavoursCodes
            .FirstOrDefault(item => item.Key == iceCreamFlavour) 
            .Value; 

        // Initially I was tempted to store the ice cream flavours in a string array, 
        // and let the ice cream code just be the index of the favour at the array.
        // But then I wasn't sure if Pip the cat will always be encoding ice cream flavours by following 
        // this 0,1,2,3,4,5 pattern. So I decided to use an array of key-value pairs { flavour, code }
        // to have more flexibility.
        //
        // In a previous git commit, I was using dictionary to achieve this flexibility,
        // but after reading the C# doc for dictionary I realise that dictionary
        // doesn't guarantee the ordering of its elements, so I switched to using
        // array of key-value pairs instead.
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
