using Exercises.Models;
using System;
using System.Collections.Generic;

namespace Exercises
{
    public class Exercise001
    {
        public string CapitalizeWord(string word)
        {
            string sentence = word;
            
            sentence = char.ToUpper(word[0]) + word.Substring(1);

            return sentence;
        }

        public string GenerateInitials(string firstName, string lastName)
        {
            return (char.ToUpper(firstName[0]) + "." + char.ToUpper(lastName[0]));
        }

        public double AddVat(double originalPrice, double vatRate)
        {
            double totalPrice = 0.0;

            totalPrice = originalPrice + ((originalPrice * vatRate) / 100);

            return Math.Round(totalPrice, 2, MidpointRounding.AwayFromZero);
        }

        public string Reverse(string sentence)
        {
            char[] arrSentence = sentence.ToCharArray();

            Array.Reverse(arrSentence);

            return new string(arrSentence);
        }

        public int CountLinuxUsers(List<User> users)
        {
            int count = 0;

            foreach (User a_user in users)
            {
               if (a_user.Type == "Linux")
                    count++;
            }

            return count;
        }
    }
}
