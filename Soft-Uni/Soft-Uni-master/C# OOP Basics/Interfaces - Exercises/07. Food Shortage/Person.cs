using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public abstract class Person : IPerson, IBuyer
{

    public string Name { get; set; }
    public int Age { get; set; }
    public int Food { get; protected set; }

    public Person(string name, int age)
    {
        this.Name = name;
        this.Age = age;
    }


    public abstract void BuyFood();
}

