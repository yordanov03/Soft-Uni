using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _05.Extract_Tags
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Regex regex = new Regex("<.+?>");
            

            while (input!="END")
            {
                MatchCollection results = regex.Matches(input);
                foreach (var item in results)
                {
                    Console.WriteLine(item);
                }

                input = Console.ReadLine().Trim();
            }
        }
    }
}
