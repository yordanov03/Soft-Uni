using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Short_Words_Sorted
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().ToLower().Split(new[] { '.', ',', ':', ';', '(', ')', '[', ']', '\\', '\"', '\'', '/', '!', '?', ' ' },StringSplitOptions.RemoveEmptyEntries).ToList();
            var result = input.Where(w => w.Length < 5).OrderBy(w => w).Distinct();

            Console.WriteLine(string.Join(", ", result));
        }
    }
}
