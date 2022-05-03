using System;
using System.Security.Cryptography;

namespace Exercises
{
    public class Exercise003
    {
        // Replace the exception statement below with your code!
       
        //*****There Are better ways to write these methods but I'd love to hear your feedback, Thanks.*****//
        public string[] IceCreamFlavours => new string[6] {"Pistachio", "Raspberry Ripple", "Vanilla", "Mint Chocolate Chip", "Chocolate", "Mango Sorbet"};

        // Replace the exception statement below with your code!
        public int IceCreamCode(string iceCreamFlavour) => iceCreamFlavour == "Pistachio" ? 0 : iceCreamFlavour == "Raspberry Ripple" ? 1 : iceCreamFlavour == "Vanilla" ? 2 : iceCreamFlavour=="Mint Chocolate Chip"? 3 : iceCreamFlavour=="Chocolate"? 4 : iceCreamFlavour == "Mango Sorbet" ? 5: -1 ;
    }
}
