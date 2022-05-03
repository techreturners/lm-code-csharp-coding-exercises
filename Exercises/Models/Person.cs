using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises.Models
{
    public class Person
    {
        public string FirstName { get; }
        public string LastName { get; }
        public string Location { get; }
        public int Age { get; }

        public Person(string firstName, string lastName, string location, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Location = location;
            Age = age;
        }
    }
}
