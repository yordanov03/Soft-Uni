using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Person
{
    private string name;
    private int age;

  
    public Person(string name, int age)
    {
        this.name = name;
        this.age = age;
    }
    public string Name
    {
        get { return this.name; }
    }
    public int Age
    {
        get { return this.age; }
    }
}

