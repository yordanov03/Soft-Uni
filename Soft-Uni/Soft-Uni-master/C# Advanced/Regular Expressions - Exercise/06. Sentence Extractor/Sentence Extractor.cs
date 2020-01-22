namespace _5.Extract_Emails
{
    using System;
    using System.Linq;
    using System.Text.RegularExpressions;
    using System.Text.RegularExpressions;

    public class ExtractEmails
    {
        public static void Main() // How to solve without TrimEnd...
        {
            string key = Console.ReadLine();
            var input = Console.ReadLine();
            string pattern = $@"[^!?.]*\b{key}\b[^!?.]*?[!?.]";
            Regex regex = new Regex(pattern);
            MatchCollection results = regex.Matches(input);


            foreach (Match item in results)
            {
                Console.WriteLine(item);
            }

        }
    }
}