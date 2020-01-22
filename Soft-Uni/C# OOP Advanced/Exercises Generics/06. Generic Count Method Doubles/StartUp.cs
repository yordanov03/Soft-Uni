using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Program
{
    public static void Main(string[] args)
    {

        int numberOfInputs = int.Parse(Console.ReadLine());
        var box = new Box<double>();

        for (int i = 0; i < numberOfInputs; i++)
        {
            var input = double.Parse(Console.ReadLine());
            box.Add(input);
        }

        var criteria = double.Parse(Console.ReadLine());
        Console.WriteLine(box.CompareAll(criteria));
        }
}

