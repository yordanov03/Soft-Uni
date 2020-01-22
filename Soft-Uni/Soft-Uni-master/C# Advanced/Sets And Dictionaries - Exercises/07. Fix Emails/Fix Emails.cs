using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Fix_Emails
{
    class Program
    {
        static void Main(string[] args)
        {
            var database = new Dictionary<string, string>();
            var name = Console.ReadLine();
            while (name!="stop")
            {
                var email = Console.ReadLine();
                var toBeSplit = email.Split('.').ToList();
                var domain = toBeSplit[1];
                

                if (domain != "us" && domain != "uk")
                {

                    database.Add(name, email);
                }
                name = Console.ReadLine();
            }

            foreach (var item in database)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
