using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Count_substring_occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().ToLower();
            var condition = Console.ReadLine().ToLower();

            var index = -1;
            var count = 0;

            while (true)
            {
                index = input.IndexOf(condition, index + 1);

                if (index<0)
                {
                    break;
                }

                count++;
            }

            Console.WriteLine(count);
        }
    }
}
