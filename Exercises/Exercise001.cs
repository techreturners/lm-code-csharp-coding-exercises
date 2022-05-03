using System;
using System.Collections.Generic;
using Exercises.Models;

namespace Exercises
{
    public class Exercise001
    {
        public string CapitalizeWord(string word)
        {
            string firstLetterCapitalized = word[0].ToString().ToUpper();
            string otherLetters = word.Substring(1);
            return firstLetterCapitalized + otherLetters;
        }

        public string GenerateInitials(string firstName, string lastName)
        {
            return $"{firstName[0]}.{lastName[0]}";
        }

        public double AddVat(double originalPrice, double vatRate)
        {
            double vatComponent = originalPrice * vatRate / 100; // dividing by 100 because vatRate is in percentage
            double newPrice = originalPrice + vatComponent; 
            return Math.Round(newPrice, 2); // round newPrice to 2 decimal places
        }

        public string Reverse(string sentence)
        {
            string sentenceReversed = "";
            foreach (char c in sentence)
            {
                sentenceReversed = c + sentenceReversed; // prepends new character so the string is built in reverse
            }
            return sentenceReversed;
        }

        public int CountLinuxUsers(List<User> users)
        {
            int linuxUsersCount = 0;
            foreach (User user in users)
            {
                if (user.Type == "Linux")
                {
                    linuxUsersCount++;
                }
            }
            return linuxUsersCount;
        }
    }
}
