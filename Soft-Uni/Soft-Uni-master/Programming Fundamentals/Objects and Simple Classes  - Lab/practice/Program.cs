using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var points = new List<Point>();
            var minimumDistance = double.MaxValue;
            Point firstPointResult = null;
            Point secondPointResult = null;

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
                var firstPoint = input[0];
                var secondPoint = input[1];
                Point coordinate = new Point { x = firstPoint, y = secondPoint };
                points.Add(coordinate);
            }

            for (int i = 0; i < points.Count; i++)
            {
                for (int j = i+1; j < points.Count; j++)
                {
                    var firstPoint = points[i];
                    var secondPoint = points[j];
                    var distance = Distance(firstPoint, secondPoint);
                    if (minimumDistance> distance)
                    {
                        minimumDistance = distance;
                        firstPointResult = firstPoint;
                        secondPointResult = secondPoint;
                    }
                }
            }
            Console.WriteLine("{0:f3}", minimumDistance);
            Console.WriteLine($"{firstPointResult.x}, {firstPointResult.y}");
            Console.WriteLine($"{secondPointResult.x}, {secondPointResult.y}");
        }

        public static double Distance (Point firstPoint, Point secondPoint)
        {
            var xs = Math.Pow((firstPoint.x - secondPoint.x), 2);
            var ys = Math.Pow((firstPoint.y - secondPoint.y), 2);
            var result = Math.Sqrt(xs + ys);
            return result;
        }
    }
}

