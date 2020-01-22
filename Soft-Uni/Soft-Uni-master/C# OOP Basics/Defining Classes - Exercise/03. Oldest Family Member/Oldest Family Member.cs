using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Program
    {
        static void Main(string[] args)
        {
        int numberOfPeople = int.Parse(Console.ReadLine());
        var allPeople = new Family();

        for (int i = 0; i < numberOfPeople; i++)
        {
            var separated = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            var newMember = new Person(separated[0], int.Parse(separated[1]));
            allPeople.AddMember(newMember);
        }
        var oldestMember = allPeople.GetTheOldestMember();

        Console.WriteLine($"{oldestMember.Name} {oldestMember.Age}");
        }
    }

