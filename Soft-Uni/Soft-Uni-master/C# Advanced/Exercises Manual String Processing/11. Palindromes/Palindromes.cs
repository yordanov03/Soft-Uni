using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Palindromes
{
    class Palindromes
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new[] { ' ',',','!','?','.' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            var results = new SortedSet<string>();
            foreach (var word in input)
            {
                var firstPart = "";
                var secondPart = "";
                var reversed = "";
      
                if (word.Length==1)
                {
                    results.Add(word);
                }
                else
                {

                    firstPart = word.Substring(0, word.Length / 2);

                    if (word.Length%2==0)
                    {
                        secondPart = word.Substring(word.Length / 2, (word.Length - 1) - (word.Length / 2)+1);
                    }
                    else
                    {
                        secondPart = word.Substring(word.Length / 2+1, (word.Length-word.Length/2)-1);
                    }

                    for (int i = secondPart.Length - 1; i >= 0; i--)
                    {
                        reversed += secondPart[i];
                    }

                    if (firstPart.ToLower()==reversed.ToLower())
                    {
                        results.Add(word);
                    }

                }
            }

            Console.WriteLine("[{0}]", string.Join(", ", results));
        }
    }
}
