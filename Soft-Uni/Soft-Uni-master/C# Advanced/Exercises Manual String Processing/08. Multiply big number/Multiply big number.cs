using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Multiply_big_number
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder number = new StringBuilder(Console.ReadLine().TrimStart('0'));
            int multiplier = int.Parse(Console.ReadLine());
            StringBuilder result = new StringBuilder();
            int remainder = 0;

            for (int i = number.Length - 1; i >= 0; i--)
            {
                int currentNumber = Convert.ToInt32(number[i])-48;
                if (currentNumber==48)
                {
                    currentNumber = 0;
                }
                int currentResult = (currentNumber*multiplier)+remainder;
                if (currentResult<10)
                {
                    result.Insert(0, currentResult);
                    remainder = 0;
                }
                else if (currentResult>=10)
                {
                    result.Insert(0, currentResult%10);
                    remainder = currentResult / 10;
                }
                

            }
            if (remainder>0)
            {
                result.Insert(0, remainder);
            }
            if (multiplier==0)
            {
                Console.WriteLine(0);
            }
            else if (number.ToString()=="0")
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine(result.ToString());
            }
            
        }
    }
}
