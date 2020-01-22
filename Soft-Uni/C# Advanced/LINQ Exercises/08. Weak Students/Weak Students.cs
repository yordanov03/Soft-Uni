using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Weak_Students
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var data = new List<Student>();

            while (input!="END")
            {
                var separated = input.Split(' ').ToList();
                data.Add(new Student { FirstName = separated[0], LastName = separated[1], Marks = separated.Skip(2).Select(double.Parse).ToList() });
                input = Console.ReadLine();
            }
            var filteredMarks = data.Where(s => s.Marks.Where(n => n <= 3).Count() >= 2).Select(m => m.FirstName + " " + m.LastName).ToList();
            

            for (int i = 0; i < filteredMarks.Count; i++)
            {
                Console.WriteLine(filteredMarks[i]);
            }
        }
    }
}
