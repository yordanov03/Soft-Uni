using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _05.Extract_Email
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(x => x.Trim(".,;:!?".ToCharArray()));
            string pattern = @"^([\w]+\d*\.*\-*)+@([a-zA-Z]+\-*)(\.*[a-zA-Z]\-*)+$";
            Regex regex = new Regex(pattern);


            foreach (var item in input)
            {
                if (Regex.IsMatch(item, pattern))
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
