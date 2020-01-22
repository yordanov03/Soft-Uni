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
        var allPeople = new List<Person>();

        while (input != "End")
        {
            var separated = input.Split();
            var currentPerson = allPeople.Where(p => p.personName == separated[0]).FirstOrDefault();

            if (currentPerson==null)
            {
                currentPerson = new Person(separated[0]);
            }
            if (separated[1]=="company")
            {
                if (currentPerson.company==null)
                {
                    currentPerson.company = new Company(separated[2], separated[3], decimal.Parse(separated[4]));
                }
                else
                {
                    currentPerson.company.companyName = separated[2];
                    currentPerson.company.department = separated[3];
                    currentPerson.company.salary = decimal.Parse(separated[4]);
                }
                
            }
            else if (separated[1]=="pokemon")
            {
                currentPerson.pokemons.Add(new Pokemon(separated[2], separated[3]));
            }
            else if (separated[1]=="parents")
            {
                currentPerson.parents.Add(new Parents(separated[2], separated[3]));
            }
            else if (separated[1]=="children")
            {
                currentPerson.children.Add(new Children(separated[2], separated[3]));
            }
            else if (separated[1]=="car")
            {
                if (currentPerson.car==null)
                {
                    currentPerson.car = new Car(separated[2], int.Parse(separated[3]));
                }
                else
                {
                    currentPerson.car.carModel = separated[2];
                    currentPerson.car.carSpeed = int.Parse(separated[3]);
                }
                
            }
            allPeople.Add(currentPerson);
            input = Console.ReadLine();
        }
        var nameToExtract = Console.ReadLine();
        var singlePerson = allPeople.Where(p => p.personName == nameToExtract).FirstOrDefault();
        if (singlePerson!=null)
        {
            Console.WriteLine(singlePerson.personName);
            Console.WriteLine($"Company:");
            if (singlePerson.company != null)
            {
                Console.WriteLine($"{singlePerson.company.companyName} {singlePerson.company.department} {singlePerson.company.salary:F2}");
            }
            Console.WriteLine($"Car:");
            if (singlePerson.car!=null)
            {
                Console.WriteLine($"{singlePerson.car.carModel} {singlePerson.car.carSpeed}");
            }
            Console.WriteLine($"Pokemon:");
            if (singlePerson.pokemons.Count != 0)
            {
                foreach (var pokemon in singlePerson.pokemons)
                {
                    Console.WriteLine($"{pokemon.name} {pokemon.type} ");
                }
            }
            Console.WriteLine($"Parents:");
            if (singlePerson.parents.Count != 0)
            {
                foreach (var parent in singlePerson.parents)
                {
                    Console.WriteLine($"{parent.parentName} {parent.parentBirthday}");
                }
            }
            Console.WriteLine($"Children:");
            if (singlePerson.children.Count != 0)
            {
                foreach (var child in singlePerson.children)
                {
                    Console.WriteLine($"{child.childName} {child.childBirthday}");
                }
            }

        }
    }
}

