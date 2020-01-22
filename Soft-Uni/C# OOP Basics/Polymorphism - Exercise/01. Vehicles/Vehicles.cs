using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public abstract class Vehicles
    {
    

    public Vehicles(double fuelQuantity, double fuelConsumption)
    {
        this.FuelQuantity = fuelQuantity;
        this.FuelConsumption = fuelConsumption;
       
    }
    public double FuelQuantity { get; set; }
    public double FuelConsumption { get; set; }

    public  abstract void Drive(double distance);
    public abstract double Refuel(double fuel);
    
    }

