using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Filter_Students_by_Phone
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var data = new List<Students>();

            while (input!="END")
            {
                var separated = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                data.Add(new Students { FirstName = separated[0], LastName = separated[1], PhoneNumber = separated[2] });
                input = Console.ReadLine();
            }
            var filtered = data.Where(x => x.PhoneNumber.StartsWith("02") || x.PhoneNumber.StartsWith("+359")).ToList();
            for (int i = 0; i < filtered.Count; i++)
            {
                Console.WriteLine(string.Join(" ", filtered[i].FirstName, filtered[i].LastName));
            }
        }
    }
}
