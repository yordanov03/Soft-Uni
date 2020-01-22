using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Fibonacci_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            FibonacciNumbers(input);

        }

        private static void FibonacciNumbers(int input)
        {
            int fib0 = 1;
            int fib1 = 1;
            int fib2 = fib0 + fib1;

            if (input ==0 || input==1)
            {
                Console.WriteLine(1);
                
            }
            else
            {
                for (int i = 3; i <= input; i++)
                {
                    fib0 = fib1;
                    fib1 = fib2;
                    fib2 = fib0 + fib1;
                }
                Console.WriteLine(fib2);
            }
            
           
            
        }
    }
}
