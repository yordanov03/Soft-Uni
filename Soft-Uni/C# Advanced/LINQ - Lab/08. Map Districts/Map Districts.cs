using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Map_Districts
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ',':').ToList();
            var all = new Dictionary<string, List<int>>();
            int requirement = int.Parse(Console.ReadLine());


            for (int i = 0; i < input.Count; i+=2)
            {
                if (!all.ContainsKey(input[i]))
                {
                    all[input[i]] = new List<int>();
                }
                all[input[i]].Add(int.Parse(input[i + 1]));
            }

            

            foreach (var item in all.Take(5).OrderByDescending(kvp=> kvp.Key))
            {
                if (item.Value.Sum()>=requirement)
                {
                        Console.WriteLine($"{item.Key} {string.Join(" ", item.Value.OrderByDescending(kvp=>kvp))}");
                }
            }
        }
    }
}
