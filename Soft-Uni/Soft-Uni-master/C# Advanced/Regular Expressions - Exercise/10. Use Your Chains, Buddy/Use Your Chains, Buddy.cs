using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _10.Use_Your_Chains__Buddy
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Regex regex = new Regex(@"<p>(.*?)<\/p>");
            MatchCollection results = regex.Matches(input);

            foreach (Match item in results)
            {
                var sentence = item.Groups[1].Value;
                string whispacesPattern = @"[^a-z0-9]+";
                var replaced = Regex.Replace(sentence, whispacesPattern, " ");
                string pattern = @"\s+";
                replaced = Regex.Replace(replaced, pattern, " ");
                

                foreach (char letter in replaced)
                {
                    if (letter>='a' && letter<='m')
                    {
                        Console.Write((char)(letter+13));
                    }
                    else if (letter>='n' && letter<='z')
                    {
                        Console.Write((char)(letter-13));
                    }
                    else
                    {
                        Console.Write(letter);
                    }

                }


            }
        }
    }
}
