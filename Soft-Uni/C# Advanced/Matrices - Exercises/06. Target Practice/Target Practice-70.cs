using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Target_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            var dimensions = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int rows = dimensions[0];
            int cols = dimensions[1];
            var text = Console.ReadLine().ToCharArray();
            var coordinates = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int coordinatesRow = coordinates[0];
            int coordinatesCol = coordinates[1];
            int radius = coordinates[2];
            int indexOfFil = 0;
            int indexOfRows = 0;

            char[][] rectangle = new char[rows][];


            while (indexOfRows < rows)
            {
                if (indexOfRows % 2 == 0)
                {
                    rectangle[rows - indexOfRows - 1] = new char[cols];
                    for (int i = cols - 1; i >= 0; i--)
                    {
                        if (indexOfFil > text.Length - 1)
                        {
                            indexOfFil = 0;
                        }
                        rectangle[rows - indexOfRows - 1][i] = text[indexOfFil];
                        indexOfFil++;
                    }
                }
                else
                {
                    rectangle[rows - indexOfRows - 1] = new char[cols];
                    for (int i = 0; i <= cols - 1; i++)
                    {
                        if (indexOfFil > text.Length - 1)
                        {
                            indexOfFil = 0;
                        }
                        rectangle[rows - indexOfRows - 1][i] = text[indexOfFil];
                        indexOfFil++;
                    }
                }
                indexOfRows++;
            }

            rectangle[coordinatesRow][coordinatesCol] = ' ';

            for (int i = 1; i <= radius; i++)
            {
                    if (coordinatesCol + i < cols)
                    {
                        rectangle[coordinatesRow][coordinatesCol + i] = ' ';
                    }
                    if (coordinatesRow + i < rows)
                    {
                        rectangle[coordinatesRow + i][coordinatesCol] = ' ';
                    }
                    if (coordinatesRow - i >= 0)
                    {
                        rectangle[coordinatesRow - i][coordinatesCol] = ' ';
                    }
                    if (coordinatesCol - i >= 0)
                    {
                        rectangle[coordinatesRow][coordinatesCol - i] = ' ';
                    }
            }

            for (int i = 1; i < radius; i++)
            {
                for (int j = 1; j <= radius - i; j++)
                {
                        if (coordinatesRow + i < rows  && coordinatesCol + j < cols)
                        {
                            rectangle[coordinatesRow + i][coordinatesCol + j] = ' ';
                        }
                        if ( coordinatesRow - i >= 0 && coordinatesCol + j < cols)
                        {
                            rectangle[coordinatesRow - i][coordinatesCol + j] = ' ';
                        }
                        if (coordinatesRow + i < rows && coordinatesCol - j >= 0)
                        {
                            rectangle[coordinatesRow + i][coordinatesCol - j] = ' ';
                        }
                        if (coordinatesRow - i >= 0 && coordinatesCol - j >= 0)
                        {
                            rectangle[coordinatesRow - i][coordinatesCol - j] = ' ';
                        }

                }

            }

            for (int i = rows - 1; i >= 0; i--)
            {
                for (int j = cols - 1; j >= 0; j--)
                {
                    if (rectangle[i][j] == ' ')
                    {
                        for (int k = i - 1; k >= 0; k--)
                        {
                            if (rectangle[k][j] != ' ')
                            {
                                char temp = ' ';
                                rectangle[i][j] = rectangle[k][j];
                                rectangle[k][j] = temp;
                                break;
                            }
                        }
                    }
                }
            }


            foreach (var row in rectangle)
            {
                Console.WriteLine(string.Join("", row));
            }
        }
    }
}
