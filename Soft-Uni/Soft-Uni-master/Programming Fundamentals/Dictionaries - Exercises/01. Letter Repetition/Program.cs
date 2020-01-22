using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Letter_Repetition
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().ToCharArray();
            var results = new Dictionary<char, int>();

            foreach (var item in input)
            {
                if (!results.ContainsKey(item))
                {
                    results.Add(item, 0);
                }
                results[item]++;
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
