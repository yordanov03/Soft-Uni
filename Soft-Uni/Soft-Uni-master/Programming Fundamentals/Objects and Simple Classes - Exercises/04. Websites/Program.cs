using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Websites
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputline = Console.ReadLine();
            var results = new List<Website>();

            while (inputline!="end")
            {
                var innerInputLine = inputline.Split(new[] { ' ', '|' ,','}, StringSplitOptions.RemoveEmptyEntries);
                var innerResults = new Website();
                innerResults.host = innerInputLine[0];
                innerResults.domain = innerInputLine[1];
                innerResults.queries = innerInputLine.Skip(2).ToList();

                results.Add(innerResults);

                inputline = Console.ReadLine();

            }

            foreach (var item in results)
            {
                if (item.queries.Count > 0)
                {
                    Console.WriteLine($"\nhttps://www.{item.host}.{item.domain}/query?=");
                    foreach (var item1 in item.queries)
                    {
                        Console.Write($"[{item1}]&");
                    }
                }
                else
                { Console.WriteLine($"\nhttps://www.{item.host}.{item.domain}"); }
            }
        }
    }
}
