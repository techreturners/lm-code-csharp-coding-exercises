using NUnit.Framework;
using FluentAssertions;
using Exercises.Models;
using System.Collections.Generic;

namespace Exercises.Tests
{
    public class Exercise001Tests
    {
        private Exercise001 Exercise001;

        [SetUp]
        public void Setup()
        {
            Exercise001 = new Exercise001();
        }

        [Test]
        public void CapitalizeWord_Should_Return_The_First_Letter_Capitalized()
        {
            Exercise001.CapitalizeWord("hello").Should().Be("Hello");
            Exercise001.CapitalizeWord("oh no, bears!!").Should().Be("Oh no, bears!!");
            Exercise001.CapitalizeWord("the quick fox").Should().Be("The quick fox");
        }

        [Test]
        public void GenerateInitials_Should_Return_Correct_Initials()
        {
            Exercise001.GenerateInitials("Frederic", "Bonneville").Should().Be("F.B");
            Exercise001.GenerateInitials("James", "Bond").Should().Be("J.B");
        }

        [Test]
        public void AddVat_Should_Return_Correct_Price_Plus_Vat()
        {
            Exercise001.AddVat(100, 20).Should().Be(120);
            Exercise001.AddVat(40, 17.5).Should().Be(47);
            Exercise001.AddVat(33.5, 17.5).Should().Be(39.36);
            Exercise001.AddVat(25, 0).Should().Be(25);
        }

        [Test]
        public void Reverse_Should_Return_Correctly_Reversed_String()
        {
            Exercise001.Reverse("foo").Should().Be("oof");
            Exercise001.Reverse("why would you even want to do this?").Should().Be("?siht od ot tnaw neve uoy dluow yhw");
        }

        [Test]
        public void CountLinuxUsers_Should_Return_Zero_For_No_Linux_Users()
        {
            // This is using the latest C# language features
            // This is the same as doing User u1 = new User("Heather", "Windows 10", "Windows");
            User u1 = new("Heather", "Windows 10", "Windows");
            User u2 = new("Paul", "Windows 95", "Windows");

            var users = new List<User>
            {
                u1,
                u2
            };

            Exercise001.CountLinuxUsers(users).Should().Be(0);
        }

        [Test]
        public void CountLinuxUsers_Should_Return_Correct_Count()
        {
            // This is using the latest C# language features
            // This is the same as doing User u1 = new User("Heather", "Windows 10", "Windows");
            User u1 = new("Heather", "Windows 10", "Windows");
            User u2 = new("Paul", "Windows 95", "Windows");
            User u3 = new("Sheila", "CentOS 7", "Linux");
            User u4 = new("Pedro", "Ubuntu 18.04", "Linux");

            var users = new List<User>
            {
                u1,
                u2,
                u3,
                u4
            };

            Exercise001.CountLinuxUsers(users).Should().Be(2);
        }
    }
}
