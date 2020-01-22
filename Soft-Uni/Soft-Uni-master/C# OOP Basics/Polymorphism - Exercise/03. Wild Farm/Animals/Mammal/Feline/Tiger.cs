using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Tiger : Feline
{

    public Tiger(string name, double weight, string livingRegion, string breed) : base(name, weight, livingRegion, breed)
    {

    }

    public override void AskForFood()
    {
        Console.WriteLine( "ROAR!!!");
    }
    public override void Eat(Food typeOfFood)
    {
        if (typeOfFood.GetType().Name == "Meat")
        {
            this.Weight += typeOfFood.Quantity;
            this.FoodEaten = typeOfFood.Quantity;
        }
        else
        {
            throw new ArgumentException($"Tiger does not eat {typeOfFood.GetType().Name}!");
        }
    }
    public override string ToString()
    {
        return $"Tiger [{this.Name}, {this.Breed}, {this.Weight}, {this.LivingRegion}, {this.FoodEaten}]";
    }
}

