using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _03.Word_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = File.ReadAllText("words.txt").ToLower().Split(' ');
            string[] text = File.ReadAllText("text.txt").ToLower().Split(new char[] { '\n', '\r', ' ', '.', ',', '!', '?', '-' }, StringSplitOptions.RemoveEmptyEntries);
            ;

            var results = new SortedDictionary<string, int>();

            for (int i = 0; i < words.Length; i++)
            {
                for (int j = 0; j < text.Length; j++)
                {
                    if (words[i] == text[j])
                    {
                        if (!results.ContainsKey(words[i]))
                        {
                            results.Add(words[i], 0);
                        }
                        results[words[i]]++;
                    }
                }
            }

            var results1 = results.OrderByDescending(x => x.Value);
            File.AppendAllText("results.txt", string.Join(" ", results1));
        }
    }
}
