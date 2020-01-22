using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Bounded_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var range = Console.ReadLine().Split(' ').Select(int.Parse).OrderBy(n=>n).ToList();
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            Console.WriteLine(string.Join(" ", input.Where(n => n >= range[0] && n <= range[1])));

            
        }
    }
}
