using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Camel_s_Back
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int camelsBack = int.Parse(Console.ReadLine());
            int count = 0;

            if (input.Count>camelsBack)
            {
                for (int i = 0; input.Count != camelsBack; i++)
                {
                    input.Remove(input[input.Count - 1]);
                    input.Remove(input[i]);
                    count++;
                    i--;
                }
                Console.WriteLine($"{count} rounds");
                Console.WriteLine("remaining: {0}",string.Join(" ", input));
            }

            else if (input.Count == camelsBack)
            {
                Console.WriteLine("already stable: {0}", string.Join(" ", input));
            }
        }
    }
}
