using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _02.Fish_Statistics
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"(>*)(<+)(\(+)('|x|-)>";
            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(input);
            int count = 1;
            if (matches.Count == 0)
            {
                Console.WriteLine("No fish found.");
            }

            foreach (Match item in matches)
            {
                var status = item.Groups[4].ToString();
                
                Console.WriteLine($"Fish {count}: {item.Groups[0]}");
                if (item.Groups[1].Length<2)
                {
                    if (item.Groups[1].Length==0)
                    {
                        Console.WriteLine(" Tail type: None");
                    }
                    else
                    {
                        Console.WriteLine($" Tail type: Short (2 cm)");
                    }
                }
                else if (item.Groups[1].Length>1&& item.Groups[1].Length<5)
                {
                    Console.WriteLine($" Tail type: Medium ({item.Groups[1].Length*2} cm)");
                }

                else
                {
                    Console.WriteLine($" Tail type: Long ({item.Groups[1].Length * 2} cm)");
                }
                if (item.Groups[3].Length<=5)
                {
                    if (item.Groups[3].Length==0)
                    {
                        Console.WriteLine(" Body type");
                    }
                    
                    else{
                        Console.WriteLine($" Body type: Short ({item.Groups[3].Length * 2} cm)");
                    }
                }
                else if (item.Groups[3].Length> 5 && item.Groups[3].Length <=10)
                {
                    Console.WriteLine($" Body type: Medium ({item.Groups[3].Length * 2} cm)");
                }
                else
                {
                    Console.WriteLine($" Body type: Large ({item.Groups[3].Length * 2} cm)");
                }
                if (status == "'")
                {
                    Console.WriteLine(" Status: Awake");
                }
                else if (status =="-")
                {
                    Console.WriteLine(" Status: Asleep");
                }
                else
                {
                    Console.WriteLine(" Status: Dead");
                }


                count++;
            }
        }
    }
}
