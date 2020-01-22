using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Min__Max__Sum__Average
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>();
            int numberOfNumbers = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfNumbers; i++)
            {
                var line = int.Parse(Console.ReadLine());
                numbers.Add(line);
            }

            var sum = numbers.Sum();
            var min = numbers.Min();
            var max = numbers.Max();
            var average = numbers.Average();

            Console.WriteLine($"Sum = {sum}");
            Console.WriteLine($"Min = {min}");
            Console.WriteLine($"Max = {max}");
            Console.WriteLine($"Average = {average}");
        }
    }
}
