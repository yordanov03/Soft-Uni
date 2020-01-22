using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004.Sentence_Split
{
    class Program
    {
        static void Main(string[] args)
        {
            var sentence = Console.ReadLine();
            var delimeter = Console.ReadLine();
            var result = sentence.Split(new string[] { delimeter }, StringSplitOptions.None).ToList();

            Console.WriteLine($"[{string.Join(", ", result)}]");
        }
    }
}
