using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Exam_Shopping
{
    class Program
    {
        static void Main(string[] args)
        {
            var line = Console.ReadLine();
            var stock = new Dictionary<string, int>();
            var doesNotExist = new List<string>();
           
            while (line!="shopping time")
            {
                var split = line.Split();
                var product = split[1];
                var quantity = 0;
                int.TryParse(split[2], out quantity);
                if (!stock.ContainsKey(product))
                {
                    stock.Add(product, 0);
                }
                stock[product] += quantity;
                line = Console.ReadLine();
            }

            line = Console.ReadLine();

            while (line!="exam time")
            {
                var split = line.Split();
                var product = split[1];
                var quantity = 0;
                int.TryParse(split[2], out quantity);

                if (!stock.ContainsKey(product))
                {
                    Console.WriteLine($"{product} doesn't exist");
                }

                else if (stock[product]<=0)
                {
                    Console.WriteLine($"{product} out of stock");
                }
                else if (stock[product] <quantity)
                {
                    stock[product] = 0;
                }
                else
                {
                    stock[product] -= quantity;
                }

                line = Console.ReadLine();
            }

            foreach (var item in stock)
            {
                if (item.Value>0)
                {
                    Console.WriteLine($"{item.Key} -> {item.Value}");
                }


            }
        }
    }
}

