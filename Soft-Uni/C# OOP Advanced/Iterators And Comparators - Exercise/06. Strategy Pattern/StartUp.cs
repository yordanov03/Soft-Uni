using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Program
{
    public static void Main(string[] args)
    {
        var sortedByName = new SortedSet<Person>(new NameComparer());
        var sortedByAge = new SortedSet<Person>(new AgeComparer());

        var numberOfEntries = int.Parse(Console.ReadLine());

        for (int i = 0; i < numberOfEntries; i++)
        {
            var personInput = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            Person newPerson = new Person(personInput[0], int.Parse(personInput[1]));
            sortedByAge.Add(newPerson);
            sortedByName.Add(newPerson);
        }

        foreach (var person in sortedByName)
        {
            Console.WriteLine($"{person.Name} {person.Age}");
        }

        foreach (var person in sortedByAge)
        {
            Console.WriteLine($"{person.Name} {person.Age}");
        }
    }
}

