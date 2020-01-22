using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrandPrix
{
    class StartUp
    {
        public static void Main(string[] args)
        {
            RaceTower raceTower = new RaceTower();

            int totalNumberOfLaps = int.Parse(Console.ReadLine());
            int trackLength = int.Parse(Console.ReadLine());
            raceTower.SetTrackInfo(totalNumberOfLaps, trackLength);

            while (raceTower.raceIsOver == false)
            {

                var input = Console.ReadLine();

                var separated = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                var command = separated[0];
                var data = separated.Skip(1).ToList();

                switch (command)
                {
                    case "RegisterDriver":
                        raceTower.RegisterDriver(data);
                        break;
                    case "Leaderboard":
                        Console.WriteLine(raceTower.GetLeaderboard());
                        break;
                    case "CompleteLaps":
                        Console.WriteLine(raceTower.CompleteLaps(data));
                        break;
                    case "Box":
                        raceTower.DriverBoxes(data);
                        break;
                    case "ChangeWeather":
                        raceTower.ChangeWeather(data);
                        break;
                }

            }
        }
    }
}

