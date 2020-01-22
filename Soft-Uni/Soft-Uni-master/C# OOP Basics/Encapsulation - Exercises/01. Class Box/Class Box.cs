using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;


    class Program
    {
        static void Main(string[] args)
        {
            Type boxType = typeof(Box);
            FieldInfo[] fields = boxType.GetFields(BindingFlags.NonPublic | BindingFlags.Instance);
        


        double lenght = double.Parse(Console.ReadLine());
        double width = double.Parse(Console.ReadLine());
        double height = double.Parse(Console.ReadLine());

        Box box = null;

        try
        {
            box = new Box(lenght, width, height);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
            return;
        }

        Console.WriteLine($"Surface Area - {box.SurfaceArea():F2}");
        Console.WriteLine($"Lateral Surface Area - {box.LateralSurfaceArea():F2}");
        Console.WriteLine($"Volume - {box.Volume():F2}");
    }
   }

