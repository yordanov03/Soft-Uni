using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Person
{
    string name;
    string birthday;
    List<Person> parents;
    List<Person> children;

    public Person()
    {
        this.Children = new List<Person>();
        this.Parents = new List<Person>();
    }


    public string Name
    {
        get { return name; }
        set { name = value; }
    }
    public string Birthday
    {
        get { return birthday; }
        set { birthday = value; }
    }
    public List<Person> Parents
    {
        get { return parents; }
        set { parents = value; }
    }
    public List<Person> Children
    {
        get { return children; }
        set { children = value; }
    }
    public override string ToString()
    {
        return $"{this.Name} {this.Birthday}";
    }
}

