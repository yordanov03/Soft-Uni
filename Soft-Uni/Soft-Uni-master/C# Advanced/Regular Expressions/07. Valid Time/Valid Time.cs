using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _07.Valid_Time
{
    class Program
    {
        static void Main(string[] args)
        {
            string time = Console.ReadLine();
            Regex regex = new Regex(@"^([0-1][0-9]):([0-5][0-9]):([0-5][0-9]) (AM|PM)$");

            while (time!="END")
            {
                Match result = regex.Match(time);
                if (result.Success)
                {
                    Console.WriteLine("valid");
                }
                else
                {
                    Console.WriteLine("invalid");
                }
                time = Console.ReadLine();
            }
        }
    }
}
