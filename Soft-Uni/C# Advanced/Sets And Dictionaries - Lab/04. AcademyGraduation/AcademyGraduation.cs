using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.AcademyGraduation
{
    class AcademyGraduation
    {
        static void Main(string[] args)
        {
            var numberOfPeople = int.Parse(Console.ReadLine());
            var dnevnik = new SortedDictionary<string, List<double>>();

            for (int i = 0; i < numberOfPeople; i++)
            {
                var name = Console.ReadLine();
                dnevnik.Add(name, new List<double>());
                var marks = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToList();
                dnevnik[name] = marks;
                
            }

            foreach (var name in dnevnik)
            {
                Console.WriteLine($"{name.Key} is graduated with {name.Value.Average()}");
            }
        }
    }
}
