using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class ProviderFactory
    {
    public Provider CreateProvider(List<string> arguments)
    {
        switch (arguments[0])
        {
            case"Pressure":
                return new PressureProvider(arguments[1], double.Parse(arguments[2]));
            case "Solar":
                return new SolarProvider(arguments[1], double.Parse(arguments[2]));
            default: throw new ArgumentException();
                
        }
    }
    }

