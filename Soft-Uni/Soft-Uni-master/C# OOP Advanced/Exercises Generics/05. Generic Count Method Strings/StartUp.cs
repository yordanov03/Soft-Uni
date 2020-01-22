using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class StartUp
{
    public static void Main(string[] args)
    {

        int numberOfInputs = int.Parse(Console.ReadLine());
        var box = new Box<string>();

        for (int i = 0; i < numberOfInputs; i++)
        {
            var input = Console.ReadLine();
            box.Add(input);
        }

        var criteria = Console.ReadLine();
        Console.WriteLine(box.CompareAll(criteria));
    }
}

