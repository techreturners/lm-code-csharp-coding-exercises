using System;
namespace Exercises
{
    public class Exercise005
    {
        public bool IsPangram(string input)
        {
            string alphabet = "abcdefghijklmnopqrstuvwxyz"; 

            input = input.ToLower(); // lowercase to match with alphabet string's case
            
            foreach (char c in alphabet)
            {
                // if any letter of the alphabet isn't found in the input string,
                // then the input string isn't a pangram
                if (!input.Contains(c))
                {
                    return false; 
                }
            }

            // only way to reach here is if every letter of the alphabet is found in the input string.
            // (or if the alphabet string was typed incorrectly)
            return true;
        }
    }
}
