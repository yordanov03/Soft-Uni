using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Count_Substring_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().ToLower();
            var toBeFound = Console.ReadLine().ToLower();
            int startIndex = input.IndexOf(toBeFound);
            int count = 0;
     
            while (startIndex>=0)
            {
                count++;
                startIndex = input.IndexOf(toBeFound, startIndex + 1);
            }

            Console.WriteLine(count);
        }
    }
}
