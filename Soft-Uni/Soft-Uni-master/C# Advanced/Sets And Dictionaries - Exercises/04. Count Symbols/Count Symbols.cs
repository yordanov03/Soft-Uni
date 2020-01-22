using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Count_Symbols
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().ToCharArray();
            var symbols = new SortedDictionary<char, int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (!symbols.ContainsKey(input[i]))
                {
                    symbols[input[i]] = 1;
                }
                else
                {
                    symbols[input[i]]++;
                }
            }

            foreach (var item in symbols)
            {
                Console.WriteLine($"{item.Key}: {item.Value} time/s");
            }
        }
    }
}
