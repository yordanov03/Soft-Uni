using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Dangerous_Floor
{
    class Program
    {
        static void Main(string[] args)
        {
            var water = new Queue<int>();
            var flowers = new Stack<int>();
            var flowerSeeds = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).Reverse().ToList();
            var waterCans = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).Reverse().ToList();
            var secondNature = new List<int>();
            int remainder = 0;

            for (int i = 0; i < flowerSeeds.Count; i++)
            {
                flowers.Push(flowerSeeds[i]);
            }
            for (int i = 0; i <waterCans.Count; i++)
            {
                water.Enqueue(waterCans[i]);
            }

            while (water.Count>0 && flowers.Count>0)
            {
                
                int currentWaterCan = water.Dequeue()+remainder;
                int currentFlower = flowers.Pop();
                remainder = currentWaterCan - currentFlower;

               if (remainder<0)
                {
                    while (remainder<=0)
                    {
                        remainder = (remainder+ currentWaterCan)-currentFlower;
                    }
                }

                if (remainder == 0)
                {
                    secondNature.Add(currentFlower);
                }
            }

            if (water.Count>0)
            {
                if (water.Count == 1)
                {
                    Console.WriteLine(water.Dequeue() + remainder);
                }
                else
                {
                    for (int i = 0; i <= water.Count; i++)
                    {
                        Console.Write(water.Dequeue() + " ");
                    }
                }
            }
            if (flowers.Count>0)
            {
                
                for (int i = 0; i <= flowers.Count; i++)
                {
                    Console.Write(flowers.Pop()+" ");
                }
            }
            if (secondNature.Count>0)
            {
                Console.WriteLine(string.Join(" ", secondNature));
            }
            else
            {
                Console.WriteLine("None");
            }
        }
    }
}
