using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Longer_Line
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());
            double x4 = double.Parse(Console.ReadLine());
            double y4 = double.Parse(Console.ReadLine());


            double firstLineLengt = closestpoint1(x1, y1, x2, y2);
            double secondLineLength = closestPoint2(x3, y3, x4, y4);

            if (firstLineLengt >= secondLineLength)
            {
                PrintLine(x1, x2, y1, y2);
            }
            
            else
            {
                PrintLine(x3, y3, x4, y4);
            }
        }

        private static void PrintLine(double x1, double y1, double x2, double y2)
        {
            double distanceToCenterA = closestpoint1(x1, y1, 0, 0);
            double distanceToCenterB = closestpoint1(x2, y2, 0, 0);

            if (distanceToCenterA > distanceToCenterB)
            {
                Console.WriteLine("({0}, {1})({2}, {3})", x2, y2, x1, y1);

            }
            else
            {
                Console.WriteLine("({0}, {1})({2}, {3})", x1, y1, x2, y2);
            }


        }

        private static double closestPoint2(double x3, double y3, double x4, double y4)
        {
            double greaterLenghtB = Math.Sqrt(Math.Pow((x4 - x3), 2) + Math.Pow((y4 - y3), 2));
            return greaterLenghtB;
        }

        private static double closestpoint1(double x1, double y1, double x2, double y2)
        {
            double greaterLenghtA = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            return greaterLenghtA;


        }

    }
}