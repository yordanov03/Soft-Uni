using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class Car:Vehicles
    {
    public Car(double fuelQuantity, double fuelConsumption) : base(fuelQuantity, fuelConsumption)
    {
        this.FuelQuantity = fuelQuantity;
        this.FuelConsumption = FuelConsumption;
    }

    public override void Drive(double distance)
    {
        
        if (FuelQuantity - ((FuelConsumption * distance) + (0.9 * distance)) < 0)
        {
            Console.WriteLine($"Car needs refueling");
            
        }
        else
        {
            Console.WriteLine($"Car travelled {distance} km");
            this.FuelQuantity = FuelQuantity - ((FuelConsumption * distance) + (0.9 * distance));
            
        }
    }
    public override double Refuel(double fuel)
    {
        return this.FuelQuantity += fuel;
    }
}

