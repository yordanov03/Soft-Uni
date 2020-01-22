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
    private decimal salary;

    public Person( string firstName, string lastName, int age, decimal salary)
    {
        this.age = age;
        this.firstName = firstName;
        this.lastName = lastName;
        this.salary = salary;
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
    public decimal Salary
    {
        get { return this.salary; }
        set { this.salary = value; }
    }

    public void IncreaseSalary(decimal percentage)
    {
        if (this.age<30)
        {
            this.salary += this.salary * ((percentage/2)/100);
        }
        else
        {
            this.salary += this.salary * (percentage / 100);
        }
    }

    public override string ToString()
    {
        return $"{this.firstName} {this.lastName} receives {this.salary:f2} leva.";
    }
}

