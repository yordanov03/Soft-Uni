using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



    class Program
    {
        static void Main(string[] args)
        {
        var command = Console.ReadLine();
        var priceCalculator = new PriceCalculator(command);
        var totalPrice = priceCalculator.CalculatePrice();
        Console.WriteLine(totalPrice);
        }
    }

