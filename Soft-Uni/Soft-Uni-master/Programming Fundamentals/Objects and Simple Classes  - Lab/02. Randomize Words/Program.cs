using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Diagnostics;

namespace _02.Randomize_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine().Split(' ').ToList();

            var random = new Random();

            for (int i = 0; i < words.Count; i++)
            {
                var randomPosition = random.Next(0, words.Count);

                var currentWord = words[i];
                var tempWord = words[randomPosition];
                words[randomPosition] = currentWord;
                words[i] = tempWord;
            }

            foreach (var item in words)
            {
                Console.WriteLine(item);
            }
        }
    }
}
