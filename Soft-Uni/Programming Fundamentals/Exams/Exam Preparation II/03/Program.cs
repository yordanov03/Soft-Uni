using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _03
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            double health = 0;
            double damage = 0;
            var demons = new SortedDictionary<string, Dictionary<double, double>>();

            for (int i = 0; i < input.Count; i++)
            {
                demons[input[i]] = new Dictionary<double, double>();
                string pattern = @"[A-z]";
                Regex regex = new Regex(pattern);
                MatchCollection symbols = regex.Matches(input[i]);
                var stringArray = new string [symbols.Count];
                for (int j = 0; j < symbols.Count; j++)
                {
                    stringArray[j] = symbols[j].Groups[0].Value;
                }

                foreach (var stringArraychar in stringArray)
                {
                    health += Convert.ToChar(stringArraychar);
                }
                demons[input[i]].Add(health, 0);
                
                string pattern2 = @"(-?\d+\.?\d*)";
                Regex regex2 = new Regex(pattern2);
                MatchCollection symbols2 = regex.Matches(input[i]);
                List<double> extractedInts = new List<double>();
                foreach (Match symbol in symbols)
                {
                    double theid = double.Parse(symbol.Value);
                    extractedInts.Add(theid);
                }
                foreach (var extractedInt in extractedInts)
                {
                    damage += extractedInt;
                }

                string pattern1 = @"(\*|\/)";
                Regex regex1 = new Regex(pattern1);
                MatchCollection symbols1 = regex.Matches(input[i]);
                List<char> modifiers = new List<char>();
                foreach (Match symbol1 in symbols1)
                {
                    char temp = Convert.ToChar(symbol1);
                    modifiers.Add(temp);
                }

                foreach (var modifier in modifiers)
                {
                    if (modifier =='*')
                    {
                        damage = damage * 2;
                    }
                    else
                    {
                        damage = damage / 2;
                    }
                }

                demons[in]
            }

        }
    }
}
