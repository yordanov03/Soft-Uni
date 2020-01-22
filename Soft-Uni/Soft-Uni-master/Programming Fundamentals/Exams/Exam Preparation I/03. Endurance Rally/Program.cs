using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Endurance_Rally
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            var trackLayout = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(float.Parse).ToList();
            var indexOfCheckpoints = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            double fuel = 0;

            for (int i = 0; i < names.Count; i++)
            {
                string contestant = names[i];
                var nameToArray = names[i].ToCharArray();
                int startingFuel = Convert.ToInt32(names[i][0]);
                fuel = startingFuel;

                for (int j = 0; j < trackLayout.Count; j++)
                {

                    if (indexOfCheckpoints.Contains(j))
                    {
                        fuel += trackLayout[j];
                    }
                    else
                    {
                        fuel -= trackLayout[j];
                    }
                    if (fuel < 0)
                    {
                        startingFuel = j;
                        break;
                    }
                }
                if (fuel > 0)
                {
                    Console.WriteLine($"{contestant} - fuel left {fuel:f2}");
                }

                else
                {
                    fuel = startingFuel;
                    Console.WriteLine($"{contestant} - reached {fuel}");
                }
                fuel = 0;
            }

        }
    }