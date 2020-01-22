using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.SquareWithMaximumSum
{
    class SquareWithMaximumSum
    {
        static void Main(string[] args)
        {
            var matrixSize = Console.ReadLine().Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            var rows = matrixSize[0];
            var cols = matrixSize[1];
            int[,] matrix = new int[rows, cols];

            for (int row = 0; row <matrix.GetLength(0) ; row++)
            {
                var inputRow = Console.ReadLine().Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
                for (int col = 0; col < inputRow.Count; col++)
                {
                    matrix[row, col] = inputRow[col];
                }

            }

            var maxSquareRow = 0;
            var maxSquareCol = 0;
            var sum = 0;

            for (int row = 0; row < rows-1; row++)
            {
                for (int col = 0; col < cols-1; col++)
                {
                    var currentSum = matrix[row, col] + matrix[row + 1, col] + matrix[row, col + 1] + matrix[row + 1, col + 1];

                    if (sum<currentSum)
                    {
                        sum = currentSum;
                        maxSquareCol = col;
                        maxSquareRow = row;
                    }
                }
            }
            Console.WriteLine($"{matrix[maxSquareRow,maxSquareCol]} {matrix[maxSquareRow,maxSquareCol+1]}\n{matrix[maxSquareRow+1,maxSquareCol]} {matrix[maxSquareRow+1,maxSquareCol+1]}\n{sum}");
        }
    }
}
