using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Formatting_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new[] { ' ', '\n', '\r', '\t', }, StringSplitOptions.RemoveEmptyEntries).ToList();
            int a = int.Parse(input[0]);
            double b = double.Parse(input[1]);
            double c = double.Parse(input[2]);
            string binary = Convert.ToString(a,2).PadLeft(10,'0').Substring(0,10);

            Console.WriteLine(string.Format("|{0,-10:X}|{1,10}|{2,10:f2}|{3,-10:f3}|",a,binary,b,c));
        }
    }
}
