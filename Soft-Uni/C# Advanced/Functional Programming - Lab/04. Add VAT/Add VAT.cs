using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Add_VAT
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).Select(n => n * 1.2).ToList();
            input.ForEach(n => Console.WriteLine($"{n:n2}"));


        }
    }
}
