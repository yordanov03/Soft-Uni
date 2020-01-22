using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Find_Evens_or_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            string type = Console.ReadLine();
            Queue<int> allNumbers = new Queue<int>();
            FillInNumbers(input, allNumbers);

            Predicate<int> Evrything;

            switch (allNumbers)
            {
                case "odd": Evrything = n => n % 2 == 0;
                default:
                    break;
            }






        private static void FillInNumbers(int[] input, Queue<int> allNumbers)
        {
            for (int i = input[0]; i <=input[1]; i++)
            {
                allNumbers.Enqueue(i);
            }
        }
    }
}
