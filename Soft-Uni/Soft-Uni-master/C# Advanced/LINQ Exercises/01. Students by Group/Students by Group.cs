using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Students_by_Group
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var allPeople = new List<Student>();

            while (input!="END")
            {
                var separated = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                allPeople.Add(new Student { FirstName = separated[0], LastName = separated[1], Group = int.Parse(separated[2]) });
                input = Console.ReadLine();
            }

            var sorted = allPeople.Where(x => x.Group == 2).OrderBy(x => x.FirstName).ToList();

            foreach (var item in sorted)
            {
                Console.WriteLine(item.FirstName + " " + item.LastName);
            }


            
            
        }
    }
}
