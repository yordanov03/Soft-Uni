﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Unique_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfInput = int.Parse(Console.ReadLine());
            var names = new HashSet<string>();

            for (int i = 0; i < numberOfInput; i++)
            {
                var input = Console.ReadLine();
                names.Add(input);
            }

            foreach (var item in names)
            {
                Console.WriteLine(item);
            }
        }
    }
}
