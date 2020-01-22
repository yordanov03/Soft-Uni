using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Remove_Negatives_and_Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            input.Reverse();

            for (int i = 0; i < input.Count; i++)
            {
                if (input[i]<0)
                {
                    input.Remove(input[i]);
                    i--;
                }
            }
            if (input.Count == 0)
            {
                Console.WriteLine("empty");
            }
            else
            {

            Console.WriteLine(string.Join(" ", input));

            }
        }
    }
}
