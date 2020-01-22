using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Pokemon
{
    public string name;
    public string type;

    public Pokemon(string name, string type)
    {
        this.Name = name;
        this.type = type;

    }
    private string Name
    {
        set
        {
            if (string.IsNullOrEmpty(value)|| string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException($"{nameof(Pokemon)}'s name cannot be empty or whitespace!");
            }
            this.name = value;
        }
    }
}

