using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Worms_World_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputLine = Console.ReadLine();
            var everyone = new SortedDictionary<string, Dictionary<string, double>>();
            var strengthAllTeam = new Dictionary<string, double>();
            int count = 1;



            while (inputLine != "quit")
            {
                var separated = inputLine.Split(new[] { '-', '>' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                var team = separated[1].Trim();
                var wormName = separated[0].Trim();
                var wormStreght = double.Parse(separated[2].Trim());

                if (!everyone.ContainsKey(team))
                {
                    everyone[team] = new Dictionary<string, double>();
                }
                if (!strengthAllTeam.ContainsKey(team))
                {
                    strengthAllTeam[team] = 0;
                }


                else
                {
                    everyone[team].Add(wormName, wormStreght);
                    strengthAllTeam[team] += wormStreght;
                    inputLine = Console.ReadLine();
                }

            }

            foreach (var team in strengthAllTeam.OrderByDescending(x => x.Value))
            {
                Console.WriteLine($"{count}. Team : {team.Key} - {team.Value}");

                foreach (var entry in everyone)
                {
                    if (team.Key == entry.Key)
                    {
                        foreach (var worm in entry.Value.OrderByDescending(x => x.Value))
                        {
                            Console.WriteLine($"###{worm.Key} : {worm.Value}");
                        }
                    }


                }
                count++;
            }


        }
    }
}