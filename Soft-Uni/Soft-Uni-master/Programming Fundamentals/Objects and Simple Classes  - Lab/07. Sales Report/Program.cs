using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Sales_Report
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var results = new SortedDictionary<string, decimal>();

            for (int i = 0; i < n; i++)
            {
                var input = ReadSale();

                if (!results.ContainsKey(input.town))
                {
                    results.Add(input.town, 0);
                }
                results[input.town] += input.quantity * input.price;
            }

            foreach (var item in results)
            {
                Console.WriteLine($"{item.Key} -> {item.Value:f2}");
            }
        }

        private static Sale ReadSale()
        {
            var input = Console.ReadLine().Split(' ').ToList();
            return new Sale { town = input[0], product = input[1], price = decimal.Parse(input[2]), quantity = decimal.Parse(input[3]) };
        }
    }
}
