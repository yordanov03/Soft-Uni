using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Rabbit_Hole
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').ToList();
            double strenght = double.Parse(Console.ReadLine());
            int currentIndex = 0;
            var curretnPosition = input[currentIndex];
            string lastCommand = "";
            int numberToMove = 0;
            do
            {
                if (input[currentIndex].Contains("|"))
                {
                    var curretnCommand = curretnPosition.Split('|').ToList();
                    numberToMove = int.Parse(curretnCommand[1]);

                    if (curretnCommand[0] == "Right")
                    {
                        currentIndex += numberToMove;
                        strenght -= numberToMove;
                        if (currentIndex >= input.Count)
                        {
                            do
                            {
                                currentIndex = currentIndex - input.Count;
                            } while (currentIndex > input.Count - 1);
                        }
                    }

                    else if (curretnCommand[0] == "Left")
                    {
                        currentIndex -= numberToMove;
                        strenght -= numberToMove;
                        if (currentIndex < 0)
                        {
                            do
                            {
                                currentIndex = input.Count + currentIndex;
                            } while (currentIndex < 0);

                        }
                    }

                    else if (curretnCommand[0] == "Bomb")
                    {
                        strenght -= numberToMove;
                        input.Remove(input[currentIndex]);
                        currentIndex = 0;
                    }
                    lastCommand = curretnCommand[0];
                }

                input.Add($"Bomb|{strenght}");
                curretnPosition = input[currentIndex];

            } while (curretnPosition != "RabbitHole" && strenght > 0);

            if (strenght > 0)
            {
                Console.WriteLine("You have 5 years to save Kennedy!");
            }
            else if (strenght < 0)
            {
                if (lastCommand == "Bomb")
                {
                    Console.WriteLine("You are dead due to bomb explosion!");

                }
                else
                {
                    Console.WriteLine("You are tired. You can't continue the mission.");
                }
            }

        }
    }
}
