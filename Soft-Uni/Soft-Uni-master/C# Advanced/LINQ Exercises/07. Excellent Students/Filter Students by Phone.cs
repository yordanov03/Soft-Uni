using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Excellent_Students
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var data = new List<Student>();

            while (input!="END")
            {
                var separated = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                data.Add(new Student { FirstName = separated[0], LastName = separated[1], Marks = separated.Skip(2).ToList() });
                input = Console.ReadLine();
            }

            var filtered = data.Where(x => x.Marks.Contains("6")).ToList();

            for (int i = 0; i < filtered.Count; i++)
            {
                Console.WriteLine(string.Join(" ", filtered[i].FirstName, filtered[i].LastName));
            }
        }
    }
}
