using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _03.Series_Of_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var result = Regex.Replace(input, @"([A-Za-z])\1+", "$1");
            Console.WriteLine(result);


        }
    }
}
