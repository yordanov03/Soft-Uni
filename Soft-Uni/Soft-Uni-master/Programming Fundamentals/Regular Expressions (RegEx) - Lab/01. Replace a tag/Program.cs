using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _01.Replace_a_tag
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            while (input!="end")
            {

                
                var pattern = @"<a.*?href.*?=(.*)>(.*?)<\/a>";
                Regex regex = new Regex(pattern);
                var replacement = "[URL href=$1]$2[/URL]";

                var result = regex.Replace(input, replacement);
                Console.WriteLine(result);
                input = Console.ReadLine();
            }
        }
    }
}
