using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Master_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());



            for (int i = 1; i <= number; i++)
            {
                bool isPalindrome = IsPalindrome(i);
                bool sumOfDigits = SumOfDigits(i);
                bool evenDigit = ContainsEvenDigit(i);
                if (isPalindrome == true && sumOfDigits == true && evenDigit == true)
                {
                    Console.WriteLine(i);
                }
            }


        


        }

        private static bool ContainsEvenDigit(int number)
        {
            string numberString = number.ToString();
            
            for (int i = 0; i < numberString.Length; i++)
            {
                if (numberString[i]%2==0)
                {
                    return true;
                }
            }
            return false;
           
        }

        private static bool SumOfDigits(int number)
        {
            int alldigits = 0;
            while (number>0)
            {
                alldigits += number % 10;
                number = number / 10;
                
            }
            
            bool dividedBy7 = alldigits % 7 == 0;
            return dividedBy7;
        }

        private static bool IsPalindrome(int number)
        {
            string numberString = number.ToString();
            bool palindrome = true;
            for (int i = 0; i <= numberString.Length / 2; i++)
            {
                if (numberString[i] == numberString[numberString.Length - 1 - i])
                {
                    
                }
                else
                {
                    return false;
                }
                
            }
            return palindrome;
        }
    }
}
