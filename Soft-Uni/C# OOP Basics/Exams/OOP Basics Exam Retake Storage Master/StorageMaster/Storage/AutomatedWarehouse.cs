using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class AutomatedWarehouse : Storage
{
    private static readonly Vehicle[] DefaultVehicles =
        {
            new Truck(5)
        };
    public AutomatedWarehouse(string name) : base(name, 1, 2, DefaultVehicles)
    {

    }
}

