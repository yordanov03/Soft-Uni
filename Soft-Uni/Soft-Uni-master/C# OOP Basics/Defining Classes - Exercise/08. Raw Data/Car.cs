using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class Car
    {
    public string model;
    public Engine engine;
    public Cargo cargo;
    public Tire tires;

    public Car(string Model, Engine Engine, Cargo Cargo, Tire Tire)
    {
        this.model = Model;
        this.engine = Engine;
        this.cargo = Cargo;
        this.tires = Tire;
    }
    }

