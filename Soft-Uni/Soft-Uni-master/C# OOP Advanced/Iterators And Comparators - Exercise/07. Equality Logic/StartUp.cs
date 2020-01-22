using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Program
{
    public static void Main(string[] args)
    {
        var numberOfInputs = int.Parse(Console.ReadLine());
        var sortedPeople = new SortedSet<Person>();
        var hashPeople = new HashSet<Person>();

        for (int i = 0; i < numberOfInputs; i++)
        {
            var input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            var person = new Person(input[0], int.Parse(input[1]));
            sortedPeople.Add(person);
            hashPeople.Add(person);
        }
        Console.WriteLine(sortedPeople.Count);
        Console.WriteLine(hashPeople.Count);
    }
}

