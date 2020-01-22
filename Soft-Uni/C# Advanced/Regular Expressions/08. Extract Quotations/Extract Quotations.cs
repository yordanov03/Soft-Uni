using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _08.Extract_Quotations
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Regex regex = new Regex("('|\")(.+?)(\\1)");

            MatchCollection result = regex.Matches(input);

            foreach (Match item in result)
            {
                Console.WriteLine(item.Groups[2].Value);
            }



        }
    }
}
