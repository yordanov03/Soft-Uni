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

        while (input != "End")
        {
            var separated = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            if (separated[0] == "Citizen")
            {
                allEntries.Add(new Citizen(separated[1], int.Parse(separated[2]), separated[3], separated[4]));
            }
            else if (separated[0] == "Pet")
            {
                allEntries.Add(new Pet(separated[1], separated[2]));
            }
            else if (separated[0] == "Robot")
            {
                allEntries.Add(new Robot(separated[1], separated[2]));
            }
            input = Console.ReadLine();
        }

        string criteria = Console.ReadLine();

        foreach (var entriee in allEntries)
        {
            if (entriee.Birthdate.EndsWith(criteria))
            {
                Console.WriteLine(entriee.Birthdate);
            }
        }
    }
}

