﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Reverse_Array_In_place
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            
           

            for (int i = 0; i < input.Length/2; i++)
            {
                var temp = input[i];
                input[i] = input[input.Length - 1 - i];
                input[input.Length - 1 - i] = temp;
            }

            Console.WriteLine(string.Join(" ", input));
        }
    }
}
