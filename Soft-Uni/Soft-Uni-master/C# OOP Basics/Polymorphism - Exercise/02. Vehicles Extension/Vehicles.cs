using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public abstract class Vehicles
{
    private double fuelQuantity;
    private double fuelConsumption;
    private double tankCapacity;
    public double overConsumption;
    public Vehicles(double fuelQuantity, double fuelConsumption, double tankCapacity)
    {
        this.FuelQuantity = fuelQuantity;
        this.FuelConsumption = fuelConsumption;
        this.TankCapacity = tankCapacity;
        overConsumption = 0;
    }

    public double FuelQuantity
    {
        get { return this.fuelQuantity; }
        set { this.fuelQuantity = value; }
    }
    public double FuelConsumption
    {
        get { return this.fuelConsumption; }
        set { this.fuelConsumption = value; }
    }
    public double TankCapacity
    {
        get { return this.tankCapacity; }
        set
        {




            if (value < this.fuelQuantity)
            {
                this.fuelQuantity = 0;

            }

            this.tankCapacity = value;

        }
    }
    public virtual void Refuel(double fuel)
    {
        if (fuel > tankCapacity - fuelQuantity)
        {
            throw new ArgumentException($"Cannot fit {fuel} fuel in the tank");
        }
        else if (fuel <= 0)
        {
            throw new ArgumentException("Fuel must be a positive number");
        }
        else
        {
            this.fuelQuantity += fuel;
        }
    }
    public virtual void Drive(double distance)
    {
        if ((distance * this.FuelConsumption) + (distance * overConsumption) <= FuelQuantity)
        {
            FuelQuantity -= (distance * this.FuelConsumption) + (distance * overConsumption);
            Console.WriteLine($"{this.GetType()} travelled {distance} km");
        }
        else
        {
            Console.WriteLine($"{this.GetType()} needs refueling");
        }
    }

}

