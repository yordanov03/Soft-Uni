using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Monopoly
{
    class Program
    {
        static void Main(string[] args)
        {
            var dimensions = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            int numberOfLines = dimensions[0];
            int lenghtOfString = dimensions[1];
            char[][] board = new char[dimensions[0]][];
            int moneySpent = 0;
            int turns = 0;
            int hotels = 0;
            int money = 50;

            for (int i = 0; i < numberOfLines; i++)
            {
                var input = Console.ReadLine().ToCharArray();
                board[i] = new char[dimensions[1]];

                for (int j = 0; j < lenghtOfString; j++)
                {
                    board[i][j] = input[j];
                }
                
            }

            for (int i = 0; i < numberOfLines; i++)
            {
                if (i%2==0)
                {
                    for (int j = 0; j < lenghtOfString; j++)
                    {
                        MoveAroundTheBoard(board, ref turns, ref hotels, ref money, i, j, moneySpent);

                    }
                }
                else
                {
                    for (int j = lenghtOfString - 1; j >= 0; j--)
                    {
                        MoveAroundTheBoard(board, ref turns, ref hotels, ref money, i, j, moneySpent);
                    }
                }
                
            }
            Console.WriteLine($"Turns {turns}");
            Console.WriteLine($"Money {money}");
        }

        private static void MoveAroundTheBoard(char[][] board, ref int turns, ref int hotels, ref int money, int i, int j, int moneySpent)
        {
            if (board[i][j] == 'H')
            {
                turns++;
                hotels++;
                Console.WriteLine($"Bought a hotel for {money}.Total hotels: {hotels}.");
                money = 0;
            }
            else if (board[i][j] == 'J')
            {
                Console.WriteLine($"Gone to jail at turn {turns}.");
                turns += 3;
                if (hotels > 0)
                {
                    money += 2*(hotels * 10);
                }
            }
            else if (board[i][j] == 'S')
            {
                moneySpent = ((i + 1) * (j + 1));
                Console.WriteLine($"Spent {moneySpent} at the shop.");
                money -= moneySpent;
                if (money < 0)
                {
                    money = 0;
                }
                turns++;
            }
            else
            {
                turns++;
            }
            if (hotels > 0)
            {
                money += hotels * 10;
            }
        }
    }
}
