using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Distance_between_Points
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstSet = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            var secondSet = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            Point firstPoint = new Point {x=firstSet[0],y = firstSet[1] };
            Point secondPoint = new Point { x=secondSet[0], y =secondSet[1]};


            var result = Distance(secondPoint,firstPoint);
            Console.WriteLine("{0:f3}", result);
        }

            public static double Distance (Point something, Point jm)
        {

            var squareX = Math.Pow((something.x - jm.x), 2);
            var squareY = Math.Pow((something.y - jm.y), 2);
            var result = Math.Sqrt(squareY + squareX);
            return result;
        }
    }
}
