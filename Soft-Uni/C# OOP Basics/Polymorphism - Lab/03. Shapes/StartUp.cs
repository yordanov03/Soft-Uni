using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Program
    {
        static void Main(string[] args)
        {
        var shapes = new List<Shapes>();

        shapes.Add(new Circle(3.5));
        shapes.Add(new Rectangle(3.5, 1.2));
        shapes.Add(new Rectangle(1.5, 1.5));
        shapes.Add(new Rectangle(3.4, 1.5));
        shapes.Add(new Circle(3.6));

        foreach (var shape in shapes)
        {
            Console.WriteLine(shape.Draw());
        }
        }
    }

