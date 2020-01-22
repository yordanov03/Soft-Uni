using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Basic_Stack_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var toBePushed = input[0];
            var toBePopped = input[1];
            var toExist = input[2];
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var stack = new Stack<int>();
            int smallestNumber = 2147483647;

            for (int i = 0; i < toBePushed; i++)
            {
                stack.Push(numbers[i]);
            }

            for (int i = 0; i < toBePopped; i++)
            {
                stack.Pop();
            }

            if (stack.Contains(toExist))
            {
                Console.WriteLine("true");
            }

            else
            {
                if (stack.Count==0)
                {
                    smallestNumber = 0;
                }

                else
                {
                    for (int i = 0; i < stack.Count; i++)
                    {
                        int number = stack.Pop();
                        if (number < smallestNumber)
                        {
                            smallestNumber = number;
                        }
                    }
                }
                Console.WriteLine(smallestNumber);
            }
        }
    }
}
