using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Balanced_Parentheses
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            char[] splitInput = input.ToCharArray();

            var stack = new Stack<char>(splitInput);
            var queue = new Queue<char>(splitInput);

            bool result = true;

            for (int i = 0; i < stack.Count / 2; i++)
            {
                var stackChar = (int)stack.Pop();
                var queueDequeue = (int)queue.Dequeue() + 2;

                if (stackChar != queueDequeue)
                {
                    result = false;
                    break;
                }
            }

            if (result == true)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
