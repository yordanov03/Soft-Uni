using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Optimized_Banking_System
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputLine = Console.ReadLine();
            var result = new List<BankAccount>();
            int count = 0;

            while (inputLine!="end")
            {
                var breakInputLine = inputLine.Split(new[] { ' ', '|' }, StringSplitOptions.RemoveEmptyEntries).ToList();

                var innerResults = new BankAccount();
                innerResults.Bank = breakInputLine[0];
                innerResults.Name = breakInputLine[1];
                innerResults.Balance = decimal.Parse(breakInputLine[2]);
                result.Add(innerResults);
                count++;
                inputLine = Console.ReadLine();
            }

            var finalResults = result.OrderByDescending(x => x.Balance).ThenBy(x => x.Bank.Length);
            foreach (var item in finalResults)
            {
                Console.WriteLine($"{item.Name} -> {item.Balance} ({item.Bank})");
            }
        }
    }
}
