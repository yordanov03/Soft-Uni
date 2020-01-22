using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _03.Jedi_Code_X
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfLines = int.Parse(Console.ReadLine());
            var allInputs = new List<string>();
            var jedis = new List<string>();
            var messages = new List<string>();
            int startIndex = 0;

            for (int i = 0; i < numberOfLines; i++)
            {
                allInputs.Add(Console.ReadLine());
            }
            string delimiter1 = Console.ReadLine();
            string delimiter2 = Console.ReadLine();
            var indexes = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            string pattern = @"^[A-z]+";
            Regex regex = new Regex(pattern);
            int numberOfOccurances = 0;

            foreach (var line in allInputs)
            {
                var currentLine = line;
                var changedLine = "";
                if (line.Contains(delimiter1))
                {
                    numberOfOccurances = (line.Length - line.Replace(delimiter1, "").Length) / delimiter1.Length;

                    for (int i = 0; i < numberOfOccurances; i++)
                    {
                        startIndex = currentLine.IndexOf(delimiter1)+delimiter1.Length;
                        changedLine = currentLine.Remove(0,startIndex);

                        if (regex.IsMatch(changedLine))
                        {
                            Match match = Regex.Match(changedLine, pattern);
                            jedis.Add(match.ToString());
                        }
                        currentLine = changedLine;
                    }
                }
                else if (line.Contains(delimiter2))
                {
                    numberOfOccurances = (line.Length - line.Replace(delimiter2, "").Length) / delimiter2.Length;

                    for (int i = 0; i < numberOfOccurances; i++)
                    {
                        startIndex = currentLine.IndexOf(delimiter2) + delimiter2.Length;
                        changedLine = currentLine.Remove(0, startIndex);

                        if (regex.IsMatch(changedLine))
                        {
                            Match match = Regex.Match(changedLine, pattern);
                            messages.Add(match.ToString());
                        }
                        currentLine = changedLine;
                    }
                }
                numberOfOccurances = 0;
                startIndex = 0;
            }

            for (int i = 0; i < jedis.Count; i++)
            {
                if (indexes[i]<=messages.Count)
                {
                    Console.WriteLine($"{jedis[i]} - {messages[indexes[i]-1]}");
                }
            }

        }
    }
}
