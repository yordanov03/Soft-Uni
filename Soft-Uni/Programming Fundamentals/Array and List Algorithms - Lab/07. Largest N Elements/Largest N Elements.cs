using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Largest_N_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int condition = int.Parse(Console.ReadLine());
            input.Sort();
            input.Reverse();

            for (int i = 0; i < condition; i++)
            {
                Console.Write("{0} ", input[i]);
            }
        }
    }
}
