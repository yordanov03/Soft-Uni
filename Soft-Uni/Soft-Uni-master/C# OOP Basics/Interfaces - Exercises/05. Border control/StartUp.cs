using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Program
    {
        static void Main(string[] args)
        {
        var input = Console.ReadLine();
        List<IEntree> allEntries = new List<IEntree>();

        while (input!="End")
        {
            var separated = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            if (separated.Count==2)
            {
                allEntries.Add(new Robot(separated[0], separated[1]));
            }
            else
            {
                allEntries.Add(new Person(separated[0], separated[2], int.Parse(separated[1])));
            }
            input = Console.ReadLine();

        }

        string criteria = Console.ReadLine();

        foreach (var entree in allEntries)
        {
            if (entree.ID.EndsWith(criteria))
            {
                Console.WriteLine(entree.ID);
            }
        }
        }
    }

