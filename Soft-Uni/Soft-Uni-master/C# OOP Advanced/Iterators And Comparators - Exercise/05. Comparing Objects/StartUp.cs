using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Program
{
    public static void Main(string[] args)
    {
        var input = Console.ReadLine();
        var people = new List<Person>();

        while (input != "END")
        {
            var separated = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            people.Add(new Person(separated[0], int.Parse(separated[1]), separated[2]));
            input = Console.ReadLine();
        }

        int numberedPerson = int.Parse(Console.ReadLine());
        var targetedPerson = people[numberedPerson-1];
        int numberOfMatches = 0;
        int missmatches = 0;

        foreach (var person in people)
        {
            var comparer = targetedPerson.CompareTo(person);

            if (comparer==0)
            {
                numberOfMatches++;
            }
            else
            {
                missmatches++;
            }
        }

        if (numberOfMatches==1)
        {
            Console.WriteLine("No matches");
        }
        else
        {
            Console.WriteLine($"{numberOfMatches} {missmatches} {people.Count}");
        }
    }
}

