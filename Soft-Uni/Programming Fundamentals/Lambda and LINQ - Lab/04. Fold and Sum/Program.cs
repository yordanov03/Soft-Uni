using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Fold_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            var k = numbers.Length / 4;

            var firstUpperRow = numbers.Take(k).Reverse().ToArray();
            var lastUpperRow = numbers.Reverse().Take(k).ToArray();
            var newRow = firstUpperRow.Concat(lastUpperRow).ToArray();
            var results = new int[newRow.Length];

            var newnumbers = numbers.Skip(k).Take(2 * k).ToArray();

            for (int i = 0; i < newnumbers.Length; i++)
            {
                results[i] = newnumbers[i] + newRow[i];
            }

            Console.WriteLine(string.Join(" ", results));
        }
    }
}
