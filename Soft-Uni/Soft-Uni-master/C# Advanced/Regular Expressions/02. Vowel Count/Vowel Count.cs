using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace _02.Vowel_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine().ToLower();
            string pattern = "@[auoyei]";
            Regex regex = new Regex(pattern);
            int count = regex.Matches(text).Count;
            Console.WriteLine($"Vowels: {count}");
            
        }
    }
}
