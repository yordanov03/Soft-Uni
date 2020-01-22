using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace practice
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string pattern = @"<a\s+href=(.+?)>(.+?)<\/a>";
            Regex regex = new Regex(pattern);
            var replacement = "[URL href=$1]$2[/URL]";

            var result = regex.Replace(text, replacement);
            Console.WriteLine(result);

        }
    }
}
