using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Find_and_Sum_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').ToList();
            List <int> numbers = new List<int>();

            for (int i = 0; i < input.Count; i++)
            {
                var number = 0;
                var current = Int32.TryParse(input[i], out number);
                if (number!=0)
                {
                    numbers.Add(number);
                }
            }

            Console.WriteLine((numbers.Count==0 ? "No match" : $"{numbers.Sum()}"));
        }
    }
}
