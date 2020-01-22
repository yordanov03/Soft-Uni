using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _02.Problem_2___Worm_Ipsum
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            while (input != "Worm Ipsum")
            {
                string pattern = @"\b([A-Z]\w*)|(\w*)|(\.?)";
                Regex regex = new Regex(pattern);
                var isMatch = regex.IsMatch(input);
                var count = 1;
                var word = "";
                var replacementChar = "";
                var replacement = new List<string>();
                var readyToReplace = "";
                var ready = "";

                if (isMatch == true)
                {
                    var result = new Dictionary<string, Dictionary<char, int>>();
                    var separated = input.Split(new[] { ' ', '.' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                    for (int i = 0; i < separated.Count; i++)
                    {
                        if (!result.ContainsKey(separated[i]))
                        {
                            result[separated[i]] = new Dictionary<char, int>();
                        }

                        var wordToChar = separated[i].ToCharArray();

                        for (int j = 0; j < wordToChar.Length; j++)
                        {
                            if (!result[separated[i]].ContainsKey(wordToChar[j]))
                            {
                                result[separated[i]].Add(wordToChar[j], 0);
                            }
                            result[separated[i]][wordToChar[j]]++;
                        }

                        foreach (var wordInDic in result)
                        {
                            foreach (var number in wordInDic.Value)
                            {
                                if (number.Value > count)
                                {
                                    count = number.Value;
                                    word = wordInDic.Key;
                                    replacementChar = number.Key.ToString();
                                    for (int k = 0; k < word.Length; k++)
                                    {
                                        replacement.Add(replacementChar);
                                    }
                                    readyToReplace = string.Join("", replacement);
                                    ready = input.Replace(word, readyToReplace);
                                }
                            }
                        }
                    }



                }
                else
                {
                    Console.WriteLine(input);
                }

                Console.WriteLine(ready);
                input = Console.ReadLine();
            }





        }
    }
}
