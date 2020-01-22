using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Sequence_With_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = double.Parse(Console.ReadLine());
            var queue = new Queue<double>();

            double firstNumber1 = 0;
            double secondNumber1 = 0;
            double thirdNumber1 = 0;

            var list = new List<double>();

            queue.Enqueue(input);

            for (int i = 0; i <= 49; i++)
            {
                firstNumber1 = input + 1;
                secondNumber1 = (input * 2) + 1;
                thirdNumber1 = input + 2;

                queue.Enqueue(firstNumber1);
                queue.Enqueue(secondNumber1);
                queue.Enqueue(thirdNumber1);

                list.Add(firstNumber1);
                list.Add(secondNumber1);
                list.Add(thirdNumber1);
                input = list[i];

                
            }

            for (int i = 1; i <= 50; i++)
            {
                Console.Write(queue.Dequeue()+" ");
            }
        }
    }
}
