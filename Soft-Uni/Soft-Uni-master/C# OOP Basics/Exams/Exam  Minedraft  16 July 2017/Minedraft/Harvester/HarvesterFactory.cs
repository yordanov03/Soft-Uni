using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class HarvesterFactory
{
    public Harvester CreateHarvester(List<string> arguments)
    {
        switch (arguments[0])
        {
            case "Hammer":
                return new HammerHarvester(arguments[1], double.Parse(arguments[2]), double.Parse(arguments[3]));
            case "Sonic":
                return new SonicHarvester(arguments[1], double.Parse(arguments[2]), double.Parse(arguments[3]), int.Parse(arguments[4]));
            default: throw new ArgumentException();

        }
    }
}

