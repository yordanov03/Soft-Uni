using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _04.Ashes_of_Roses
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var data = new Dictionary<string, Dictionary<string, int>>();
            

            while (input!= "Icarus, Ignite!")
            {
                string patternInput = @"^Grow\s<\w+>\s<\w+>\s\d+$";
                Regex regexInput = new Regex(patternInput);
                if (regexInput.IsMatch(input))
                {
                    var separated = input.Split(new[] { ' ', '>', '<' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                    if (separated[0] != "Grow")
                    {
                        break;
                    }
                    string regionName = separated[1];
                    var colorName = separated[2];
                    int roseAmount = int.Parse(separated[3]);

                    string patternRegion = @"^[A-Z]{1}[a-z]+$";
                    Regex regexRegion = new Regex(patternRegion);

                    if (regexRegion.IsMatch(regionName))
                    {
                        string patternColor = @"^\w+[^_]$";
                        Regex regexColor = new Regex(patternColor);

                        if (regexColor.IsMatch(colorName))
                        {
                            if (!data.ContainsKey(regionName))
                            {
                                data[regionName] = new Dictionary<string, int>();
                            }
                            if (!data[regionName].ContainsKey(colorName))
                            {
                                data[regionName].Add(colorName, 0);
                            }
                            data[regionName][colorName] += roseAmount;
                        }
                    }
                }

                input = Console.ReadLine();
            }

            foreach (var region in data.OrderByDescending(x=>x.Value.Values.Sum()).ThenBy(x=>x.Key))
            {
                Console.WriteLine(region.Key);

                foreach (var rose in region.Value.OrderBy(x=>x.Value).ThenBy(x=>x.Key))
                {
                    Console.WriteLine($"*--{rose.Key} | {rose.Value}");
                }
            }
        }
    }
}
