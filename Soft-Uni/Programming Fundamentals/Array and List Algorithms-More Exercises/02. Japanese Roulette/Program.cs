using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Japanese_Roulette
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var commands = Console.ReadLine().Split(' ',',').ToList();
            int player = 0;
            int goesWithCommands = 0;
            int currentPosition = 2;
            var leftRight = commands[goesWithCommands + 1];
            var positionToRotate = int.Parse(commands[goesWithCommands]);

            for (int i = 0; i < input.Count; i++)
            {

                if (leftRight =="Right")
                {
                    currentPosition += positionToRotate;
                    if (currentPosition>input.Count-1)
                    {
                        do
                        {
                            currentPosition = currentPosition - 6;
                        } while (currentPosition>5);
                    }
                }
                else if (leftRight =="Left")
                {
                    currentPosition -= positionToRotate;
                    if (currentPosition < 0)
                    {
                        do
                        {
                            currentPosition = currentPosition + 6;
                        } while (currentPosition<0);
                    }
                }
                if (input[currentPosition] == 1)
                {
                Console.WriteLine("Game over! Player {0} is dead.", player);
                    break;
                }
                player++;
                goesWithCommands += 2;
                currentPosition++;
                if (goesWithCommands>commands.Count)
                {
                    goesWithCommands = 0;
                }
            }

            if (player==input.Count)
            {
                Console.WriteLine("Everybody got lucky!");
            }
              
        }
    }
}
