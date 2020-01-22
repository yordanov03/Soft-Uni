using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Radioactive_Bunnies
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> dimessions = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            char[][] lair = new char[dimessions[0]][];
            char[][] newLair = new char[dimessions[0]][];
            int humanRow = 0;
            int humanCol = 0;
            bool isAlive = true;
            bool isInside = true;

            for (int i = 0; i < dimessions[0]; i++)
            {
                lair[i] = Console.ReadLine().ToCharArray();
            }
            var moves = Console.ReadLine().ToCharArray();

            for (int i = 0; i < dimessions[0]; i++)
            {
                for (int j = 0; j < dimessions[1]; j++)
                {
                    if (lair[i][j] == 'P')
                    {
                        humanRow = i;
                        humanCol = j;
                    }
                }
            }

            for (int i = 0; i < moves.Length; i++)
            {
                if (moves[i] == 'U')
                {
                    if (humanRow - 1 >= 0)
                    {
                        humanRow--;
                        lair[humanRow + 1][humanCol] = '.';
                        if (lair[humanRow][humanCol] == 'B')
                        {
                            isAlive = false;

                        }
                        else
                        {
                            lair[humanRow][humanCol] = 'P';

                        }

                    }
                    else
                    {
                        isInside = false;
                    }
                }
                else if (moves[i] == 'D')
                {
                    if (humanRow + 1 < dimessions[0])
                    {
                        humanRow++;
                        lair[humanRow - 1][humanCol] = '.';
                        if (lair[humanRow][humanCol] == 'B')
                        {

                            isAlive = false;

                        }
                        else
                        {
                            lair[humanRow][humanCol] = 'P';

                        }
                    }
                    else
                    {
                        isInside = false;
                    }

                }
                else if (moves[i] == 'L')
                {
                    if (humanCol - 1 >= 0)
                    {
                        humanCol--;
                        lair[humanRow][humanCol + 1] = '.';
                        if (lair[humanRow][humanCol] == 'B')
                        {
                            isAlive = false;

                        }
                        else
                        {
                            lair[humanRow][humanCol] = 'P';

                        }
                    }
                    else
                    {
                        isInside = false;
                    }
                }
                else if (moves[i] == 'R')
                {

                    if (humanCol + 1 < dimessions[1])
                    {
                        humanCol++;
                        lair[humanRow][humanCol - 1] = '.';
                        if (lair[humanRow][humanCol] == 'B')
                        {
                            isAlive = false;

                        }
                        else
                        {
                            lair[humanRow][humanCol] = 'P';

                        }

                    }
                    else
                    {
                        isInside = false;
                    }
                }


                for (int m = 0; m < dimessions[0]; m++)
                {
                    newLair[m] = new char[dimessions[1]];
                }
                for (int k = 0; k < dimessions[0]; k++)
                {
                    for (int l = 0; l < dimessions[1]; l++)
                    {
                        if (lair[k][l] == 'B')
                        {
                            if (k + 1 < dimessions[0])
                            {
                                newLair[k + 1][l] = 'B';
                            }
                            if (k - 1 >= 0)
                            {
                                newLair[k - 1][l] = 'B';
                            }
                            if (l + 1 < dimessions[1])
                            {
                                newLair[k][l + 1] = 'B';
                            }
                            if (l - 1 >= 0)
                            {
                                newLair[k][l - 1] = 'B';
                            }
                        }
                    }
                }

                for (int j = 0; j < dimessions[0]; j++)
                {
                    for (int k = 0; k < dimessions[1]; k++)
                    {
                        if (newLair[j][k] == 'B')
                        {
                            lair[j][k] = 'B';
                        }
                    }
                }
                if (isAlive == false)
                {
                    break;
                }
                if (isInside==false)
                {
                    lair[humanRow][humanCol] = '.';
                    break;
                }
            }

            foreach (var col in lair)
            {
                Console.WriteLine(string.Join("", col));
            }
            if (isAlive == true)
            {
                Console.WriteLine($"won: {humanRow} {humanCol}");
            }
            else
            {
                Console.WriteLine($"dead: {humanRow} {humanCol}");
            }

        }
    }
}
