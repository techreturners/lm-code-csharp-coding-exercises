using System;
using Exercises.Models;

namespace Exercises.Tests
{
    public class Person
    {
        private string _fname;
        private string _sname;
        private string _bplace;
        private int _page;

        public Person(string firstName, string secondName, string birthPlace, int personAge)
        {
            _fname = firstName;
            _sname = secondName;
            _bplace = birthPlace;
            _page = personAge;
        }
        public string FirstName
        {
            get { return _fname; }
            set { _fname = value; }
        }

        public string SecondName
        {
            get { return _sname; }
            set { _sname = value; }
        }

        public string BirthPlace
        {
            get { return _bplace; }
            set { _bplace = value; }
        }

        public int PersonAge
        {
            get { return _page; }
            set { _page = value; }
        }
    }

    public class Exercise002
    {
        public bool IsFromManchester(Person person)
        {
            if (person.BirthPlace == "Manchester")
                return true;
            else
                return false;
        }

        public bool CanWatchFilm(Person person, int ageLimit)
        {
            if (person.PersonAge < ageLimit)
                return false;
            else
                return true;
        }
    }


}
