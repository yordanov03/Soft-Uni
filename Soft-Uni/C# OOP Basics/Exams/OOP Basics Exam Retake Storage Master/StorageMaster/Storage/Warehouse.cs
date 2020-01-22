using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class Warehouse:Storage
    {
    private static readonly Vehicle[] DefaultVehicles = { new Semi(10), new Semi(10), new Semi(10) };

    public Warehouse(string name) : base(name, 10, 10, DefaultVehicles) { }
    }

