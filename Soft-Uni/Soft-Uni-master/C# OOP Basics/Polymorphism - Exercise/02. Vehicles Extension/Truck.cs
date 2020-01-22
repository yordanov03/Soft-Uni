using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class Truck:Vehicles
    {
    public Truck (double fuelQuantity, double fuelConsumption, double tankCapacity) : base(fuelQuantity, fuelConsumption, tankCapacity)
    {
        this.FuelQuantity = fuelQuantity;
        this.FuelConsumption = fuelConsumption;
        this.TankCapacity = tankCapacity;
        overConsumption = 1.6;
    }
    public override void Refuel(double fuel)
    {
        if (fuel > this.TankCapacity - this.FuelQuantity)
        {
            throw new ArgumentException($"Cannot fit {fuel} fuel in the tank");
        }
        else if (fuel <= 0)
        {
            throw new ArgumentException("Fuel must be a positive number");
        }
        else
        {
            this.FuelQuantity += fuel*0.95;
        }
    }

}

