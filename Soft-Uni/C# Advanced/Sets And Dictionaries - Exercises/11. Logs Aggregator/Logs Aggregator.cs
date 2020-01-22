using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Logs_Aggregator
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberOfLines = int.Parse(Console.ReadLine());
            var data = new SortedDictionary<string, SortedDictionary<string, int>>();

            for (int i = 0; i < numberOfLines; i++)
            {
                var input = Console.ReadLine().Split().ToList();
                var IP = input[0];
                var userName = input[1];
                int timeSpent = int.Parse(input[2]);

                if (!data.ContainsKey(userName))
                {
                    data[userName] = new SortedDictionary<string, int>();
                    data[userName].Add(IP, timeSpent);
                }
                else if (data[userName].ContainsKey(IP))
                {
                    data[userName][IP] += timeSpent;
                }
                else
                {
                    data[userName].Add(IP, timeSpent);
                }

            }

            foreach (var item in data)
            {
                Console.WriteLine($"{item.Key}: {item.Value.Values.Sum()} " + "[{0}]", string.Join(", ", item.Value.Keys));
                
            }
        }
    }
}
