using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.First_Name
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var letters = Console.ReadLine().ToUpper().ToCharArray().Where(c => c != ' ').ToArray();
            var names = input.Where(n => letters.Contains(n[0])).ToArray();

            Console.WriteLine((names.Length==0? "No match" : names.OrderBy(n=>n).First()));
        }
    }
}
