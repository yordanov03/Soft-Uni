using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Palindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new[] { ' ', ',','?','!' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            var results = new List<string>();
            var outsideBackwardsResult = "";
            StringBuilder backwards = new StringBuilder();

            for (int i = 0; i < input.Count; i++)
            {
                for (int j = input[i].Length - 1; j >= 0; j--)
                {

                    backwards.Append(input[i][j]);
 
                }
                outsideBackwardsResult = backwards.ToString();
                if (input[i] == outsideBackwardsResult)
                {
                    results.Add(input[i]);
                }
                backwards.Clear();
            }

            results.Distinct();
            results.Sort();

            Console.WriteLine(string.Join(", ", results));
        }
    }
}
