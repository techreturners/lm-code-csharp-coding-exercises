using System;
using Exercises.Models;

namespace Exercises
{
    public class Exercise002
    {
        public bool IsFromManchester(Person p1)
        {
            // Replace the exception statement below with your code!
            
            return p1.city == "Manchester" ? true : false;
        }

        public bool CanWatchFilm(Person p2, int ageLimit)
        {
            // Replace the exception statement below with your code!
            
            return p2.age > ageLimit ? true : false;
        }
    }
}
