using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Champion_s_League
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var data = new List<Team>();

            while (input != "stop")
            {
                var separated = input.Split(new[] { '|', ':' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                string opponent1 = separated[0].TrimEnd();
                string opponent2 = separated[1].Trim();
                int opponent1host = int.Parse(separated[2]);
                int opponent2guest = int.Parse(separated[3]);
                int opponent2host = int.Parse(separated[4]);
                int opponent1guest = int.Parse(separated[5]);
                int totalGoalsTeam1 = opponent1host + opponent1guest;
                int totalGoalsTeam2 = opponent2guest + opponent2host;
                string winner = "";


                if (totalGoalsTeam1 > totalGoalsTeam2)
                {
                    winner = opponent1;
                }
                else if (totalGoalsTeam1 < totalGoalsTeam2)
                {
                    winner = opponent2;
                }
                else if (totalGoalsTeam2 == totalGoalsTeam1)
                {
                    if (opponent2guest > opponent1guest)
                    {
                        winner = opponent2;
                    }
                    else if (opponent2guest < opponent1guest)
                    {
                        winner = opponent1;
                    }
                }

                Team matches1 = data.Where(x => x.teamName == opponent1).FirstOrDefault();

                if (matches1 == null)
                {
                    Team currentTeam = new Team { teamName = opponent1, opponents = new HashSet<string> { opponent2 }, wins = 0 };
                    data.Add(currentTeam);
                    if (winner == currentTeam.teamName)
                    {
                        currentTeam.wins++;
                    }
                }
                else
                {
                    matches1.opponents.Add(opponent2);
                    if (winner == opponent1)
                    {
                        matches1.wins++;
                    }
                }

                var matches2 = data.Where(x => x.teamName == opponent2).FirstOrDefault();

                if (matches2 == null)
                {
                    Team currentTeam = new Team { teamName = opponent2, opponents = new HashSet<string> { opponent1 }, wins = 0 };
                    data.Add(currentTeam);

                    if (winner == currentTeam.teamName)
                    {
                        currentTeam.wins++;
                    }
                }
                else
                {
                    matches2.opponents.Add(opponent1);
                    if (winner == opponent2)
                    {
                        matches2.wins++;
                    }
                }
                input = Console.ReadLine();
            }
            foreach (var team in data.OrderByDescending(x => x.wins).ThenBy(x => x.teamName))
            {
                Console.WriteLine(team.teamName);
                Console.WriteLine($"- Wins:{team.wins}");
                Console.WriteLine($"- Opponents: {string.Join(", ", team.opponents.OrderBy(x => x))}");
            }
        }
    }
}
