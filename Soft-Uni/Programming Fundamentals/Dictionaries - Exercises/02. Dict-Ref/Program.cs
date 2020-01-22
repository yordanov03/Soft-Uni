using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Dict_Ref
{
    class Program
    {
        static void Main(string[] args)
        {
            var line = Console.ReadLine();
            var result = new Dictionary<string, int>();

            while (line!="end")
            {
                var tokens = line.Split();
                var fistElement = tokens[0];
                var lastElement = tokens[tokens.Length - 1];

                var number = 0;
                if (int.TryParse(lastElement, out number))
                {
                    result[fistElement] = number;
                }

                else
                {
                    if (result.ContainsKey(lastElement))
                    {
                        result[fistElement] = result[lastElement];
                    }
                }
                line = Console.ReadLine();
            }

            foreach (var item in result)
            {
                var key = item.Key;
                var value = item.Value;
                Console.WriteLine($"{key} === {value}");
            }
        }
    }
}
