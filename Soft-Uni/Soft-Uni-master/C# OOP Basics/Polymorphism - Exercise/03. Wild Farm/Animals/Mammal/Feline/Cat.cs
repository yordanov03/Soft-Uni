using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class Cat:Feline
    {
    
    public Cat(string name, double weight, string livingRegion,string breed) : base(name, weight, livingRegion,breed)
    {
        
    }
    public override void AskForFood()
    {
       Console.WriteLine("Meow");
    }
    public override void Eat(Food typeOfFood)
    {
        if (typeOfFood.GetType().Name=="Vegetable" || typeOfFood.GetType().Name == "Meat")
        {
            this.Weight += typeOfFood.Quantity * 0.3;
            this.FoodEaten = typeOfFood.Quantity;
        }
        else
        {
            throw new ArgumentException($"Cat does not eat {typeOfFood.GetType().Name}!");
        }
    }

    public override string ToString()
    {
        return $"Cat [{this.Name}, {this.Breed}, {this.Weight}, {this.LivingRegion}, {this.FoodEaten}]";
    }
}

