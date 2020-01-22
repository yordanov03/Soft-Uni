using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Multiply_an_Array_of_Doubles
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            double p = double.Parse(Console.ReadLine());

            for (int i = 0; i < input.Length; i++)
            {
                input[i] = input[i] * p;
                
            }
            Console.WriteLine(string.Join(" ", input));
            
        }
    }
}
