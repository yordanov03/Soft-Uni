using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int sizeOfField = int.Parse(Console.ReadLine());
            var ladybugIndexes = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            var command = Console.ReadLine();
            var field = new int[sizeOfField];

            foreach (var ladybugIndex in ladybugIndexes)
            {
                if (ladybugIndex<0 || ladybugIndex>=sizeOfField)
                {
                    continue;
                }
                field[ladybugIndex] = 1;
            }
            while (command!="end")
            {
                var separated = command.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                var ladybugToMove = int.Parse(separated[0]);
                var direction = separated[1];
                var spacesToMove = int.Parse(separated[2]);
                int move = 0;

                if (direction == "right")
                {

                }

                


                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", field));
        }
    }
}
