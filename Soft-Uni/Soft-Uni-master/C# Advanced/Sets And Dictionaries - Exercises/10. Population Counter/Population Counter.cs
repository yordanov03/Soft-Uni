using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Population_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var data = new Dictionary<string, Dictionary<string, long>>();
            ulong count = 0;

            while (input!="report")
            {
                var separated = input.Split('|').ToList();
                var city = separated[0];
                var country = separated[1];
                long population = long.Parse(separated[2]);

                if (!data.ContainsKey(country))
                {
                    data[country] = new Dictionary<string, long>();
                    data[country].Add(city, population);
                }
                else
                {
                    data[country].Add(city, population);
                }
                input = Console.ReadLine();
            }

            foreach (var item in data.OrderByDescending(a=>a.Value.Values.Sum()))
            {
                Console.WriteLine($"{item.Key} (total population: {item.Value.Values.Sum()})");

                foreach (var item1 in item.Value.OrderByDescending(a=>a.Value))
                {
                    Console.WriteLine($"=>{item1.Key}: {item1.Value}");
                }
            }


        }
    }
}
