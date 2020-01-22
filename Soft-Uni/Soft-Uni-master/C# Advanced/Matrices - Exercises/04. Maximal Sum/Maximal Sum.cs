using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Maximal_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var sizes = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            var row = sizes[0];
            var col = sizes[1];
            int[][] matrix = new int[row][];
            int totalSum = int.MinValue;
            int currentSum = int.MinValue;
            int[][] resultMatrix = new int[3][];


            for (int i = 0; i < row; i++)
            {
                var inputNumbers = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
                matrix[i] = new int[col];
                for (int j = 0; j < col; j++)
                {
                    matrix[i][j] = inputNumbers[j];
                }
            }

            for (int i = 0; i < row - 2; i++)
            {
                for (int j = 0; j < col - 2; j++)
                {
                    currentSum = (matrix[i][j] + matrix[i][j + 1] + matrix[i][j + 2]) + (matrix[i + 1][j] + matrix[i + 1][j + 1] + matrix[i + 1][j + 2]) + (matrix[i + 2][j] + matrix[i + 2][j + 1] + matrix[i + 2][j + 2]);
                    if (currentSum > totalSum)
                    {
                        totalSum = currentSum;
                        resultMatrix[0] = new int[3] { matrix[i][j], matrix[i][j + 1], matrix[i][j + 2] };
                        resultMatrix[1] = new int[3] { matrix[i + 1][j], matrix[i + 1][j + 1], matrix[i + 1][j + 2] };
                        resultMatrix[2] = new int[3] { matrix[i + 2][j], matrix[i + 2][j + 1], matrix[i + 2][j + 2] };

                    }
                }
            }

            Console.WriteLine($"Sum = {totalSum}");
            foreach (var row1 in resultMatrix)
            {
                Console.WriteLine(string.Join(" ", row1));
            }
        }
    }
}
04. Maximal Sum