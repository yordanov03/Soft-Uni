using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class DriverFactory
{
    public Driver CreateDriver(string typeOfDriver, string nameOfDriver, Car car)
    {
        Driver newDriver = null;

        switch (typeOfDriver)
        {
            case "Aggressive":
                newDriver = new AggressiveDriver(nameOfDriver, car);
                break;
            case "Endurance":
                newDriver = new EnduranceDriver(nameOfDriver, car);
                break;
            default:
                break;
        }
        return newDriver;
    }
}

