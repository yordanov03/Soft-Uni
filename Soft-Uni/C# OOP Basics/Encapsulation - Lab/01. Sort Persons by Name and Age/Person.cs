using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class Person
    {
    private string firstName;
    private string lastName;
    private int age;



    public Person (string firstName, string lastName, int age)
    {
        this.age = age;
        this.firstName = firstName;
        this.lastName = lastName;
    }

    public string FirstName
    {
        get { return this.firstName; }
    }
    public string LastName
    {
        get { return this.lastName; }
    }

    public int Age
    {
        get { return this.age; }
    }

    public override string ToString()
    {
        return $"{this.firstName} {this.lastName} is {this.age} years old.";
    }
}

