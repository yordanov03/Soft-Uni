using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Periodic_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            var results = new HashSet<string>();

            for (int i = 0; i < number; i++)
            {
                var input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                for (int j = 0; j < input.Count; j++)
                {
                    results.Add(input[j]);
                }
            }

            var finalResults = new SortedSet<string>(results);
            foreach (var item in finalResults)
            {
                Console.Write(item+" ");
            }
        }
    }
}
