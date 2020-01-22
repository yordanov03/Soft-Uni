using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3___Wormhole
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            int count = 0;

            for (int i = 0; i < input.Count; i++)
            {
                if (input[i] == 0)
                {
                    count++;
                }
                else
                {
                    var temp = i;
                    i = input[i];
                    input[temp] = 0;
                    count++;
                }
            }

            Console.WriteLine(count);
        }
    }
}
