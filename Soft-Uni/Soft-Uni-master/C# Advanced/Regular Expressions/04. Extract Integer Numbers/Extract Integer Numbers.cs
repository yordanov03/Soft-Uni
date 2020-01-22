using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _04.Extract_Integer_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string pattern = "[\\d]+";
            Regex regex = new Regex(pattern);
            MatchCollection result = regex.Matches(text);

            if (result.Count==0)
            {

            }
            else
            {
                foreach (var item in result)
                {
                    Console.WriteLine(item);
                }
            }
            
        }
    }
}
