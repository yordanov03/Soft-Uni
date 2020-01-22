using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Count_Real_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            var results = new SortedDictionary<double, int>();

            foreach (var item in input)
            {
                if (!results.ContainsKey(item))
                {
                    results.Add(item,0);
                }
                results[item]++;
            }

            foreach (var item in results)
            {
                var key = item.Key;
                var value = item.Value;
                var timeString = item.Value == 1 ? "time" : "times"; 
                Console.WriteLine($"{key} -> {value} times");
            }
        }
    }
}
