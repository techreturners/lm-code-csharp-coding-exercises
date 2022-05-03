using System;
using System.Collections.Generic;
using System.Linq;
using Exercises.Models;

namespace Exercises
{
    public class Exercise001
    {
        public string CapitalizeWord(string word)
        {
            // Replace the exception statement below with your code!
            return char.ToUpper(word[0]) + word.Substring(1);
        }

        public string GenerateInitials(string firstName, string lastName)
        {
            // Replace the exception statement below with your code!
            return firstName[0] + "." + lastName[0];
        }

        public double AddVat(double originalPrice, double vatRate)
        {
            // Replace the exception statement below with your code!
            return Math.Round(originalPrice + (originalPrice * (vatRate / 100)), 2);
        }

        public string Reverse(string sentence)
        {
            // Replace the exception statement below with your code!
            return new string(sentence.Reverse().ToArray());
        }

        public int CountLinuxUsers(List<User> users)
        {
            // Replace the exception statement below with your code!
            
            int count = 0;
            foreach (var user in users)
            {
                if (user.Type == "Linux")
                {
                    count++;
                }
                
            }

            return count;
        }
    }
}
