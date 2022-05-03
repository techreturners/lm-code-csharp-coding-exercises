using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises.Models
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Location { get; set; }
        public int Age { get; set; }

        public Person(string firstName, string lastName, string location, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Location = location;
            Age = age;
        }
    }
}
