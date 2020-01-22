using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class Seat:ICar
    {
    public Seat(string model, string color)
    {
        this.Model = model;
        this.Color = color;
    }
    public string Model
    {
        get;set;
    }
    public string Color
    {
        get;set;
    }
    public void Start()
    {
        Console.WriteLine("Engine start");
    }
    public void Stop()
    {
        Console.WriteLine("Breaaak!");
    }

    public override string ToString()
    {
        return $"{this.Color} Seat {this.Model}";
            
    }
}

