using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Max_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            int greatest = GetMax(a, b, c);
            Console.WriteLine(greatest);
        }

        static int GetMax(int a, int b, int c)
        {
            int greatest1 = Math.Max(a, b);
            int greatest2 = Math.Max(greatest1, c);
            return greatest2;

        }
    }
}
