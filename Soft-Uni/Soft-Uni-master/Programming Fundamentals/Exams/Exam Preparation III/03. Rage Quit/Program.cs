using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _03.Rage_Quit
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().ToUpper();

            string pattern1 = @"[^0-9]";
            Regex regex1 = new Regex(pattern1);

            string pattern = @"(\w.+?|\W.*?)([0-9])";
            Regex regex = new Regex(pattern);
            var matches = regex.Matches(input);
            var temp = input.ToString().ToList();
            var uniqueSymbolsUsed = temp.Distinct();

            for (int i = 0; i < matches.Count; i++)
            {
                var allSymbols = matches[i].ToString();
                var symbolsString = allSymbols.ToList();
                var times = Convert.ToInt32(symbolsString[symbolsString.Count-1])-48;
                symbolsString.RemoveAt(symbolsString.Count-1);
                var joined = string.Join("", symbolsString);

                for (int k = 0; k < times; k++)
                {
                    Console.Write(joined);
                }
            }
        }
    }
}
