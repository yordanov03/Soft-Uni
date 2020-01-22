using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Take_Two
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).Distinct().Where(x => x >= 10 && x <= 20).Take(2).ToList();
            foreach (var item in input)
            {
                Console.WriteLine(item);
            }
        }
    }
}
