﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Hello__Name_
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            Name(name);
        }

        private static void Name(string name)
        {
            Console.WriteLine("Hello, {0}!", name);
        }
    }
}
