using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Custom_Min_Function
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).OrderBy(n=>n).ToArray();
            Func<int[], int> HoldNumbers = ListNumbers;

            var minNumber = HoldNumbers(input);
            Console.WriteLine(minNumber);
            
            
        }

        private static int ListNumbers(int[] numbers)
        {
            return numbers[0];
        }
    }
}
