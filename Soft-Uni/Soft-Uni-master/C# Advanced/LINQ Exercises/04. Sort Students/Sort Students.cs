using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Sort_Students
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var allPeople = new List<Student>();

            while (input != "END")
            {
                var separated = input.Split(' ').ToList();
                allPeople.Add(new Student { FirstName = separated[0], LastName = separated[1] });
                input = Console.ReadLine();

            }
            var ordered = allPeople.OrderBy(x => x.LastName).ThenByDescending(x => x.FirstName).ToList();

            for (int i = 0; i < ordered.Count; i++)
            {
                Console.WriteLine(string.Join(" ", ordered[i].FirstName, ordered[i].LastName));
            }
        }
    }
}
