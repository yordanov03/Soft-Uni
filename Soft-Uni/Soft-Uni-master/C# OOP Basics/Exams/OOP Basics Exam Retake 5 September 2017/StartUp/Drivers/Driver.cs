using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public abstract class Driver
{

    public Driver(string name, Car car, double fuelConsumptionPerKm)
    {
        this.Name = name;
        this.TotalTime = 0d;
        this.Car = car;
        this.FuelConsumptionPerKm = fuelConsumptionPerKm;
        this.FailureReason = null;
    }
    public string Name { get; private set; }
    public double TotalTime { get; set; }
    
    public Car Car { get; set; }
    public double FuelConsumptionPerKm { get; set; }
    public virtual double Speed => (this.Car.HP + this.Car.Tyre.Degradation) / this.Car.FuelAmount;
    public string FailureReason { get; set; }

    private void Box()
    {
        this.TotalTime += 20;
    }

    internal void Refuel(string[] methodArgs)
    {
        this.Box();

        double fuelAmount = double.Parse(methodArgs[0]);

        this.Car.Refuel(fuelAmount);
    }

    internal void ChangeTyres(Tyre tyre)
    {
        this.Box();

        this.Car.ChangeTyres(tyre);
    }
    internal void CompleteLap(int trackLength)
    {
        this.TotalTime += 60 / (trackLength / this.Speed);

        this.Car.CompleteLap(trackLength, this.FuelConsumptionPerKm);
    }

}

