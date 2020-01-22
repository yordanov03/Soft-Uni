using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.SoftUni_Karaoke
{
    class Program
    {
        static void Main(string[] args)
        {
            var participants = Console.ReadLine().Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            var avaliableSongs = Console.ReadLine().Split(',').Select(x=>x.Trim()).ToList();
            string performances = Console.ReadLine();

            var result = new SortedDictionary<string, HashSet<string>>();

            while (performances!="dawn")
            {
                var separated = performances.Split(new[] { ','}, StringSplitOptions.RemoveEmptyEntries).ToList();
                var performer = separated[0].Trim();
                var song = separated[1].Trim();
                var award = separated[2].Trim();
                

                if (participants.Contains(performer) && avaliableSongs.Contains(song))
                {
                    if (!result.ContainsKey(performer))
                    {
                        result[performer] = new HashSet<string>();
                    }
                    
                    result[performer].Add(award);
                }

                performances = Console.ReadLine();
            }
            if (result.Count == 0)
            {
                Console.WriteLine("No awards");
            }
            else
            {
                var result1 = result.OrderByDescending(x =>x.Value.Count).ThenBy(x=>x.Key);

                foreach (var item in result1)
                {
                    Console.WriteLine($"{item.Key}: {item.Value.Count} awards");
                    var sortedAwards = item.Value.OrderBy(x => x);
                    foreach (var item1 in sortedAwards)
                    {
                        Console.WriteLine($"--{item1}");
                    }

                }
            }
        }
    }
}
