using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class TyreFactory
{
    public Tyre CreateTyre(List<string> commandArgs)
    {
        Tyre newTyre = null;
        try
        {
            switch (commandArgs[0])
            {
                case "Hard":
                    newTyre = new HardTyre(double.Parse(commandArgs[1]));
                    break;
                case "Ultrasoft":
                    newTyre = new UltrasoftTyre(double.Parse(commandArgs[1]), double.Parse(commandArgs[2]));
                    break;
                default:
                    break;
            }
        }
        catch (Exception)
        {

            
        }
        return newTyre;
    }
}

