using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _01.Match_Full_Name
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            Regex regex = new Regex(@"\b([A-Z]{1}[a-z]+) ([A-Z]{1}[a-z]+)\b");

            while (name!="end")
            {
                MatchCollection results = regex.Matches(name);

                foreach (var item in results)
                {
                    Console.WriteLine(item);
                }
                name = Console.ReadLine();
            }
            
        }
    }
}
