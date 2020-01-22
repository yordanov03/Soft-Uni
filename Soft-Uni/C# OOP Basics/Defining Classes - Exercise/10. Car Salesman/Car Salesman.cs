using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        int numberOfEngines = int.Parse(Console.ReadLine());
        var allEngines = new List<Engine>();

        for (int i = 0; i < numberOfEngines; i++)
        {
            var separated = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            var currentEngine = new Engine(separated[0], separated[1]);
            if (separated.Count >= 3)
            {
                int displacement;
                var current = int.TryParse(separated[2], out displacement);
                if (displacement!=0)
                {
                    currentEngine.displacement = separated[2];
                }
                else
                {
                    currentEngine.efficiency = separated[2];
                }
                
            }
            if (separated.Count == 4)
            {
                currentEngine.efficiency = separated[3];
            }
            allEngines.Add(currentEngine);
        }
        int numberOfCars = int.Parse(Console.ReadLine());
        var allCars = new List<Car>();

        for (int i = 0; i < numberOfCars; i++)
        {
            var separated = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            var currentCar = new Car(separated[0], separated[1]);
            if (separated.Count>=3)
            {
                int weight;
                var current = int.TryParse(separated[2], out weight);
                if (weight!=0)
                {
                    currentCar.weight = separated[2];
                }
                else
                {
                    currentCar.color = separated[2];
                }
                
            }
            if (separated.Count==4)
            {
                currentCar.color = separated[3];
            }
            allCars.Add(currentCar);
        }

        for (int i = 0; i < allCars.Count; i++)
        {
            var currentEngine = allEngines.Where(e => e.model == allCars[i].engine).FirstOrDefault();
            Console.WriteLine($"{allCars[i].model}:");
            Console.WriteLine($"  {allCars[i].engine}:");
            Console.WriteLine($"    Power: {currentEngine.power}");
            Console.WriteLine($"    Displacement: {currentEngine.displacement}");
            Console.WriteLine($"    Efficiency: {currentEngine.efficiency}");
            Console.WriteLine($"  Weight: {allCars[i].weight}");
            Console.WriteLine($"  Color: {allCars[i].color}");
        }
    }
}

