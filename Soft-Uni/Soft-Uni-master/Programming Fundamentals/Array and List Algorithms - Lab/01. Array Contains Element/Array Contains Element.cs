using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Array_Contains_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int check = int.Parse(Console.ReadLine());
            bool contains = false;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == check)
                {
                    Console.WriteLine("yes");
                    contains = true;
                }
            }

            if (contains == false)
            {
                Console.WriteLine("no");
            }
        }
    }
}
