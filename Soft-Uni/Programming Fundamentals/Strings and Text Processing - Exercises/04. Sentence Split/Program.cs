using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Sentence_Split
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().ToLower().Split(new[] { ',', ' ', '=', '-', '>', ':', '~', '}', '|', '{', '`', '^', ']', '\\', '[', '?', '<', ';', '/', '.', '+', '*', ')', '(', '&', '%', '$', '#', '\"', '!' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            StringBuilder firstLetter = new StringBuilder();
            var results = new List<string>();
            var resultSentences = new List<string>();

            while (!input.Contains("end"))
            {
                for (int i = 0; i < input.Count; i++)
                {

                    for (int j = 0; j < input[i].Length; j++)
                    {
                        
                        if (j==0)
                        {
                            var toBeChanged = Convert.ToInt32(input[i][j]);
                            toBeChanged -= 32;
                            var changed = Convert.ToChar(toBeChanged);
                            firstLetter.Append(changed);
                        }
                        else
                        {
                            firstLetter.Append(input[i][j]);
                        }

                    }
                    var united = firstLetter.ToString().TrimStart();
                    results.Add(united);
                    united = "";
                    firstLetter.Clear();
                }
                Console.WriteLine(string.Join(", ",results));
                results.Clear();
                input = Console.ReadLine().ToLower().Split(new[] { ',', ' ', '=', '-', '>', ':', '~', '}', '|', '{', '`', '^', ']', '\\', '[', '?', '<', ';', '/', '.', '+', '*', ')', '(', '&', '%', '$', '#', '\"', '!' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            }
        }
    }
}
