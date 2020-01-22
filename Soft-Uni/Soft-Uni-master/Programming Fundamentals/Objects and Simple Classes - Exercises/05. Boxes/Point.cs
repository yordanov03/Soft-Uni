using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Boxes
{
    class Point
    {
        public double x { get; set; }
        public double y { get; set; }

        public static double Distance(Point point1, Point point2)
        {
            var squareX = Math.Pow((point1.x - point2.x), 2);
            var squareY = Math.Pow((point1.y - point2.y), 2);
            var result = Math.Sqrt(squareX + squareY);
            return result;
        }
    }
}
