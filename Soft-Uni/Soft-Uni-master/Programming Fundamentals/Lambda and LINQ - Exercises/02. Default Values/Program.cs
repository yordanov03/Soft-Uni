using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Default_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            var database = new Dictionary<string, string>();
            var nulldatabase = new Dictionary<string, string>();
            var line = Console.ReadLine();

            while (line!="end")
            {
                var split = line.Split(new[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
                var key = split[0];
                var value = split[1];

                if (value!="null")
                {
                    database[key] = value;
                }
                else
                {
                    nulldatabase[key] = value;
                }
                line = Console.ReadLine();
            }
            var replacement = Console.ReadLine();
            var newnulldatabase = new Dictionary<string, string>();

            foreach (var item in nulldatabase)
            {
                newnulldatabase.Add(item.Key, replacement);
            }

            var newdatabase = database.OrderByDescending(x => x.Value.Length);
            var alltogether = newdatabase.Concat(newnulldatabase);

            foreach (var item in alltogether)
            {
                Console.WriteLine($"{item.Key} <-> {item.Value}");
            }
        }
    }
}
