using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Program
    {
    static void Main(string[] args)
    {
        int numberOfCars = int.Parse(Console.ReadLine());
        var allCars = new List<Car>();

        for (int i = 0; i < numberOfCars; i++)
        {
            var input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var model = input[0];
            var engine = new Engine(double.Parse(input[1]), double.Parse(input[2]));
            var cargo = new Cargo(double.Parse(input[3]), input[4]);
            var tires = new Tire(double.Parse(input[5]), double.Parse(input[6]), double.Parse(input[7]), double.Parse(input[8]),
                double.Parse(input[9]), double.Parse(input[10]), double.Parse(input[11]), double.Parse(input[12]));
            allCars.Add(new Car(model, engine, cargo, tires));
        }
        string criteria = Console.ReadLine();

        if (criteria == "fragile")
        {
            var sorted = allCars.Where(c => c.cargo.cargoType == criteria).Where(tp => tp.tires.tire1Pressure < 1 || tp.tires.tire2Pressure < 1 || tp.tires.tire3Pressure < 1 || tp.tires.tire4Pressure < 1).Select(c=>new { carModel = c.model }). ToList();
            for (int i = 0; i < sorted.Count; i++)
            {
                Console.WriteLine(sorted[i].carModel);
            }
        }
        else if (criteria== "flamable")
        {
            var sorted = allCars.Where(c => c.cargo.cargoType == criteria).Where(ep => ep.engine.enginePower > 250).ToList();
            foreach (var car in sorted)
            {
                Console.WriteLine(car.model);
            }
        }
        }
    }

