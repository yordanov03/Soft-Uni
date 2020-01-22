using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _14.Factorial_Trailing_Zeroes
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            BigInteger factorial = 1;
            factorial = NewMethod(input, factorial);
            int countingZeros = 0;

            while (factorial%10==0)
            {
                countingZeros++;
                factorial = factorial / 10;
            }
            Console.WriteLine(countingZeros);
            
        }
        private static BigInteger NewMethod(int input, BigInteger factorial)
        {
            for (int i = 1; i <= input; i++)
            {
                factorial = factorial * i;
            }

            return factorial;
        }
    }
}
