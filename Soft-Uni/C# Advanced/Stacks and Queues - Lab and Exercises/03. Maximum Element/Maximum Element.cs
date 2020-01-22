using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Maximum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            double numberOfRotations = double.Parse(Console.ReadLine());
            var stack = new Stack<double>();
            double biggestNumber = 0;

            for (int i = 1; i <= numberOfRotations; i++)
            {
                var input = Console.ReadLine().Split(' ').Select(double.Parse).ToList();

                if (input.Contains(1))
                {
                    stack.Push(input[1]);
                }
                else if (input.Contains(2))
                {
                    stack.Pop();
                }
                else if (input.Contains(3))
                {
                    for (int j = 0; j <=stack.Count; j++)
                    {
                        double numberToCompate = stack.Pop();
                        if (numberToCompate>biggestNumber)
                        {
                            biggestNumber = numberToCompate;
                        }
                        
                    }
                    Console.WriteLine(biggestNumber);
                }
                
            }
        }
    }
}
