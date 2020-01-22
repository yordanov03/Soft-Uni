using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Program
    {
        static void Main(string[] args)
        {
        var allAnimals = new List<Animal>();
        var allFood = new List<Food>();
        var input = Console.ReadLine();
        int inputCount = 2;

        while (input!="End")
        {
            var separated = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            try
            {
                if (inputCount%2==0)
                {
                    var animalType = separated[0];
                    var name = separated[1];
                    var weight = double.Parse(separated[2]);
                    switch (animalType)
                    {
                        case "Owl":
                           var owl = (new Owl(name, weight, double.Parse(separated[3])));
                            owl.AskForFood();
                            allAnimals.Add(owl);
                            
                            break;
                        case "Hen":
                            var hen = (new Hen(name, weight, double.Parse(separated[3])));
                            hen.AskForFood();
                            allAnimals.Add(hen);
                            break;

                        case "Mouse":
                            var mouse = new Mouse(name, weight, separated[3]);
                            mouse.AskForFood();
                            allAnimals.Add(mouse);
                            break;

                        case "Dog":
                            var dog = new Dog(name, weight, separated[3]);
                            dog.AskForFood();
                            allAnimals.Add(dog);
                            break;

                        case "Cat":
                            var cat = new Cat(name, weight, separated[3], separated[4]);
                            cat.AskForFood();
                            allAnimals.Add(cat);
                            break;

                        case "Tiger":
                            var tiger = new Tiger(name, weight, separated[3], separated[4]);
                            tiger.AskForFood();
                            allAnimals.Add(tiger);
                            break;

                        default:
                            break;
                    }
                }
                else
                {
                    var typeOfFood = separated[0];
                    int foodQuantity = int.Parse(separated[1]);

                    switch (typeOfFood)
                    {
                        case "Meat":
                            var meat = new Meat(foodQuantity);
                            allAnimals.Last().Eat(meat);
                            break;

                        case "Vegetable":
                            var vegetable = new Vegetable(foodQuantity);
                            allAnimals.Last().Eat(vegetable);
                            break;

                        case "Fruit":
                            var fruit = new Fruit(foodQuantity);
                            allAnimals.Last().Eat(fruit);
                            break;

                        case "Seeds":
                        var seeds = new Seeds(foodQuantity);
                            allAnimals.Last().Eat(seeds);
                            break;

                        default:
                            break;
                    }
                }
            }
            catch (ArgumentException ex)
            {

                Console.WriteLine(ex.Message);
            }
            inputCount++;
            input = Console.ReadLine();
        }

        foreach (var animal in allAnimals)
        {
            Console.WriteLine(animal.ToString());
        }
        }
    }

