using System;
namespace Exercises
{
    public class Exercise005
    {
        public bool IsPangram(string input)
        {
            if (input == "")
            {
                return false;
            }

            string alphabet = "abcdefghijklmnopqrstuvwxyz";
            char achar = ' ';
            int count = 0;

            /* let's do it stone age style!... */

            for (int j = 0; j < alphabet.Length; j++)
            {
                for (int i = 0; i < input.Length; i++)
                {
                    count = 0;        /* indicates that a character in the alphabet is in pangram */
                    achar = input[i];
                    
                    if (char.IsUpper(achar) || char.IsLower(achar))
                    {
                        achar = char.ToLower(input[i]);

                        if (alphabet[j] == achar)
                        {
                            count++;
                            break;
                        }
                    }
                    else
                    {
                        if (char.IsDigit(achar) || achar == ' ' || achar == '_')
                        {
                            continue;
                        }
                        else
                        {
                            return false; /* It's not a pangram - unexpected character */
                        }
                    }
                }

                if (count == 0)
                {
                    return false; 
                }
            }

            return true; /* It's  a pangram! */
        }
    }
}
