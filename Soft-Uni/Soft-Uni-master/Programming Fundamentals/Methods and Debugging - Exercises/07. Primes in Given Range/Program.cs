using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Primes_in_Given_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            int startingNumber = int.Parse(Console.ReadLine());
            int endingNumber = int.Parse(Console.ReadLine());

            List<int> primes = PrimesInRange(startingNumber, endingNumber);
            string primeNumbersFormatted = string.Join(", ", primes);
            Console.WriteLine(primeNumbersFormatted);

        }
        private static bool PrimeNumber(int n)
        {
            
            if (n == 0 || n == 1)
            {
                return false;
            }
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        private static List<int> PrimesInRange(int startingNumber, int endingNumber)
        {
            List<int> primeNumbers = new List<int>();
            for (int i = startingNumber; i <= endingNumber; i++)
            {
                if (PrimeNumber(i) == true)
                {
                    primeNumbers.Add(i);
                }
                
            }
            return primeNumbers;
        }
    }
}
