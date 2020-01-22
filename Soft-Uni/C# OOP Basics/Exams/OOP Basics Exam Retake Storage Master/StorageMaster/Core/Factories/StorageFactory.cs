using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class StorageFactory
{
    public Storage CreateStorage(string type, string name)
    {
        Storage newStorage = null;

        switch (type)
        {
            case "AutomatedWarehouse":
                newStorage = new AutomatedWarehouse(name);
                break;
            case "DistributionCenter":
                newStorage = new DistributionCenter(name);
                break;
            case "Warehouse":
                newStorage = new Warehouse(name);
                break;
            default: throw new InvalidOperationException("Invalid storage type!");
        }
        return newStorage;
    }
}

