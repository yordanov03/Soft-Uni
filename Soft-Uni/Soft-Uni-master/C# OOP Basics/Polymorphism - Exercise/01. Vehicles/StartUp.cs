using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class StartUp
{
    static void Main(string[] args)
    {
        var carInput = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
        var truckInput = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();

        var car = new Car(double.Parse(carInput[1]), double.Parse(carInput[2]));
        var truck = new Truck(double.Parse(truckInput[1]), double.Parse(truckInput[2]));

        var rotations = int.Parse(Console.ReadLine());

        for (int i = 0; i < rotations; i++)
        {
            var commandLine = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            if (commandLine[0] == "Drive")
            {
                if (commandLine[1] == "Car")
                {
                    car.Drive(double.Parse(commandLine[2]));
                }
                else
                {
                    truck.Drive(double.Parse(commandLine[2]));
                }
            }
            else
            {
                if (commandLine[1] == "Car")
                {
                    car.Refuel(double.Parse(commandLine[2]));
                }
                else
                {
                    truck.Refuel(double.Parse(commandLine[2]));
                }
            }
        }
        Console.WriteLine($"Car: {car.FuelQuantity:f2}");
        Console.WriteLine($"Truck: {truck.FuelQuantity:f2}");
    }
}

