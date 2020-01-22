using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class ItemFactory
{
    public Item CreateItem(string[] args)
    {
        
        string typeOfItem = args[0];

        Item newlyCreatedItem = null;
        try
        {
            switch (typeOfItem)
            {
                case "ArmorRepairKit":
                    newlyCreatedItem = new ArmorRepairKit();
                    return newlyCreatedItem;
                case "HealthPotion":
                    newlyCreatedItem = new HealthPotion();
                    return newlyCreatedItem;
                case "PoisonPotion":
                    newlyCreatedItem = new PoisonPotion();
                    return newlyCreatedItem;
                default: throw new ArgumentException($"Invalid item \"{typeOfItem}\"!");

            }
        }
        catch (InvalidOperationException oe) { 
            throw new InvalidOperationException(oe.Message);
        }
    }
}

