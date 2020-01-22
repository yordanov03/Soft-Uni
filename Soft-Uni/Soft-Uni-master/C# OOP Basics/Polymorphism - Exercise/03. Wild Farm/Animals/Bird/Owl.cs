using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class Owl:Bird
    {
    public Owl(string name, double weight,  double wingSize):base(name, weight, wingSize)
    {

    }
    public override void AskForFood()
    {
        Console.WriteLine( "Hoot Hoot");
    }
    public override void Eat(Food typeOfFood)
    {
        if (typeOfFood.GetType().Name == "Meat")
        {
            this.Weight += typeOfFood.Quantity * 0.25;
            this.FoodEaten = typeOfFood.Quantity;
        }
        else
        {
            throw new ArgumentException($"Owl does not eat {typeOfFood.GetType().Name}!");
        }
    }
    public override string ToString()
    {
        return $"Owl [{this.Name}, {this.WingSize}, {this.Weight}, {this.FoodEaten}]";
    }
}

