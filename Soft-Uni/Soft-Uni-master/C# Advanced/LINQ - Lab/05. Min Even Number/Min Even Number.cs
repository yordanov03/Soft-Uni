using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Min_Even_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').Select(double.Parse).Where(n => n % 2 == 0).ToList();
            Console.WriteLine((input.Count==0 ? "No match" : $"{input.Min():F2}"));
        }
    }
}
