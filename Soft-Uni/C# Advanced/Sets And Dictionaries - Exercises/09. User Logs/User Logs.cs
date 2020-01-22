using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.User_Logs
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var database = new SortedDictionary<string, Dictionary<string, int>>();

            while (input!="end")
            {
                var separated = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                var firstPart = separated[0].Split('=').ToList();
                var IP = firstPart[1];
                var thirdPart = separated[2].Split('=').ToList();
                var user = thirdPart[1];

                if (!database.ContainsKey(user))
                {
                    database.Add(user, new Dictionary<string, int>());
                    database[user].Add(IP, 1);
                }
                else
                {
                    if (!database[user].ContainsKey(IP))
                    {
                        database[user].Add(IP, 1);
                    }
                    else
                    {
                        database[user][IP]++;
                    }
                }

                input = Console.ReadLine();
            }

            foreach (var entry in database)
            {
                Console.WriteLine($"{entry.Key}: ");
                Console.WriteLine("{0}.", string.Join(", ", entry.Value.Select(a=> $"{a.Key} => {a.Value}")));
            }
        }
    }
}
