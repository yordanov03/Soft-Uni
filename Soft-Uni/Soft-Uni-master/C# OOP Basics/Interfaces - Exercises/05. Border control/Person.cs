using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Person : IEntree
{
    public Person(string name, string id, int age)
    {
        this.Name = name;
        this.ID = id;
        this.Age = age;
    }
    public string Name { get; set; }
    public string ID {get;set;}
    public int Age { get; set; }
    }

