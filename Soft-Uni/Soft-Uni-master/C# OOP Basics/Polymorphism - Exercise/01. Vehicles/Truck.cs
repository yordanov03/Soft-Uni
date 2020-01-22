using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class Truck:Vehicles
    {
    public Truck(double fuelQuantity, double fuelConsumption) : base(fuelQuantity, fuelConsumption)
    {
        this.FuelQuantity = fuelQuantity;
        this.FuelConsumption = FuelConsumption;
    }

    public override void Drive(double distance)
    {

        if (FuelQuantity - ((FuelConsumption * distance) + (1.6 * distance)) < 0)
        {
            Console.WriteLine($"Truck needs refueling");
        }
        else
        {
            Console.WriteLine($"Truck travelled {distance} km");

            this.FuelQuantity = FuelQuantity - ((FuelConsumption * distance) + (1.6 * distance));

        }
    }
    public override double Refuel(double fuel)
    {
        return this.FuelQuantity += fuel * 0.95;
    }
}

