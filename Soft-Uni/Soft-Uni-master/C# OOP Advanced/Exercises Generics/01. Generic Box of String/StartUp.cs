using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Program
{
    public static void Main(string[] args)
    {
        int numberOfLines = int.Parse(Console.ReadLine());
        var box = new Box<string>();

        for (int i = 0; i < numberOfLines; i++)
        {
            var input = Console.ReadLine();
            box.Value = input;
            Console.WriteLine(box.ToString());
        }
    }
}

