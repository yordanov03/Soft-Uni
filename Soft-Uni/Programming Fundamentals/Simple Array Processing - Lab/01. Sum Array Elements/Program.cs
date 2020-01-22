using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Sum_Array_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int lenghtOfArray = int.Parse(Console.ReadLine());
            int sum = 0;

            int[] numbers = new int[lenghtOfArray];

            for (int i = 0; i < numbers.Length; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                numbers[i] = currentNumber;
                sum += currentNumber;
            }

            Console.WriteLine(sum);
        }
    }
}
