using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Person
{
    private string name;
    private int age;

    public Person()
    {
        name = "No name";
        age = 1;
    }
    public Person(int age) : this()
    {
        this.name = "No name";
        this.age = age;
    }
    public Person(string name, int age) : this(age)
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

