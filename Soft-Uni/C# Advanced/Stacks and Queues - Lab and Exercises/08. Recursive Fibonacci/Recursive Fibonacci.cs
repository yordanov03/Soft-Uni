using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Recursive_Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            var queue = new Queue<ulong>();
            ulong number1 = 0;
            ulong number2 = 1;
            ulong number3 = 0;

            queue.Enqueue(number1);
            queue.Enqueue(number2);

            for (int i = 0; i < 47; i++)
            {
                number3 = number1 + number2;

                queue.Enqueue(number3);

                number1 = number2;
                number2 = number3;
            }

            for (int i = 1; i <= number; i++)
            {
                queue.Dequeue();
            }

            Console.WriteLine(queue.Dequeue());
        }
    }
}
