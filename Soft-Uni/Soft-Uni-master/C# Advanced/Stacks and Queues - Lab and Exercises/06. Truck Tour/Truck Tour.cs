using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Truck_Tour
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = int.Parse(Console.ReadLine());
            var queue = new Queue<int>();
            var index = int.MaxValue;

            for (int i = 0; i < input; i++)
            {
                var info = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
                var amountPetrol = info[0];
                var distance = info[1];
                queue.Enqueue(amountPetrol);
            }

            for (int i = 0; i < queue.Count; i++)
            {
                var number = queue.Dequeue();
                if (number<index)
                {
                    index = number;
                }
            }

            Console.WriteLine(index);
        }
    }
}
