using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Sort_Array_Using_Insertion_Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            for (int i = 0; i < input.Length-1; i++)
            {
                var j = i + 1;

                while (j > 0)
                {
                    if (input[j]<input[j-1])
                    {
                        var temp = input[j];
                        input[j] = input[j - 1];
                        input[j - 1] = temp;
                    }
                    j--;
                }
            }

            Console.WriteLine(string.Join(" ", input));
        }
    }
}
