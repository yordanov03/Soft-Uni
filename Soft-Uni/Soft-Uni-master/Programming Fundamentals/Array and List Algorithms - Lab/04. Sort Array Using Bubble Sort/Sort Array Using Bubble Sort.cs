using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Sort_Array_Using_Bubble_Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            bool inOrder = false;

            while (inOrder == false)
            {
                inOrder = true;
                for (int i = 1; i < input.Length; i++)
                {
                    if (input[i-1]> input[i])
                    {
                        var temp = input[i];
                        input[i] = input[i - 1];
                        input[i - 1] = temp;
                        inOrder = false;
                        i--;

                    }
                    
                }
            }

            Console.WriteLine(string.Join(" ", input));
            
            
        }
    }
}
