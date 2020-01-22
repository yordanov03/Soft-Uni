using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Ladybugs
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            var ladybugIndexes = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            var field = new int[size];

            foreach (var ladybugIndex in ladybugIndexes)
            {
                if (ladybugIndex<0 || ladybugIndex>=size)
                {
                    continue;
                }
                field[ladybugIndex] = 1;
            }

            while (true)
            {
                var command = Console.ReadLine();

                if (command =="end")
                {
                    break;
                }

                var commandParts = command.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var curretnLadybugIndex = int.Parse(commandParts[0]);
                var direction = commandParts[1];
                var flyLenght = int.Parse(commandParts[2]);

                if (curretnLadybugIndex<0 || curretnLadybugIndex>=size)
                {
                    continue;
                }

                if (field[curretnLadybugIndex] == 0)
                {
                    continue;
                }

                field[curretnLadybugIndex] = 0;
                var position = curretnLadybugIndex;

                while (true)
                {


                    if (direction=="right")
                    {
                        position += flyLenght;
                    }

                    else
                    {
                        position -=flyLenght;
                    }
                    if (position < 0 || position >= size)
                    {
                        break;
                    }

                    if (field[position] == 1)
                    {
                        continue;
                    }
                    else
                    {
                        field[position] = 1;
                        break;
                    }
                }
                Console.WriteLine(string.Join(" ", field));
            }
        }
    }
}
