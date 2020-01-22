using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Mixed_Phones
{
    class Program
    {
        static void Main(string[] args)
        {
            var line = Console.ReadLine().Trim();
            var results = new SortedDictionary<string, long>();

            while (line!="Over")
            {
                var split = line.Split(new char[] {' ', ':'}, StringSplitOptions.RemoveEmptyEntries);
                var name = split[0];
                var number = split[split.Length - 1];

                var telNumber = 0L;

                if (long.TryParse(number, out telNumber))
                {
                    results[name] = telNumber;
                }

                else
                {
                    var temp = name;
                    name = number;
                    number = temp;
                    long.TryParse(number, out telNumber);
                    results[name] = telNumber;
                }
                line = Console.ReadLine();
            }

            foreach (var item in results)
            {
                var key = item.Key;
                var value = item.Value;
                Console.WriteLine($"{key} -> {value}");
            }
        }
    }
}
