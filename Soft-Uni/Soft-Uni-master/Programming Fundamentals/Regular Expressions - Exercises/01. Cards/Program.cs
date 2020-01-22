using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _01.Cards
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().ToUpper();
            var pattern = "(([2-9]|10|[JKQA])[SHCD])";
            Regex regex = new Regex(pattern);
            MatchCollection results = Regex.Matches(input, pattern);
            string[] cards = new string[results.Count];
            int count = 0;

            foreach (Match item in results)
            {
                cards[count] = item.Groups[1].Value;
                count++;

            }

            Console.WriteLine(string.Join(", ", cards));
          
        }
    }
}
