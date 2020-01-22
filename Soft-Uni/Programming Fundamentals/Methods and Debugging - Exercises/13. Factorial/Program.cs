using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _13.Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            BigInteger factorial = 1;
            factorial = NewMethod(input, factorial);
            Console.WriteLine(factorial);
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
