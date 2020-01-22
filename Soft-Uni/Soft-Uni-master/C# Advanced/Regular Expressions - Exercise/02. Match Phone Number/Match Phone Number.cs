using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _02.Match_Phone_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string phoneNumber = Console.ReadLine();
            Regex regex = new Regex(@"^\+359( |-)2(\1)([0-9]{3})(\1)([0-9]{4})$");

            while (phoneNumber!="end")
            {
                MatchCollection results = regex.Matches(phoneNumber);
                foreach (var item in results)
                {
                    Console.WriteLine(item);
                }
                phoneNumber = Console.ReadLine();
            }
        }
    }
}
