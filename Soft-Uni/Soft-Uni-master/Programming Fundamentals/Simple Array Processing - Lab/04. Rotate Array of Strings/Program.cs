using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Rotate_Array_of_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').ToArray();
            string[] result = new string[input.Length];
            result[0] = input[input.Length-1];

            for (int i = 1; i < input.Length; i++)
            {
                result[i] = input[i - 1];
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
