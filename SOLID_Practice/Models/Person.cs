using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Practice.Models;
internal class Person
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public string Email { get; set; }

    // ctor
    public Person(int id ,string firstName, string lastName, int age, string email)
    {
        FirstName = firstName;
        LastName = lastName;
        Age = age;
        Email = email;
        Id = id;
    }

    // Methods
    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Name: {FirstName} {LastName}");
        Console.WriteLine($"Age: {Age}");
        Console.WriteLine($"Email: {Email}");
    }

}

