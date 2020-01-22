using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _01.Registered_Users
{
    class Program
    {
        static void Main(string[] args)
        {
            var databatse = new Dictionary<string, DateTime>();
            var line = Console.ReadLine();

            while (line!="end")
            {
                var split = line.Split(new[] { '-','>', ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var name = split[0];
                var date = split[1];
                var dateOfRegistration = DateTime.ParseExact(date, "dd/MM/yyyy", CultureInfo.InvariantCulture);

                databatse.Add(name, dateOfRegistration);
                line = Console.ReadLine();
            }

            var results = databatse.Reverse().OrderBy(x => x.Value).Take(5).OrderByDescending(x=>x.Value);

            foreach (var item in results)
            {
                Console.WriteLine(item.Key);
            }

        
        }
    }
}
