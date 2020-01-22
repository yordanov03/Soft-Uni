using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _07.Valid_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split('/','\\','(',')',' ').ToList();
            string pattern  = @"\b([a-zA-Z])([a-zA-Z0-9_*]){2,24}\b";
            List<string> validUserNames = new List<string>();

            int currentCount = 0;
            int maxCount = 0;
            string biggest1 = "";
            string biggest2 = "";


            for (int i = 0; i < input.Count; i++)
            {
                if (Regex.IsMatch(input[i],pattern))
                {
                    validUserNames.Add(input[i]);
                }
            }

            for (int i = 1; i < validUserNames.Count; i++)
            {
                currentCount = validUserNames[i].Length + validUserNames[i - 1].Length;
                if (currentCount>maxCount)
                {
                    maxCount = currentCount;
                    biggest1 = validUserNames[i - 1];
                    biggest2 = validUserNames[i];
                }
            }

            Console.WriteLine(biggest1);
            Console.WriteLine(biggest2);
        }
    }
}
