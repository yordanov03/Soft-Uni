using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Program
{
    static void Main(string[] args)
    {
        int numberOfCars = int.Parse(Console.ReadLine());
        var allCars = new List<Car>();

        for (int i = 0; i < numberOfCars; i++)
        {
            var separated = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            allCars.Add(new Car(separated[0], double.Parse(separated[1]), double.Parse(separated[2])));
        }
        var driveCarCommand = Console.ReadLine();

        while (driveCarCommand != "End")
        {
            var separated = driveCarCommand.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var currentCar = allCars.Where(c => c.model == separated[1]).FirstOrDefault();
            double kilometersToBeTravelled = double.Parse(separated[2]);
            double FuelToBeConsumed = currentCar.fuelConsumption * kilometersToBeTravelled;
            currentCar.DriveCar(double.Parse(separated[2]));
            driveCarCommand = Console.ReadLine();
        }

        foreach (var car in allCars)
        {
            Console.WriteLine($"{car.model} {car.fuelAmount:F2} {car.distanceTraveled}");
        }
    }
}