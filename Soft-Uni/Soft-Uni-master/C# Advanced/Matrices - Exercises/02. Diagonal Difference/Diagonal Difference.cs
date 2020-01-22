using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Diagonal_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int[][] cube = new int[size][];
            int index = 0;

            int sum1 = 0;
            int sum2 = 0;

            for (int i = 0; i < size; i++)
            {
                var input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
                cube[i] = new int[size];
                for (int j = 0; j < size; j++)
                {
                    
                    cube[i][j] = input[j];
                }
            }

            for (int i = 0; i < size; i++)
            {
                sum1 += cube[i][i];
            }

            for (int i = size - 1; i >= 0; i--)
            {
                
                    sum2 += cube[i][index];
                index++;
                
            }

            var totalSum = Math.Abs(sum1 - sum2);
            Console.WriteLine(totalSum);
        }
    }
}
