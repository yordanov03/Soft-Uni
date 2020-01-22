using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class StartUp
{
    public static void Main(string[] args)
    {
        var box = new Box<int>();
        var numberOfLines = int.Parse(Console.ReadLine());

        for (int i = 0; i < numberOfLines; i++)
        {
            var input = int.Parse(Console.ReadLine());
            box.Value = input;
            Console.WriteLine(box.ToString());
        }
    }
}

