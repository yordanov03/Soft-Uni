using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Geometry_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();

            if (figure == "triangle")
            {
                double side = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());
                triangle(side, height);
                double face = triangle(side, height);
                Console.WriteLine("{0:f2}", face);
                

            }
            else if (figure == "square")
            {
                double side = double.Parse(Console.ReadLine());
                Square(side);
                double face = Square(side);
                Console.WriteLine("{0:f2}", face);
            }
            else if (figure =="rectangle")
            {
                double width = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());
                rectangle(width, height);
                double face = Math.Round(rectangle(width, height),2);
                Console.WriteLine("{0:f2}", face);
            }
            else if (figure =="circle")
            {
                double radius = double.Parse(Console.ReadLine());
                circle(radius);
                double face = Math.Round(circle(radius),2);
                Console.WriteLine("{0:f2}", face);

            }
        }

        private static double circle(double radius)
        {
            double face = Math.PI * Math.Pow((radius), 2);
            return face;
        }

        private static double rectangle(double width, double height)
        {
            double face = width * height;
            return face;
        }

        private static double Square(double side)
        {
            double face = 4 * side;
            return face;
        }

        private static double triangle(double side, double height)
        {
            double face = (side * height) / 2;
            return face;
        }
    }
}
