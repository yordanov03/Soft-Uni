using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Batteries
{
    class Program
    {
        static void Main(string[] args)
        {
            var capacity = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            var consumtion = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            double hours = double.Parse(Console.ReadLine());
            List<double> results = new List<double>();
            List<double> percentage = new List<double>();

            for (int i = 0; i < capacity.Count; i++)
            {
                results.Add(capacity[i] - (consumtion[i] * hours));
                if (results[i] < 0)
                {
                    results[i] = 0;
                }
            }

            for (int i = 0; i < results.Count; i++)
            {
                percentage.Add(Math.Round ((results[i] / capacity[i])*100,2));
            }

            List<string> newResults = new List<string>();
            for (int i = 0; i < results.Count; i++)
            {
                var temp = results[i].ToString();
                newResults.Add(temp);
            }
            int lastedBeforeDying = 0;

            for (
                int i = 0; i < results.Count; i++)
            {
                if (results[i]==0)
                {
                    lastedBeforeDying = ((int)capacity[i] / (int)consumtion[i])+1;
                    lastedBeforeDying.ToString();
                    newResults.Insert(i, $"dead (lasted {lastedBeforeDying} hours)");
                    newResults.Remove(newResults[i + 1]);
                    Console.WriteLine($"Battery {i+1}: {newResults[i]:f2}");
                    lastedBeforeDying = 0;
                }
                else
                {
                    Console.WriteLine($"Battery {i+1}: {results[i]:f2} mAh ({percentage[i]:f2})%");
                }
            }
        }
    }
}
