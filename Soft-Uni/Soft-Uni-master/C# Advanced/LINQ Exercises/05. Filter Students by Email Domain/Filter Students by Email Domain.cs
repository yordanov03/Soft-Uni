using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Filter_Students_by_Email_Domain
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
                data.Add(new Students { FirstName = separated[0], LastName = separated[1], Email = separated[2] });
                input = Console.ReadLine();
            }
            var filtered = data.Where(x => x.Email.Contains("@gmail.com")).ToList();

            for (int i = 0; i < filtered.Count; i++)
            {
               Console.WriteLine( string.Join(" ", filtered[i].FirstName, filtered[i].LastName));
            }
        }
    }
}
