using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Sum_big_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] firstNumber = Console.ReadLine().Trim(new char[] { ' ', '\n', '\r', '\t' }).TrimStart('0').ToCharArray();
            char[] secondNumber = Console.ReadLine().Trim(new char[] { ' ', '\n', '\r', '\t' }).TrimStart('0').ToCharArray();
  
            StringBuilder numberI = new StringBuilder();
            StringBuilder numberII = new StringBuilder();
            StringBuilder result = new StringBuilder();
            int reminder = 0;

            int difference = Math.Abs(firstNumber.Length - secondNumber.Length);
            
            for (int i = 0; i < firstNumber.Length; i++)
            {
                numberI.Append(firstNumber[i]);
                
            }
            for (int i = 0; i < secondNumber.Length; i++)
            {
                numberII.Append(secondNumber[i]);
            }

            if (numberI.Length<numberII.Length)
            {
                for (int i = 0; i < difference; i++)
                {
                    numberI.Insert(0, "0");
                }
            }
            else if (numberII.Length<numberI.Length)
            {
                for (int i = 0; i < difference; i++)
                {
                    numberII.Insert(0, "0");
                }
            }

            for (int i = numberI.Length - 1; i >= 0; i--)
            {
                int number1 =Convert.ToInt16( numberI[i]-48);
                int number2 =Convert.ToInt16( numberII[i]-48);
                
                if (numberI[i]==48)
                {
                    number1 = 0;
                }
                else if (numberII[i] == 48)
                {
                    number2 = 0;
                }
                

                if (number1+number2+reminder<10)
                {
                    result.Insert(0, number1 + number2 + reminder);
                    reminder = 0;
               }
                else if (number1 + number2 + reminder >= 10)
                {
                    
                    result.Insert(0, (number1 + number2 + reminder) % 10);
                    reminder=1;
                }
                
            }
            if (reminder>0)
            {
                result.Insert(0, 1);
            }
            Console.WriteLine(result.ToString());
        }
    }
}
