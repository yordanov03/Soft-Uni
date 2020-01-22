using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Odd_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {

            var words = Console.ReadLine().ToLower().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var results = new Dictionary<string, int>();

            foreach (var item in words)
            {

                if (!results.ContainsKey(item))
                {
                    results.Add(item, 0);
                }
                results[item]++;
            }

            var oddNumberWords = new List<string>();

            foreach (var item in results)
            {
                var value = item.Value;

                if (value%2!=0)
                {
                    oddNumberWords.Add(item.Key);
                }
            }

            Console.WriteLine(string.Join(", ", oddNumberWords));
        }
    }
}
