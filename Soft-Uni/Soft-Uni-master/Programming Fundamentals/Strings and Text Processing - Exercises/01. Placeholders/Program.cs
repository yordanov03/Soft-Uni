using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Placeholders
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
  
            while (input!="end")
            {
                
                var inputParams = input.Split(new[] { '>', '-' }, StringSplitOptions.RemoveEmptyEntries);
                var sentence = inputParams[0].TrimEnd();
                var words = inputParams[1].TrimStart().Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                for (int i = 0; i < words.Count; i++)
                {
                    string placeholder = "{" + i + "}";
                    sentence = sentence.Replace(placeholder, words[i]);
                }
                Console.WriteLine(sentence);
                input = Console.ReadLine();
                }
            }
        }
    }

