using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Prime_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());

            
            bool check = CheckPrime(n);
            Console.WriteLine(check);


        } 

        private static bool CheckPrime(long n)
        {
            bool IsPrime = false;
            for (int i = 2; i < n; i++)
            {
                if (n%i==0)
                {
                    return IsPrime;
                }
                
            }
            if (n == 0 || n == 1)
            {
                return IsPrime;
            }
            return IsPrime;
        }
    }
    
}
