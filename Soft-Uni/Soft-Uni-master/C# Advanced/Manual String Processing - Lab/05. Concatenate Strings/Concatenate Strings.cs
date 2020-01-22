using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Concatenate_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfRows = int.Parse(Console.ReadLine());
            var result = new StringBuilder(numberOfRows);
            for (int i = 0; i < numberOfRows; i++)
            {
                var input = Console.ReadLine();
                result.Append(input+" ");
            }
            Console.WriteLine(result.ToString());
        }
    }
}
