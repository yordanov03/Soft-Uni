using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Matrix_of_Palindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(byte.Parse).ToList();
            byte row = input[0];
            byte column = input[1];
            char[] alphabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
            int index = 0;
            

            for (int i = 0; i < row; i++)
            {
                index = i;
                for (int j = 0; j < column; j++)
                {
                    var firstLetter = alphabet[i];
                    var secondLetter = alphabet[index];
                    var thirdLetter = alphabet[i];
                    Console.Write($"{firstLetter}{secondLetter}{thirdLetter} ");
                    index++;
                }
                index = 0;
                Console.WriteLine();
                
            }
        }
    }
}
