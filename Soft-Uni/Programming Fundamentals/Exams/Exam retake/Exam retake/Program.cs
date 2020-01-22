using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_retake
{
    class Program
    {
        static void Main(string[] args)
        {
            var command = Console.ReadLine();
            var results = new SortedDictionary<string, Dictionary<string, double>>();
            var names = new List<string>();
            int count = 1;

            while (command!="quit")
            {
                var separated = command.Split(new[] {'-', '>' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                var team = separated[1].Trim();
                var wormName = separated[0].Trim();
                var wormScore = double.Parse(separated[2].Trim());

                if (!names.Contains(wormName))
                {
                    if (!results.ContainsKey(team))
                    {
                        results[team] = new Dictionary<string, double>();
                        results[team].Add(wormName, wormScore);
                    }
                    else if (results.ContainsKey(team))
                    {
                        results[team].Add(wormName, wormScore);
                    }
                    names.Add(wormName);

                }
                command = Console.ReadLine();
            }

            var newResults = results.OrderByDescending(x => x.Value.Values.Sum()).ThenByDescending(x => x.Value.Values.Sum()/x.Value.Keys.Count);

            foreach (var item in newResults)
            {
                Console.WriteLine($"{count}. Team: {item.Key} - {item.Value.Values.Sum()}");
                foreach (var item1 in item.Value.OrderByDescending(x=> x.Value))
                {
                    Console.WriteLine($"###{item1.Key} : {item1.Value}");
                }
                count++;
            }
        }
    }
}
