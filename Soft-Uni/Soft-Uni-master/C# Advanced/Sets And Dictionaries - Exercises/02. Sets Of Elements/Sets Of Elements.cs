using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Sets_Of_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            var firstNumber = input[0];
            var secondNUmber = input[1];
            var firstNumberNumbers = new List<double>();
            var secondNumberNumbers = new List<double>();
            var results = new List<double>();

            for (int i = 0; i < firstNumber; i++)
            {
                var numbersInput = double.Parse(Console.ReadLine());
                firstNumberNumbers.Add(numbersInput);
            }
            for (int i = 0; i < secondNUmber; i++)
            {
                var numbersInput = double.Parse(Console.ReadLine());
                secondNumberNumbers.Add(numbersInput);
            }

            foreach (var firstNumber0 in firstNumberNumbers)
            {
                foreach (var secondNumber0 in secondNumberNumbers)
                {
                    if (firstNumber0==secondNumber0)
                    {
                        results.Add(firstNumber0);
                    }
                }
            }

            foreach (var item in results)
            {
                Console.Write(item+" ");
            }
        }
    }
}
