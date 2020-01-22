using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Group_by_Group
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var data = new List<Person>();

            while (input!="END")
            {
                var separated = input.Split(' ').ToList();
                data.Add(new Group_by_Group.Person { Name = string.Join(" ", separated[0], separated[1]), Group = int.Parse(separated[2]) });
                input = Console.ReadLine();

            }
            var grouped = data.GroupBy(x => x.Group).ToList();

            foreach (var item in grouped.OrderBy(x=>x.Key))
            {
                Console.WriteLine($"{item.Key} - {string.Join(", ", item.Select(p=>p.Name))}");
            }
        }
    }
}
