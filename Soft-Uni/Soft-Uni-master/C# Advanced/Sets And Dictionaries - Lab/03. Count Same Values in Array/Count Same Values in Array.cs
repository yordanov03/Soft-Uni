using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Count_Same_Values_in_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToList();
            var numbers = new SortedDictionary<double, int>();

            foreach (var inputItem in input)
            {
                if (!numbers.Keys.Contains(inputItem))
                {
                    numbers.Add(inputItem, 1);
                }
                else
                {
                    numbers[inputItem]++;
                }
            }

            foreach (var number in numbers)
            {
                Console.WriteLine($"{number.Key} - {number.Value} times");
            }
        }
    }
}
