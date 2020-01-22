using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Text_filter
{
    class Program
    {
        static void Main(string[] args)
        {
            var bannedWords = Console.ReadLine().Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            var text = Console.ReadLine();

            for (int i = 0; i < bannedWords.Count; i++)
            {
                if (text.Contains(bannedWords[i]))
                {
                    text = text.Replace(bannedWords[i], new string('*', bannedWords[i].Length));
                }
            }

            Console.WriteLine(text);
        }
    }
}
