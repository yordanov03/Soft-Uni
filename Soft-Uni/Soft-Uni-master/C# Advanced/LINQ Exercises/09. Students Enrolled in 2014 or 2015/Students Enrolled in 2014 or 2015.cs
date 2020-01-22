using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Students_Enrolled_in_2014_or_2015
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var data = new List<Student>();

            while (input != "END")
            {
                var separated = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                data.Add(new Student { Number = separated[0], Marks = separated.Skip(1).Select(int.Parse).ToList() });
                input = Console.ReadLine();
            }

            var filtered = data.FindAll(x => x.Number.EndsWith("14") || x.Number.EndsWith("15")).Select(x => x.Marks).ToList();

            for (int i = 0; i < filtered.Count; i++)
            {
                Console.WriteLine(string.Join(" ", filtered[i]));
            }

        }
    }
}