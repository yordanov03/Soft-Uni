using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class Dog:Mammal
    {
    public Dog(string name, double weight, string livingRegion) : base(name, weight, livingRegion)
    {

    }
    public override void AskForFood()
    {
        Console.WriteLine("Woof!");
    }
    public override void Eat(Food typeOfFood)
    {
        if (typeOfFood.GetType().Name == "Meat")
        {
            this.Weight += typeOfFood.Quantity * 0.4;
            this.FoodEaten = typeOfFood.Quantity;
        }
        else
        {
            throw new ArgumentException($"Dog does not eat {typeOfFood.GetType().Name}!");
        }
    }
    public override string ToString()
    {
        return $"Dog [{this.Name}, {this.Weight}, {this.LivingRegion}, {this.FoodEaten}]";
    }
}

