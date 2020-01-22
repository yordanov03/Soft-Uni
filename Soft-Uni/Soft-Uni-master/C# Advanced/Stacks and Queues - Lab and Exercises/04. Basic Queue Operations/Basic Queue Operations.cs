using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Basic_Queue_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            var toBePushed = input[0];
            var toBePopped = input[1];
            var toContain = input[2];
            var numbers = Console.ReadLine();
            var queue = new Queue<double>(numbers.Split(' ').Select(double.Parse));
            double smallestNumber = double.MaxValue;

            for (int i = 0; i < toBePopped; i++)
            {
                queue.Dequeue();
            }

            if (queue.Contains(toContain))
            {
                Console.WriteLine("true");
            }
            else
            {
                if (queue.Count==0)
                {
                    Console.WriteLine(0);
                }
                else
                {
                    for (int i = 1; i <= queue.Count; i++)
                    {
                        if (smallestNumber>queue.Dequeue())
                        {
                            smallestNumber = queue.Dequeue();
                        }
                    }
                    Console.WriteLine(smallestNumber);
                }
            }
        }
    }
}
