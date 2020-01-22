using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Sum_Adjacent_Equal_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            

            for (int i = 1; i < input.Count;)
            {
                if (input[i] == input[i-1])
                {
                    input[i] = input[i] + input[i - 1];
                    input.Remove(input[i-1]);
                    i = 1;
                }
                else
                {
                    i++;
                }
            }

            for (int i = 0; i < input.Count; i++)
            {
                Console.Write("{0} ", input[i]);
            }
        }
    }
}
