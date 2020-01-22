using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class ProductFactory
{
    public Product CreateProduct(string type, double price)
    {
        Product newlyCreatedProduct = null;
        
        switch (type)
        {
            case "Gpu":
                newlyCreatedProduct = new Gpu(price);
                break;
            case "HardDrive":
                newlyCreatedProduct = new HardDrive(price);
                break;
            case "Ram":
                newlyCreatedProduct = new Ram(price);
                break;
            case "SolidStateDrive":
                newlyCreatedProduct = new SolidStateDrive(price);
                break;
            default:
                throw new InvalidOperationException($"Invalid product type!");
        }
        return newlyCreatedProduct;
    }
}

