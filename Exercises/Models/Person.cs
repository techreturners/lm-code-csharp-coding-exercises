namespace Exercises.Models
{
    public class Person
    {
        private string fname;
        private string lname;
        public string city;
        public int age;

        public Person(string Fname, string Lname, string City, int Age)
        {
            fname = Fname;
            lname = Lname;
            city = City;
            age = Age;

        }
    }
}