using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _04.Replace_a_tag
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            while (input!="end")
            {
                Regex regex = new Regex(@"(<a )(.+?)(>)(.+?)(<\/a>)");
                string replacement = "[URL $2]$4[/URL]";
                var result = regex.Replace(input, replacement);
                Console.WriteLine(result);
                input = Console.ReadLine();
            }
        }
    }
}
