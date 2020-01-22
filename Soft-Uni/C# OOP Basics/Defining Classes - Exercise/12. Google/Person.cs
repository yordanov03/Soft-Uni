using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Person
{
    public string personName;
    public Company company;
    public List<Pokemon> pokemons;
    public List<Parents> parents;
    public List<Children> children;
    public Car car;


    public Person(string personName)
    {
        this.Name = personName;
        pokemons = new List<Pokemon>();
        parents = new List<Parents>();
        children = new List<Children>();

    }
public string Name
    {
        get
        {
            return this.personName;
        }
        set
        {
            if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException($"{nameof(personName)}'s name cannot be empty or whitespace!");
            }
            this.personName = value;
        }
    }
}

