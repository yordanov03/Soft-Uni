using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public abstract class Animal
    {
    private string name;
    private string favouriteFood;

    public Animal(string name, string favouriteFood)
    {
        this.Name = name;
        this.FavouriteFood = favouriteFood;
    }

    public string Name { get; set; }
    public string FavouriteFood { get; set; }
    public virtual string ExplainSelf()
    {
        return $"I am {this.Name} and my favourite foog is {this.FavouriteFood}\n";
    }
    }

