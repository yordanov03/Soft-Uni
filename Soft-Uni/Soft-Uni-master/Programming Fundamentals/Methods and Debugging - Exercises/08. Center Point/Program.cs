using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Center_Point
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            double greaterdistanceA = ClosestPoint(x1, y1,0,0);
            double closestdistanceB = ClosestPoint(x2, y2, 0, 0);

            if (greaterdistanceA>closestdistanceB)
            {
                Console.WriteLine("({0}, {1})", x2, y2);
            }
            else if (closestdistanceB>greaterdistanceA)
            {
                Console.WriteLine("({0}, {1})", x1, y1);
            }
            else
            {
                Console.WriteLine("({0}, {1})",x1,y1);
            }

        }

        private static double ClosestPoint(double x1, double y1, double x2, double y2)
        {
            double distance = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            return distance;

            
        }
    }
}
