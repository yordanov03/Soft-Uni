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
            string input = Console.ReadLine();
            Regex regex = new Regex(@"^[\w-]{3,16}$",RegexOptions.IgnoreCase);

            while (input != "END")
            {
                MatchCollection results = regex.Matches(input);
                if (results.Count == 0)
                {
                    Console.WriteLine("invalid");
                }
                else
                {
                    Console.WriteLine("valid");
                }
                input = Console.ReadLine();
            }
        }
    }
}
