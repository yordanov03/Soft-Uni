using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Special_Words
{
    class Program
    {
        static void Main(string[] args)
        {
                 public static readonly char[] separators = new char[] { '(', ')', '[', ']', '<', '>', '-', '!', '?', ' ' };

        public static void Main()
        {
            var keyCounter = CountKeysOccurances();
            Console.WriteLine(string.Join(Environment.NewLine, keyCounter.Select(kvp => $"{kvp.Key} - {kvp.Value}")));
        }

        private static Dictionary<string, int> CountKeysOccurances()
        {
            var keys = Console.ReadLine().Split(separators, StringSplitOptions.RemoveEmptyEntries);
            var text = Console.ReadLine();

            var keyCounter = new Dictionary<string, int>();

            foreach (var word in keys)
            {
                keyCounter[word] = 0;

                var indexOfKey = text.IndexOf(word);

                while (indexOfKey >= 0)
                {
                    keyCounter[word]++;
                    indexOfKey = text.IndexOf(word, indexOfKey + 1);
                }
            }

            return keyCounter;
        }
    }
}
