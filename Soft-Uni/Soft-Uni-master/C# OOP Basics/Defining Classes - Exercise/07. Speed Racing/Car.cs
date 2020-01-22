using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class Car
    {
    public string model;
    public double fuelAmount;
    public double fuelConsumption;
    public double distanceTraveled;

    public Car(string model, double fuelAmount, double fuelConsumption)
    {
        this.model = model;
        this.fuelAmount = fuelAmount;
        this.fuelConsumption = fuelConsumption;
        this.distanceTraveled = 0;
    }

    public void DriveCar(double kilometers)
    {
        var neededFuel = kilometers * fuelConsumption;
        if (neededFuel<=fuelAmount)
        {
            this.fuelAmount -= neededFuel;
            this.distanceTraveled += kilometers;
        }
        else
        {
            Console.WriteLine("Insufficient fuel for the drive");
        }
    }
    
}

