using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Closest_Two_Points
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
                var currentPoint = ReadPoint();
                points.Add(currentPoint);
            }

            for (int first = 0; first < points.Count; first++)
            {
                for (int second = first+1; second < points.Count; second++)
                {
                    var firstPoint = points[first];
                    var secondPoint = points[second];
                    var distance = Distance(firstPoint, secondPoint);

                    if (distance<minimumDistance)
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
            public static Point ReadPoint()
        {
            var pointParts = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            return new Point { x = pointParts[0], y = pointParts[1] };
        }
        public static double Distance(Point point1, Point point2)
        {
            var squareX = Math.Pow((point1.x - point2.x), 2);
            var squareY = Math.Pow((point1.y - point2.y),2);
            var result = Math.Sqrt(squareX + squareY);
            return result;
        }
        }
    }

