using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Cube_Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            double side = double.Parse(Console.ReadLine());
            string parameter = Console.ReadLine();
            double result = 0;

            if (parameter == "face")
            {
                result = face(side);
                Console.WriteLine(string.Format("{0:f2}", result));
            }
            else if (parameter == "space")
            {
                result = space(side);
                Console.WriteLine(string.Format("{0:f2}", result));
            }
            else if (parameter == "volume")
            {
               result =  volume(side);
                Console.WriteLine(string.Format("{0:f2}", result));
            }
            else
            {
               result =  area(side);
                Console.WriteLine(string.Format("{0:f2}", result));
            }
        }

        private static double area(double side)
        {
            double parameter = 6 * (Math.Pow((side), 2));
            return parameter;
        }

        private static double volume(double side)
        {
            double parameter = Math.Pow((side), 3);
            return parameter;
        }

        private static double space(double side)
        {
            double parameter = Math.Sqrt(3 * (Math.Pow((side), 2)));
            return parameter;
        }

        private static double face(double side)
        {
            double parameter = Math.Sqrt(2 * (Math.Pow((side), 2)));
            return parameter;
        }
    }
}
