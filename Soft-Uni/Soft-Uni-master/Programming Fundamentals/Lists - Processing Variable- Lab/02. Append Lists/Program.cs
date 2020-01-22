using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Append_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split('|').ToList();
            input.Reverse();

            for (int i = 0; i < input.Count; i++)
            {
                List<int> newList = input[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
                for (int j = 0; j < newList.Count; j++)
                {
                    Console.Write("{0} ", newList[j]);
                }
            }
        }
    }
}
