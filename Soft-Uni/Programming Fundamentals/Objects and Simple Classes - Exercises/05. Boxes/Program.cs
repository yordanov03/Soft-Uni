using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Boxes
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputLine = Console.ReadLine();
            var box = new Boxes();
            var results = new List<double>();
            

            while (inputLine!="end")
            {
                var split = inputLine.Split(new[] { ' ', ':', '|' }, StringSplitOptions.RemoveEmptyEntries).ToList();

                var point1 = new Point();
                var point2 = new Point();
                var point3 = new Point();
                var point4 = new Point();
                
                point1.x = double.Parse(split[0]);
                point1.y = double.Parse(split[1]);
                point2.x = double.Parse(split[2]);
                point2.y = double.Parse(split[3]);
                point3.x = double.Parse(split[4]);
                point3.y = double.Parse(split[5]);
                point4.x = double.Parse(split[6]);
                point4.y = double.Parse(split[7]);

                var width = Point.Distance(point1, point2);
                var height = Point.Distance(point3, point4);

                var perimeter = Boxes.Perimeter(width, height);
                var area = Boxes.Area(width, height);

                results.Add(width);
                results.Add(height);
                results.Add(perimeter);
                results.Add(area);

                inputLine = Console.ReadLine();
            }

            for (int i = 0; i < results.Count; i+=4)
            {
                Console.WriteLine($"Box: {results[i]}, {results[i+1]}");
                Console.WriteLine($"Perimeter: {results[i+2]}");
                Console.WriteLine($"Area: {results[i+3]}");
            }
        }
    }
}
