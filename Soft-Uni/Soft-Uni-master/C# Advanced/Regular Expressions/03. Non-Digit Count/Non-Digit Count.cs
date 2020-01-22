using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _03.Non_Digit_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string pattern = "[^\\d]";
            Regex regex = new Regex(pattern);
            int count = regex.Matches(text).Count;
            Console.WriteLine($"Non-digits: {count}");
        }
    }
}
