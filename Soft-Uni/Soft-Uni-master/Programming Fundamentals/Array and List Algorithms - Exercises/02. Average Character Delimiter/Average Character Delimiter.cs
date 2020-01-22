using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Average_Character_Delimiter
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().ToList();
            int count = 0;
            int sum = 0;
            for (int i = 0; i < input.Count; i++)
            {
                if (input[i]!=32)
                {
                    sum += input[i];
                    count++;
                }
            }

            double average = sum / count;

            if (average>97 && average<122)
            {
                average -= 32;
            }
            char letter = (char)average;
            

            for (int i = 0; i < input.Count; i++)
            {
                if (input[i]==' ')
                {
                    input.Insert(i, letter);
                    input.Remove(input[i + 1]);
                }
            }
            Console.WriteLine(string.Join("",input));
        }
    }
}
