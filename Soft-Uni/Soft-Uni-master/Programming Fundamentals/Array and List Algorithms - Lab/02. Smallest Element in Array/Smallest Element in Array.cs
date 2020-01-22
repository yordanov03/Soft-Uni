using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Smallest_Element_in_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int smallestNumber = int.MaxValue;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i]<smallestNumber)
                {
                    smallestNumber = input[i];
                }
            }

            Console.WriteLine(smallestNumber);
        }
    }
}
