﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class Person
    {
    private string firstName;
    private string lastName;
    private int age;
    private decimal salary;

    public string FirstName
    {
        
        get { return this.firstName; }

       private set
        {
            if (value.Length<3)
            {
                throw new ArgumentException("First name cannot be less than 3 symbols!");
            }
                this.firstName = value;
        }
    }

    public string LastName
    {
        get { return this.lastName; }

        private set
        {
            if (value.Length<3)
            {
                throw new ArgumentException("Last name cannot be less than 3 symbols!");
            }
            this.lastName = value;
        }
    }

    public int Age
    {
        get { return this.age; }
        private set
        {
            if (value<1)
            {
                throw new ArgumentException("Age cannot be zero or a negative integer!");
            }
            this.age = value;
        }
    }

    public decimal Salary
    {
        get { return this.salary; }
        private set
        {
            if (value<460)
            {
                throw new ArgumentException ("Salary cannot be less than 460 leva!");
            }
            this.salary = value;
        }
    }

    public Person(string firstName, string lastName, int age, decimal salary)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
        this.Age = age;
        this.Salary = salary;
    }

    public void IncreaseSalary(decimal percentage)
    {
        if (this.age < 30)
        {
            this.salary += this.salary * ((percentage / 2) / 100);
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


