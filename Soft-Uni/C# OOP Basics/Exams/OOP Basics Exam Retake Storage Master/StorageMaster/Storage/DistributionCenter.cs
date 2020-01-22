using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class DistributionCenter : Storage
{
    private static readonly Vehicle[] DefaultVehicles =
       {
            new Van(3), new Van(3), new Van(3)
        };
    public DistributionCenter(string name) : base(name, 2, 5, DefaultVehicles)
    {

    }
}

