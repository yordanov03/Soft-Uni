using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Squares_in_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            var row = input[0];
            var col = input[1];

            char[][] matrix = new char[row][];
            int count = 0;

            for (int i = 0; i < row; i++)
            {
                var inputs = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                
                matrix [i] = new char[col];
                for (int j = 0; j < col; j++)
                {
                    matrix[i][j] = Convert.ToChar(inputs[j]);
                }
            }

            for (int i = 0; i < row-1; i++)
            {
                for (int j = 0; j < col-1; j++)
                {
                    if (matrix[i][j]==matrix[i][j+1] && matrix[i + 1][j] == matrix[i + 1][j + 1]&& matrix[i][j]==matrix[i+1][j+1])
                    {
                            count++;
                    }
                }
            }

                Console.WriteLine(count);
            
        }
    }
}
