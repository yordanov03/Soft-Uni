using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Parse_Tags
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputText = Console.ReadLine();
            var openTag = "<upcase>";
            var closedTag = "</upcase>";

            int startIndex = inputText.IndexOf(openTag);

            while (startIndex!=-1)
            {
                int endIndex = inputText.IndexOf(closedTag);
                if (endIndex==-1)
                {
                    break;
                }

                var toBeReplaced = inputText.Substring(startIndex, endIndex+closedTag.Length-startIndex);
                var replaced = toBeReplaced.Replace(openTag, " ").Replace(closedTag, " ").ToUpper().Trim();
                inputText = inputText.Replace(toBeReplaced, replaced);

                startIndex = inputText.IndexOf(openTag);
            }

            Console.WriteLine(inputText);
        }
    }
}
