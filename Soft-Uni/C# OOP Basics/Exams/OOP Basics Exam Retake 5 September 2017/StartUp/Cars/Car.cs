using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Car
{
    private double fuelAmount;

    public Car(int hp, double fuelAmount, Tyre tyre)
    {
        this.HP = hp;
        this.FuelAmount = fuelAmount;
        this.Tyre = tyre;

    }
    public int HP { get; set; }
    public double FuelAmount
    {
        get { return this.fuelAmount; }
        set
        {
            if (value > 160)
            {
                value = 160;
            }
            this.fuelAmount = value;
        }
    }
    public Tyre Tyre { get; set; }

    internal void Refuel(double fuelAmount)
    {
        this.FuelAmount += fuelAmount;
    }

    internal void ChangeTyres(Tyre tyre)
    {
        this.Tyre = tyre;
    }

    internal void CompleteLap(int trackLength, double fuelConsumption)
    {
        this.FuelAmount -= trackLength * fuelConsumption;

        this.Tyre.CompleteLap();
    }
}

