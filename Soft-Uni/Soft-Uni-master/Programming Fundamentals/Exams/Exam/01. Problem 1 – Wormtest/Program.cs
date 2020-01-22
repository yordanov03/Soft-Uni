using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Problem_1___Wormtest
{
    class Program
    {
        static void Main(string[] args)
        {
            float inputLength = float.Parse(Console.ReadLine());
            var lenghtInMM = inputLength * 100;
            double width = double.Parse(Console.ReadLine());
            ulong remains = lenghtInMM % width;

            if (remains==0)
            {
                remains = lenghtInMM * width;
                Console.WriteLine($"{remains:f2}");
            }

            else
            {
                remains = lenghtInMM/width*100;
                Console.WriteLine($"{remains:f2}%");
            }



        }
    }
}
