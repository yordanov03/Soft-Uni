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
        var busInput = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();

        var car = new Car(double.Parse(carInput[1]), double.Parse(carInput[2]), double.Parse(carInput[3]));
        var truck = new Truck(double.Parse(truckInput[1]), double.Parse(truckInput[2]), double.Parse(truckInput[3]));
        var bus = new Bus(double.Parse(busInput[1]), double.Parse(busInput[2]), double.Parse(busInput[3]));

        var rotations = int.Parse(Console.ReadLine());


        for (int i = 0; i < rotations; i++)
        {

            try
            {

                var commandLine = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                var vehicleType = commandLine[1];
                var action = commandLine[0];
                var value = double.Parse(commandLine[2]);

                if (action == "Drive")
                {
                    if (vehicleType == "Car")
                    {
                        car.Drive(value);
                    }
                    else if (vehicleType == "Truck")
                    {
                        truck.Drive(value);
                    }
                    else if (vehicleType == "Bus")
                    {
                        bus.Drive(value);
                    }

                }
                else if (action == "DriveEmpty")
                {
                    bus.overConsumption = 0;
                    bus.Drive(value);
                }
                else
                {
                    if (vehicleType == "Car")
                    {
                        car.Refuel(value);
                    }
                    else if (vehicleType == "Truck")
                    {
                        truck.Refuel(value);
                    }
                    else if (vehicleType == "Bus")
                    {
                        bus.Refuel(value);
                    }
                }
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        Console.WriteLine($"Car: {car.FuelQuantity:f2}");
        Console.WriteLine($"Truck: {truck.FuelQuantity:f2}");
        Console.WriteLine($"Bus: {bus.FuelQuantity:f2}");
    }

}




