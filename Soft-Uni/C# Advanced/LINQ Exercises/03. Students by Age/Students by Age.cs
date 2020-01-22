using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Students_by_Age
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var allPeople = new List<Student>();

            while (input!="END")
            {
                var separated = input.Split(' ').ToList();
                allPeople.Add(new Student { FirstName = separated[0], LastName = separated[1], Age = int.Parse(separated[2]) });
                input = Console.ReadLine();
            }
            var sorted = allPeople.Where(x => x.Age > 17 && x.Age < 25).ToList();
            for (int i = 0; i < sorted.Count; i++)
            {
                Console.WriteLine(string.Join(" ", sorted[i].FirstName, sorted[i].LastName, sorted[i].Age));
            }
        }
    }
}
