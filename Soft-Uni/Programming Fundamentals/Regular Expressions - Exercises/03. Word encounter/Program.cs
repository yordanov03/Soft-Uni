using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _03.Word_encounter
{
    class Program
    {
        static void Main(string[] args)
        {
            var condition = Console.ReadLine();
            var input = Console.ReadLine();
            var separatedCondition = condition.ToCharArray();
            string patern = $@"\w*{separatedCondition[0]}{separatedCondition[1]}+w*\b|\b\w*{separatedCondition[0]}+\w*{separatedCondition[0]}+\w*\b";
            Regex regex = new Regex(patern);

            var isMatch = regex.IsMatch(input);
            Console.WriteLine(isMatch);
            
        }
    }
}
