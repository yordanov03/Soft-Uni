using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Serialize_String
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().ToCharArray();
            var results = new Dictionary<char, List<int>>();
            StringBuilder letter = new StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {
                
                if (!results.ContainsKey(input[i]))
                {
                    results[input[i]] = new List<int>();
                }
                results[input[i]].Add(i);
            }

            foreach (var item in results)
            {
                Console.WriteLine($"{item.Key}:{string.Join("/",item.Value)}");
            }
        }
    }
}
