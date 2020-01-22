using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Simple_Text_Editor
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfLines = int.Parse(Console.ReadLine());
            var queue = new Queue<char>();
            var stack = new Stack<string>();
            

            for (int i = 0; i < numberOfLines; i++)
            {
                var input = Console.ReadLine().Split(' ').ToList();
                var command = int.Parse(input[0]);
                int toDo = 0;
                bool secondPart = Int32.TryParse(input[1], out toDo);

                if (secondPart)
                {
                    if (command==2)
                    {
                        for (int j = 0; j < command; j++)
                        {
                            queue.Dequeue();
                        }
                    }
                    else if (command==3)
                    {
                        Console.WriteLine(queue.ElementAt(toDo));
                    }
                    else if (command==4)
                    {

                    }
                }
                else
                {
                    char[] chars = input[1].ToCharArray();
                    for (int l = 0; l < chars.Length; l++)
                    {
                        queue.Enqueue(chars[l]);
                    }
                }
            }
        }
    }
}
