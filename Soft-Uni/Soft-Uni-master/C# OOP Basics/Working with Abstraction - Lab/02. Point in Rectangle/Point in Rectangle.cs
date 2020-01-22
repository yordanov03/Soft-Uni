using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Program
    {
        static void Main(string[] args)
        {
        var coordinates = Console.ReadLine().Split().Select(int.Parse).ToList();
        var rectangle = new Rectangle(coordinates[0], coordinates[1], coordinates[2], coordinates[3]);
        var pointsCount = int.Parse(Console.ReadLine());

        for (int pointsCounter = 0; pointsCounter < pointsCount; pointsCounter++)
        {
            var pointsCoord = Console.ReadLine().Split().Select(int.Parse).ToList();
            var point = new Point(pointsCoord[0], pointsCoord[1]);
            var cotains = rectangle.Contains(point);
            Console.WriteLine(cotains);
        }
        }
    }

