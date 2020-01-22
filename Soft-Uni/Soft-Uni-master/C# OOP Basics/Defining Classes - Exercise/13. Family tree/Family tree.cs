using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    public static void Main(string[] args)
    {

        string personInput = Console.ReadLine();
        var familyTree = new List<Person>();
        Person mainPerson = new Person();

        if (IsBirthday(personInput))
        {
            mainPerson.Birthday = personInput;
        }

        else
        {
            mainPerson.Name = personInput;
        }

        familyTree.Add(mainPerson);
        string command = Console.ReadLine();

        while (command != "End")
        {
            string[] tokens = command.Split('-');

            if (tokens.Length>1)
            {
                string firstPerson = tokens[0].TrimEnd();
                string secondPerson = tokens[1].TrimStart();

                var currentPerson = new Person();

                if (IsBirthday(firstPerson))
                {
                    currentPerson = familyTree.FirstOrDefault(p => p.Birthday == firstPerson);

                    if (currentPerson==null)
                    {
                        currentPerson = new Person();
                        currentPerson.Birthday = firstPerson;
                        familyTree.Add(currentPerson);

                    }
                    SetChild(familyTree, currentPerson, secondPerson);
                }
                else
                {
                    currentPerson = familyTree.FirstOrDefault(p => p.Name == firstPerson);

                    if (currentPerson == null)
                    {
                        currentPerson = new Person();
                        currentPerson.Name = firstPerson;
                        familyTree.Add(currentPerson);
                    }
                    SetChild(familyTree, currentPerson, secondPerson);
                }
            }
            else
            {
                tokens = tokens[0].Split();
                string name = string.Join(" ", tokens[0], tokens[1]);
                string birthday = tokens[2];

                var person = familyTree.FirstOrDefault(p => p.Name == name || p.Birthday == birthday);

                if (person==null)
                {
                    person = new Person();
                    familyTree.Add(person);
                }
                else
                {
                    person.Name = name;
                    person.Birthday = birthday;

                    int index = familyTree.IndexOf(person)+1;
                    int count = familyTree.Count - index;

                    Person[] listCopy = new Person[count];
                    familyTree.CopyTo(index, listCopy, 0, count);
                    Person copyPerson = listCopy.FirstOrDefault(p=>p.Name==name || p.Birthday==birthday);


                    if (copyPerson!=null)
                    {
                        familyTree.Remove(copyPerson);
                        person.Parents.AddRange(copyPerson.Parents);
                        person.Parents = person.Parents.Distinct().ToList();

                        person.Children.AddRange(copyPerson.Children);
                        person.Children = person.Parents.Distinct().ToList();
                    }
                }
            }
            command = Console.ReadLine();
        }
        Console.WriteLine(mainPerson);
        Console.WriteLine("Parents: ");

        foreach (var p in mainPerson.Parents)
        {
            Console.WriteLine(p);
        }

        Console.WriteLine("Children: ");

        foreach (var c in mainPerson.Children)
        {
            Console.WriteLine(c);
        }

    }

    private static void SetChild(List<Person> familytree, Person parentPerson, string child)
    {
        var childPerson = new Person();
        if (IsBirthday(child))
        {
            if (!familytree.Any(p=>p.Birthday==child))
            {
                childPerson.Birthday = child;
            }
            else
            {
                childPerson = familytree.First(p => p.Birthday == child);
            }
            
        }
        else
        {
            if (!familytree.Any(p=>p.Name==child))
            {
                childPerson.Name = child;
            }
            else
            {
                childPerson = familytree.First(p => p.Name== child);
            }
        }
        parentPerson.Children.Add(childPerson);
        childPerson.Parents.Add(parentPerson);
        familytree.Add(childPerson);
    }

    static bool IsBirthday(string input)
    {
        return char.IsDigit(input[0]);
    }
}

