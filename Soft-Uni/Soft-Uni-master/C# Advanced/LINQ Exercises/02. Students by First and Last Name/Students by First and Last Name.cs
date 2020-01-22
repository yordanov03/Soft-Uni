using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Students_by_First_and_Last_Name
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
                allPeople.Add(new Student { FirstName = separated[0], LastName = separated[1] });
                input = Console.ReadLine();

            }

            var sorted = allPeople.Where(x => x.FirstName[0] < x.LastName[0]).ToList();

            for (int i = 0; i < sorted.Count; i++)
            {
                Console.WriteLine(sorted[i].FirstName+" "+sorted[i].LastName);
            }
        }
    }
}
