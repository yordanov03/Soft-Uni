using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public abstract class Animal
    {

    public Animal(string name, double weight)
    {
        this.Name = name;
        this.Weight = weight;

    }
    public string Name { get; set; }
    public double Weight { get; set; }
    protected int FoodEaten { get; set; }

    public abstract void AskForFood();
    public abstract void Eat(Food typeOfFood);

    public abstract override string ToString();

}

