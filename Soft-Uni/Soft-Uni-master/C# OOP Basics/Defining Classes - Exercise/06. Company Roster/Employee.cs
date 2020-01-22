using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class Employee
    {
    public string name;
    public string department;
    public string position;
    public decimal salary;
    public int age;
    public string email;

    public Employee(string name, decimal salary, string position, string department)
    {
        this.name = name;
        this.salary = salary;
        this.position = position;
        this.department = department;
        this.age = -1;
        this.email = "n/a";

    }
    }

