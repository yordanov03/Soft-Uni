using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Knights_of_Honor
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            Action<string[]> Knights = AddTitle;
            Knights(input);
        }

        private static void AddTitle(string[] everybody)
        {
            foreach (var item in everybody)
            {
                Console.WriteLine($"Sir {item}");
            }
        }
    }
}
