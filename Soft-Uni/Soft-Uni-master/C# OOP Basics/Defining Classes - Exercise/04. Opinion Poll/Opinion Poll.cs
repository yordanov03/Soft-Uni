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
        var people = new List<Person>();

        for (int i = 0; i < numberOfPeople; i++)
        {
            var personInfo = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            var person = new Person(personInfo[0], int.Parse(personInfo[1]));
            people.Add(person);
        }
        people.Where(p => p.Age > 30).OrderBy(p => p.Name).ToList().ForEach(p=>Console.WriteLine($"{p.Name} - {p.Age}"));
        }
    }

