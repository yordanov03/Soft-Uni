using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Boxes
{
    class Boxes
    {
        public double upperLeft { get; set; }
        public double upperRight { get; set; }
        public double bottomLeft { get; set; }
        public double bottomRight { get; set; }

        public static double Perimeter (double width, double height)
        {
            var perimeter = (2 * width + 2 * height);
            return perimeter;
        }

        public static double Area (double width, double height)
        {
            var area = width * height;
            return area;
        }
    }
}
