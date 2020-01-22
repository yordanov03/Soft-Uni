using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class Ferrari:ICar
    {
    public Ferrari(string model)
    {
        this.Model = model;
    }
    public string Model { get; set; }

    public void Brakes()
    {
        Console.Write("/Brakes!/");
    }
    public void GasPedal()
    {
        Console.Write("Zadu6avam sA!/");
    }
    }

