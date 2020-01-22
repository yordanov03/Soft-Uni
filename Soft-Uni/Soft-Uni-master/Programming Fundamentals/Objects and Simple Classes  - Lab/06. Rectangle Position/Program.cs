using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Rectangle_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstRectangle = ReadRectangle();
            var secondRectangle = ReadRectangle();


            bool result = IsInside(firstRectangle, secondRectangle);

            if (result == true)
            {
                Console.WriteLine("Inside");
            }

            else
            {
                Console.WriteLine("Not inside");
            }


        }
    

        public static Rectangle ReadRectangle()
        {
            var rectangle = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            return new Rectangle { left = rectangle[0], top = rectangle[1], width = rectangle[2], height = rectangle[3] };

        }
        public static bool IsInside(Rectangle rectangle1, Rectangle rectangle2)
        {
            bool inside = false;
            if (rectangle1.left >= rectangle2.left && rectangle1.right<= rectangle2.right && rectangle1.top<=rectangle2.top && rectangle1.bottom<= rectangle2.bottom)
            {
                return inside = true;
            }
            else
            {
                return inside = false;
            }
        }
    }
}
