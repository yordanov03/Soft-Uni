using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Person : IComparable<Person>
{

    public Person(string name, int age, string town)
    {
        this.Name = name;
        this.Age = age;
        this.Town = town;
    }

    public string Name { get; set; }
    public int Age { get; set; }
    public string Town { get; set; }

    public int CompareTo(Person otherPerson)
    {
        var result = this.Name.CompareTo(otherPerson.Name);

        if (result==0)
        {
            result = this.Age.CompareTo(otherPerson.Age);

            if (result==0)
            {
                result = this.Town.CompareTo(otherPerson.Town);
            }
        }

        return result;
    }
}

