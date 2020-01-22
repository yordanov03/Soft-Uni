using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _08.Extract_Hyperlinks
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            Regex regex = new Regex("<a\n*\\s*.*?(href)\\s*=\\s*\n*('|\"*)\\s*(.*?)\\2");

            while (input!="END")
            {
                MatchCollection results = regex.Matches(input);
                foreach (Match item in results)
                {
                    Console.WriteLine(item.Groups[3].Value);
                }
                input = Console.ReadLine();
            }
        }
    }
}
