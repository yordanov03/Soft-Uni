using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class Mouse:Mammal
    {
    public Mouse(string name, double weight, string livingRegion):base(name, weight,  livingRegion)
    {

    }
    public override void AskForFood()
    {
        Console.WriteLine("Squeak");
    }

    public override void Eat(Food typeOfFood)
    {
        if (typeOfFood.GetType().Name=="Fruit" || typeOfFood.GetType().Name=="Vegetable")
        {
            this.Weight += typeOfFood.Quantity * 0.1;
            this.FoodEaten = typeOfFood.Quantity;
        }
        else
        {
            throw new ArgumentException($"Mouse does not eat {typeOfFood.GetType().Name}!");
        }
    }
    public override string ToString()
    {
        return $"Mouse [{this.Name}, {this.Weight}, {this.LivingRegion}, {this.FoodEaten}]";
    }
}

