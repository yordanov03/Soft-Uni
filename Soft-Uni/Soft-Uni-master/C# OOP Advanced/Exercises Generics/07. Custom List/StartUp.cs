using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class StartUp
{
    public static void Main(string[] args)
    {
        var command = Console.ReadLine();
        var box = new Box<string>();

        while (command != "END")
        {
            var separated = command.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            switch (separated[0])
            {
                case "Add":
                    box.Add(separated[1]);
                    break;
                case "Remove":
                    box.Remove(int.Parse(separated[1]));
                    break;
                case "Max":
                    Console.WriteLine(box.Max());
                    break;
                case "Min":
                    Console.WriteLine(box.Min());
                    break;
                case "Greater":
                    Console.WriteLine(box.CountGreaterThan(separated[1]));
                    break;
                case "Swap":
                    box.Swap(int.Parse(separated[1]), int.Parse(separated[2]));
                    break;
                case "Contains":
                    Console.WriteLine(box.Contains(separated[1]));
                    break;
                case "Print":
                    Console.WriteLine(box.ToString().TrimEnd());
                    break;

            }
            command = Console.ReadLine();
        }

    }
}

