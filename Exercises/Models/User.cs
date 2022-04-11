using System;
namespace Exercises.Models
{
    public class User
    {

        public User(string username, string operatingSystem, string type)
        {
            Username = username;
            OperatingSystem = operatingSystem;
            Type = type;
        }

        public string Username { get; set; }

        public string OperatingSystem { get; set; }

        public string Type { get; set; }
    }
}
