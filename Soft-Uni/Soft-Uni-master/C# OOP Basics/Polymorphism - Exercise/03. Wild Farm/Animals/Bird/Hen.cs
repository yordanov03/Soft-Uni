using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class Hen:Bird
    {
    public Hen(string name, double weight, double wingSize) : base(name, weight, wingSize)
    {

    }
    public override void AskForFood()
    {
        Console.WriteLine( "Cluck");
    }
    public override void Eat(Food typeOfFood)
    {
        this.Weight += typeOfFood.Quantity * 0.35;
        this.FoodEaten = typeOfFood.Quantity;
    }
    public override string ToString()
    {
        return $"Hen [{this.Name}, {this.WingSize}, {this.Weight}, {this.FoodEaten}]";
    }
}

