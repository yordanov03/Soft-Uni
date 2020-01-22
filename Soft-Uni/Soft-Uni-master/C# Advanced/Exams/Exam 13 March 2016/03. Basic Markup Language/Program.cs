using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _03.Basic_Markup_Language
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var results = new List<string>();

            while (input!= "<stop/>")
            {
                string pattern = @"<\s*(\w+)\s*\w*=\W(\d?)(\w+)\W?\s*\w*\S.([\w]*)";
                Regex regex = new Regex(pattern);
                MatchCollection matches = regex.Matches(input);
                string action = "";
                int repeatCount = 0;
                string content = "";
                StringBuilder sb = new StringBuilder();

                foreach (Match item in matches)
                {
                    if (input.Contains("value"))
                    {
                        action = item.Groups[1].Value;
                        repeatCount = int.Parse(item.Groups[3].Value);
                        content = item.Groups[4].Value;
                    }
                    else
                    {
                        action = item.Groups[1].Value;
                        content = item.Groups[3].Value;
                    }
                }

                if (action== "inverse")
                {
                    var currentLine = content.ToCharArray();

                    for (int i = 0; i < currentLine.Length; i++)
                    {
                        if (currentLine[i]>64 && currentLine[i]<91)
                        {
                            sb.Append((char)(currentLine[i] + 32));
                        }
                        else
                        {
                            sb.Append((char)(currentLine[i] - 32));
                        }
                    }
                    results.Add(sb.ToString());
                    sb = new StringBuilder();
                }
                else if (action == "reverse")
                {
                    var currentLine = content.ToCharArray();
                    for (int i = currentLine.Length - 1; i >= 0; i--)
                    {
                        sb.Append(currentLine[i]);
                    }
                    results.Add(sb.ToString());
                    sb = new StringBuilder();
                }
                else if (action== "repeat")
                {
                    for (int k = 0; k < repeatCount; k++)
                    {
                        results.Add(content);
                    }
                }

                 action = "";
                repeatCount = 0;
                 content = "";
                input = Console.ReadLine();
            }

            for (int i = 0; i < results.Count; i++)
            {
                Console.WriteLine($"{i+1}. {results[i]}");
            }
        }
    }
}
