using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _03.Cubic_s_Messages
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            
            string pattern = @"^(\d+)([A-z]+)([^A-z]*)$";
            var results = new Dictionary<string, string>();

            while (input!= "Over!")
            {
                int number = int.Parse(Console.ReadLine());

                Regex regex = new Regex(pattern);
                MatchCollection matches = regex.Matches(input);

                foreach (Match item in matches)
                {
                    var numbers = (item.Groups[1].ToString() + item.Groups[3].ToString()).ToCharArray();
                    var word = item.Groups[2].ToString().ToCharArray();

                    if (word.Length==number)
                    { 
                        StringBuilder currentWord = new StringBuilder();
                        foreach (var num in numbers)
                        {
                            int currentNumber = num - 48;

                            if (currentNumber>-1 && currentNumber<10)
                            {
                                if (currentNumber >= 0 && currentNumber < word.Count())
                                {
                                    currentWord.Append(word[currentNumber]);
                                }
                                else if (currentNumber >= word.Count())
                                {
                                    currentWord.Append(" ");
                                }
                            }
                        }
                        results.Add(item.Groups[2].ToString(), currentWord.ToString());
                        currentWord = new StringBuilder();
                    }
                }

                input = Console.ReadLine();
            }

            foreach (var item in results)
            {
                Console.WriteLine($"{item.Key} == {item.Value}");
            }
        }
    }
}
