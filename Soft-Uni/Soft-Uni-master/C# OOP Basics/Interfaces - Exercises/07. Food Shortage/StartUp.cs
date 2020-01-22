using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main(string[] args)
    {
        int participants = int.Parse(Console.ReadLine());
        List<Person> allPeople = new List<Person>();
        int allFood = 0;

        for (int i = 0; i < participants; i++)
        {
            var input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            if (input.Count == 4)
            {
                allPeople.Add(new Citizen(input[0], int.Parse(input[1]), input[2], input[3]));
            }
            else
            {
                allPeople.Add(new Rebel(input[0], int.Parse(input[1]), input[2]));
            }
        }

        var searchPerson = Console.ReadLine();

        while (searchPerson!="End")
        {
            var personMatched = allPeople.Where(p => p.Name == searchPerson).FirstOrDefault();

            if (personMatched!=null)
            {
                personMatched.BuyFood();
            }
            searchPerson = Console.ReadLine();
        }

        foreach (var person in allPeople)
        {
            allFood += person.Food;
        }

        Console.WriteLine(allFood);
    }
}

