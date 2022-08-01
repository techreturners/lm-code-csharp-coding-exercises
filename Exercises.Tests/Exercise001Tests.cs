using NUnit.Framework;
using FluentAssertions;
using Exercises.Models;
using System.Collections.Generic;
using System;

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
            Exercise001.CapitalizeWord(null).Should().Be(null);
            Exercise001.CapitalizeWord(" ").Should().Be(" ");
            Exercise001.CapitalizeWord(string.Empty).Should().Be(string.Empty);
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
        public void AddVat_Should_Throw_Argument_Exception()
        {
            // Advanced challenge - uncomment these lines and make this test pass too.
            //var ex = Assert.Throws<ArgumentException>(() => Exercise001.AddVat(-25, 0));
            //Assert.That(ex.Message, Is.EqualTo("Price cannot be negative. Please enter a valid price."));
            //ex = Assert.Throws<ArgumentException>(() => Exercise001.AddVat(25, -5));
            //Assert.That(ex.Message, Is.EqualTo("VAT cannot be negative. Please enter a valid VAT."));
        }

        [Test]
        public void Reverse_Should_Return_Correctly_Reversed_String()
        {
            Exercise001.Reverse("foo").Should().Be("oof");
            Exercise001.Reverse("why would you even want to do this?").Should().Be("?siht od ot tnaw neve uoy dluow yhw");            
        }

        [Test]
        public void Reverse_Should_Handle_Unusual_Inputs()
        {
            Exercise001.Reverse("x").Should().Be("x");
            Exercise001.Reverse(null).Should().Be(null);
            Exercise001.Reverse(" ").Should().Be(" ");
            Exercise001.Reverse("level").Should().Be("level");
            Exercise001.Reverse("why not numb3r5").Should().Be("5r3bmun ton yhw");
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

        [Test]
        public void CountLinuxUsers_Should_Return_Zero_For_Null_Or_Empty_Input()
        {            
            Exercise001.CountLinuxUsers(null).Should().Be(0);
            Exercise001.CountLinuxUsers(new List<User>()).Should().Be(0);
        }
    }
}
