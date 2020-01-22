using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Program
{
    public static void Main(string[] args)
    {

        var box = new List<Box<int>>();
        int numberOfLines = int.Parse(Console.ReadLine());

        for (int i = 0; i < numberOfLines; i++)
        {
            var input = int.Parse(Console.ReadLine());
            box.Add(new Box<int>(input));
        }

        var positions = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
        var temp = box[positions[0]];
        box[positions[0]] = box[positions[1]];
        box[positions[1]] = temp;

        foreach (var item in box)
        {
            Console.WriteLine(item);
        }
    }
}

