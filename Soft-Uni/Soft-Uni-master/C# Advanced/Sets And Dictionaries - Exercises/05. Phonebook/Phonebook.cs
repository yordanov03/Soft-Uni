using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Phonebook
{
    class Phonebook
    {
        static void Main(string[] args)
        {
            var phonebook = new Dictionary<string, string>();
            var command = Console.ReadLine();

            while (command!="search")
            {
                var input = command.Split(new[] { '-' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                var name = input[0];
                var phoneNumber = input[1];

                if (!phonebook.ContainsKey(name))
                {
                    phonebook.Add(name, phoneNumber);
                }
                else
                {
                    phonebook[name] = phoneNumber;
                }
                command = Console.ReadLine();
            }
            
            var searchName = Console.ReadLine();
            while (searchName!="stop")
            {

                if (phonebook.ContainsKey(searchName))
                {
                    foreach (var item in phonebook)
                    {
                        if (item.Key == searchName)
                        {
                            Console.WriteLine($"{item.Key} -> {item.Value}");
                        }
                    }
                }
                else
                {
                    Console.WriteLine($"Contact {searchName} does not exist.");
                }
                searchName = Console.ReadLine();
            }
        }
    }
}
